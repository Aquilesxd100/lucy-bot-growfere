using bot_lucy_growfere.commands;
using bot_lucy_growfere.database.banco;
using bot_lucy_growfere.database.local;
using bot_lucy_growfere.Secrets;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using DSharpPlus.Lavalink;
using DSharpPlus.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bot_lucy_growfere
{
    internal class Program
    {
        private static DiscordClient Client { get; set; }
        private static CommandsNextExtension Commands { get; set; }

        static async Task Main(string[] args)
        {
            await SecretsReader.GetSecrets();

            DiscordConfiguration discordConfig = new DiscordConfiguration()
            {
                Intents = DiscordIntents.All,
                Token = SecretsReader.botToken,
                TokenType = TokenType.Bot,
                AutoReconnect = true
            };

            Client = new DiscordClient(discordConfig);

            Client.Ready += Client_Ready;

            var commandsConfig = new CommandsNextConfiguration()
            {
                StringPrefixes = new string[] { "!" },
                EnableMentionPrefix = true,
                EnableDms = true,
                EnableDefaultHelp = false,
            };

            Commands = Client.UseCommandsNext(commandsConfig);

            Commands.RegisterCommands<Commands>();

            Client.VoiceStateUpdated += Client_VoiceStateUpdated;

            var endPointLavaLink = new ConnectionEndpoint
            {
                Hostname = "lavalink.lexnet.cc",
                Port = 443,
                Secured = true
            };

            var lavaLinkConfig = new LavalinkConfiguration
            {
                Password = "lexn3tl@val!nk",
                RestEndpoint = endPointLavaLink,
                SocketEndpoint = endPointLavaLink
            };

            var lavaLink = Client.UseLavalink();

            await Client.ConnectAsync();
            await lavaLink.ConnectAsync(lavaLinkConfig);
            Console.WriteLine("_Lucy: Oii, estou pronta mais uma vez!");
            await Task.Delay(-1);
        }

        private static async Task Client_VoiceStateUpdated(
            DiscordClient sender,
            VoiceStateUpdateEventArgs voiceState
        )
        {
            LavalinkExtension lavaLink = Client.GetLavalink();
            DiscordChannel canalDeVoz = voiceState.Channel;

            if (
                voiceState.User.IsBot
                || canalDeVoz == null
                || sender.CurrentUser.Username != BancoLocal.usernameMarcelo
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
                && Fernando_E_Lucas.All(u => u.VoiceState.IsSelfDeafened)
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

                    if (conexao == null) {
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
            DSharpPlus.Lavalink.EventArgs.TrackFinishEventArgs args)
        {
            await Task.Delay(1500);
            conexao.DisconnectAsync();
        }

        private static Task Client_Ready(
            DiscordClient sender,
            DSharpPlus.EventArgs.ReadyEventArgs args
        )
        {
            return Task.CompletedTask;
        }
    }
}
