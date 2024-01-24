using bot_lucy_growfere.database.banco;
using bot_lucy_growfere.database.local;
using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using DSharpPlus.Lavalink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bot_lucy_growfere.comandos
{
    static internal class ComandosVoz
    {
        public static async Task ReceberMarcelo(
            DiscordClient usuarioQueAtivou, 
            VoiceStateUpdateEventArgs voiceState
        )
        {
            LavalinkExtension lavaLink = Program.Client.GetLavalink();
            DiscordChannel canalDeVoz = voiceState.Channel;
            if (
                canalDeVoz == null
                || usuarioQueAtivou.CurrentUser.Username != BancoLocal.usernameMarcelo
                || !lavaLink.ConnectedNodes.Any()
            )
            {
                return;
            }

            var Fernando_E_Lucas =
                canalDeVoz.Users.Where(u =>
                    u.Username == BancoLocal.usernameFernando
                    || u.Username == BancoLocal.usernameLucas
                )
                .ToArray();

            if (
                Fernando_E_Lucas.Length == 2
                && /*Fernando_E_Lucas.All(u => u.VoiceState.IsSelfDeafened)*/true
                && !BancoLocal.LucyRecebendoMarcelo
            )
            {
                string responseBanco = BancoDeDados.GetHoraUltimaMensagemMandada();
                if (responseBanco == null) { return; }
                DateTime dataAtual = DateTime.Now;
                DateTime ultimaVezRecebeuMarcelo = DateTime.Parse(responseBanco);
                bool passou16HorasDoIntervalo =
                    dataAtual.CompareTo(
                        ultimaVezRecebeuMarcelo.AddHours(16)
                    ) >= 0;

                if (passou16HorasDoIntervalo)
                {
                    BancoLocal.LucyRecebendoMarcelo = true;
                    await Task.Delay(700);

                    var nodeLavaLink = lavaLink.ConnectedNodes.Values.First();
                    await nodeLavaLink.ConnectAsync(canalDeVoz);

                    var conexao = nodeLavaLink.GetGuildConnection(voiceState.Guild);
                    conexao.PlaybackFinished += SairChamadaAposTocarAudioAsync;

                    if (conexao == null)
                    {
                        BancoLocal.LucyRecebendoMarcelo = false;
                        return;
                    }
                    LavalinkLoadResult resultadoPesquisa = await nodeLavaLink.Rest.GetTracksAsync(BancoLocal.codAudioReceberMarcelo);
                    if (
                        resultadoPesquisa.LoadResultType == LavalinkLoadResultType.NoMatches
                        || resultadoPesquisa.LoadResultType == LavalinkLoadResultType.LoadFailed
                    )
                    {
                        BancoLocal.LucyRecebendoMarcelo = false;
                        return;
                    }
                    var audio = resultadoPesquisa.Tracks.First();

                    await conexao.PlayAsync(audio);
                    BancoDeDados.AtualizarUltimaVezMarceloFoiRecebido(dataAtual);
                    await Task.Delay(4000);
                    BancoLocal.LucyRecebendoMarcelo = false;
                }
                else
                {
                    Console.WriteLine("_Lucy: Tentei receber o Marcelo mas ele já foi recebido hoje :c");
                }
            }
        }

        private static async Task SairChamadaAposTocarAudioAsync(
            LavalinkGuildConnection conexao,
            DSharpPlus.Lavalink.EventArgs.TrackFinishEventArgs args
        )
        {
            await Task.Delay(1500);
            conexao.DisconnectAsync();
        }
    }
}
