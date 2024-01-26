using DSharpPlus.CommandsNext;
using System;
using System.Threading.Tasks;
using bot_lucy_growfere.database.local;
using DSharpPlus.Entities;
using System.Collections.Generic;
using System.Linq;

namespace bot_lucy_growfere.modelos.jogos
{
    public class Adivinhacao
    {
        public bool JogoIniciado { get; set; }
        public int NumeroInicial { get; set; }
        public int NumeroFinal { get; set; }
        public int NumeroSortiado { get; set; }

        public Adivinhacao(int _numeroInicial = 0, int _numeroFinal = 1, bool ehNovoJogo = false) {
            JogoIniciado = ehNovoJogo;
            NumeroInicial = _numeroInicial;
            NumeroFinal = _numeroFinal;
            NumeroSortiado = new Random().Next(NumeroInicial, NumeroFinal);
        }

        public async Task Adivinhar(CommandContext ctx, int numeroAdivinhado)
        {
            // Acertou
            if (numeroAdivinhado == NumeroSortiado)
            {
                IReadOnlyList<DiscordMessage> mensagens = await ctx.Channel.GetMessagesAsync((NumeroFinal - NumeroInicial) > 100 ? NumeroFinal - NumeroInicial : 100);
                await ctx.Channel.SendMessageAsync($"Parabéns {ctx.User.Username} você acertou!!!");
                JogoIniciado = false;
                await LimparRegistrosJogo(mensagens, ctx);
            }
            else 
            {
                // Se tiver ao menos 30 possibilidades terei 30% de chance de dar uma dica
                bool dareiDica = (NumeroFinal - NumeroInicial) >= 30 && new Random().Next(0, 100) <= 30;

                if(dareiDica)
                {
                    await ctx.Channel.SendMessageAsync($"O número misterioso é {((numeroAdivinhado > NumeroSortiado) ? "menor" : "maior")}...");
                } 
                else
                {
                    await ctx.Channel.SendMessageAsync("Errou...");
                }
            }
        }

        public async Task LimparRegistrosJogo(
            IReadOnlyList<DiscordMessage> mensagens,
            CommandContext ctx
        )
        {
            List<DiscordMessage> mensagensTratadas = new List<DiscordMessage>(mensagens);

            List<DiscordMessage> mensagensFiltradas = mensagensTratadas.FindAll(mensagem =>
                mensagem.Content.Contains("!adivinhar") ||
                mensagem.Content.Contains("!pararJogoAdivinhacao") ||
                mensagem.Content.Contains("!iniciarJogoAdivinhacao") ||
                (
                    mensagem.Author.IsBot && (
                        mensagem.Content.Contains("O número misterioso é") ||
                        mensagem.Content.Contains("O número inicial não pode ser maior que o final e ambos precisam ser positivos.") ||
                        mensagem.Content.Contains("Jogo de adivinhação iniciado") ||
                        mensagem.Content.Contains("O jogo da adivinhação foi cancelado.") ||
                        mensagem.Content.Contains("você acertou!!!") ||
                        mensagem.Content.Contains("Errou...") ||
                        mensagem.Content.Contains("Um jogo de adivinhação já está em progresso") ||
                        mensagem.Content.Contains("Nenhum jogo está em progresso atualmente.") ||
                        mensagem.Content.Contains("Nenhum jogo de adivinhação está em progresso atualmente")
                    )
                )
            );
            foreach (var message in mensagensFiltradas)
            {
                await ctx.Channel.DeleteMessageAsync(message);
            }
        }
    }
}
