using bot_lucy_growfere.comandos;
using bot_lucy_growfere.controladores;
using bot_lucy_growfere.database.local;
using bot_lucy_growfere.modelos.jogos;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.Lavalink;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace bot_lucy_growfere.modelos.jogos
{

    public enum EstadoJogoDaVelha
    {
        EmProgresso = 1,
        Empate,
        Vitoria,
    }

    public class JogoDaVelha
    {
        public bool JogoIniciado { get; set; } = false;

        public bool VezDoJogadorX { get; set; } = true;

        public string[,] Campo { get; set; } = {
            {"          ", "          ", "          "},
            {"          ", "          ", "          "},
            {"          ", "          ", "          "},
        };

        public string MostraCampo()
        {
            string campoString = "--- A ---- B ---- C ---\n----------------------\n";
            for(int idx = 0; idx < Campo.GetLength(0); idx++) {
                campoString += idx + 1 + "  ";
                for (int idx2 = 0; idx2 < Campo.GetLength(1); idx2++)
                {
                    campoString += "|" + Campo[idx, idx2] + (idx2 == Campo.GetLength(1) - 1 ? "|" : "");
                };
                if (idx == Campo.GetLength(0) - 1)
                {
                    campoString += "\n----------------------";
                } else
                {
                    campoString += "\n-------     ----    ------\n";
                }
            }
            return campoString;
        }

        public async Task LimparRegistrosJogo(
            IReadOnlyList<DiscordMessage> mensagens, 
            CommandContext ctx
        )
        {
            List<DiscordMessage> mensagensTratadas = mensagens.Count > 35 
                ? new List<DiscordMessage>(mensagens.Take(35)) 
                : new List<DiscordMessage>(mensagens);

            List<DiscordMessage> mensagensFiltradas = mensagensTratadas.FindAll(mensagem =>
                mensagem.Content.Contains("!iniciarJogoVelha") ||
                mensagem.Content.Contains("!jogar") ||
                mensagem.Content.Contains("!pararJogoVelha") ||
                (
                    mensagem.Author.IsBot && (
                        mensagem.Content.Contains("--- A ---- B ----") ||
                        mensagem.Content.Contains("venceu!") ||
                        mensagem.Content.Contains("empate") ||
                        mensagem.Content.Contains("O jogo da velha foi cancelado.") ||
                        mensagem.Content.Contains("Informe uma posição válida") ||
                        mensagem.Content.Contains("Escolha um local vazio") ||
                        mensagem.Content.Contains("Um jogo da velha já está em progresso.") ||
                        mensagem.Content.Contains("Nenhum jogo está em progresso atualmente.")
                    )
                )
            );
            foreach (var message in mensagensFiltradas)
            {
                await ctx.Channel.DeleteMessageAsync(message);
            }
        }

        public EstadoJogoDaVelha VerificarEstadoJogo(CommandContext ctx)
        {
            int celulasPreenchidas = 0;

            for (int idx = 0; idx < Campo.GetLength(0); idx++)
            {
                int qntHorizontais = 1;

                string ultimoPreenchimento = "";
                for (int idx2 = 0; idx2 < Campo.GetLength(1); idx2++)
                {
                    if (Campo[idx, idx2] != "          ")
                    {
                        // Verifica as celulas Verticais e Diagonais
                        if (idx == 0)
                        {
                            // Verifica as celulas Diagonais
                            if (idx2 == 0 || idx2 == 2)
                            {
                                string[] celulasDiagonais = new string[]
                                 {
                                    null, Campo[1, 1], null
                                 };
                                celulasDiagonais[0] = idx2 == 0 ? Campo[0, 0] : Campo[0, 2];
                                celulasDiagonais[2] = idx2 == 0 ? Campo[2, 2] : Campo[2, 0];

                                bool tdsDiagonaisIguais = Array.TrueForAll(celulasDiagonais, elemento =>
                                    elemento.Equals(celulasDiagonais[0])
                                    && celulasDiagonais[0].Trim().Length > 0
                                );
                                if (tdsDiagonaisIguais)
                                {
                                    ultimoPreenchimento = celulasDiagonais[0];
                                    return EstadoJogoDaVelha.Vitoria;
                                }
                            }
                            // Verifica as celulas Verticais
                            string[] celulasVerticais = new string[]
                            {
                                    Campo[0, idx2], Campo[1, idx2], Campo[2, idx2]
                            };
                            bool todasVerticaisIguais = Array.TrueForAll(celulasVerticais, elemento =>
                                elemento.Equals(celulasVerticais[0])
                                && celulasVerticais[0].Trim().Length > 0
                            );
                            if (todasVerticaisIguais)
                            {
                                ultimoPreenchimento = celulasVerticais[0];
                                return EstadoJogoDaVelha.Vitoria;
                            }
                        }
                        // Verifica as celulas Horizontais
                        if (ultimoPreenchimento == Campo[idx, idx2])
                        {
                            qntHorizontais++;
                            if (qntHorizontais == 3)
                            {
                                return EstadoJogoDaVelha.Vitoria;
                            }
                        } 
                        else
                        {
                            ultimoPreenchimento = Campo[idx, idx2];
                        }
                        celulasPreenchidas++;
                    };
                }
            }
            if (celulasPreenchidas == 9)
            {
                return EstadoJogoDaVelha.Empate;
            } else
            {
                return EstadoJogoDaVelha.EmProgresso;
            }
        }

        public async Task Jogar(CommandContext ctx, string posicao)
        {
            int[] localPosicao = new int[2];
            if  (
                posicao.Length != 2 || 
                !new List<char>() { 'A', 'B', 'C', 'a', 'b', 'c' }.Contains(posicao[0]) || 
                !new List<char>() { '1', '2', '3' }.Contains(posicao[1])
                )
            {
                await ctx.Channel.SendMessageAsync("Informe uma posição válida. Ex: A1, A2...");
            }
            else
            {
                // Limpa comando jogador e ultimo tabuleiro enviado
                switch (posicao[0])
                {
                    case 'A':
                    case 'a':
                        localPosicao[0] = 0;
                        break;
                    case 'B':
                    case 'b':
                        localPosicao[0] = 1;
                        break;
                    case 'C':
                    case 'c':
                        localPosicao[0] = 2;
                        break;
                }
                localPosicao[1] = posicao[1] - '0' - 1;

                for (int idx = 0; idx < Campo.GetLength(0); idx++)
                {
                    for (int idx2 = 0; idx2 < Campo.GetLength(1); idx2++)
                    {
                        if(idx == localPosicao[1] && idx2 == localPosicao[0])
                        {
                            if(Campo[idx, idx2] == "          ")
                            {
                                Campo[idx, idx2] = VezDoJogadorX ? "  ❌  " : "  ⭕  ";
                                EstadoJogoDaVelha estadoJogo = VerificarEstadoJogo(ctx);

                                switch (estadoJogo)
                                {
                                    case EstadoJogoDaVelha.EmProgresso:
                                        EmProgresso(ctx);
                                    break;
                                    case EstadoJogoDaVelha.Vitoria:
                                        Vitoria(ctx);
                                        break;
                                    case EstadoJogoDaVelha.Empate:
                                        Empate(ctx);
                                        break;
                                }
                            }
                            else
                            {
                                await ctx.Channel.SendMessageAsync("Escolha um local vazio.");
                            }
                        }
                    };
                }
            }
        }
        public async void EmProgresso(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync(
                $"Vez do jogador  {(!VezDoJogadorX ? "❌" : "⭕")} !\n\n"
                + BancoLocal.JogoDaVelha.MostraCampo()
            );
            VezDoJogadorX = !VezDoJogadorX;
        }

        public async void Vitoria(CommandContext ctx)
        {
            IReadOnlyList<DiscordMessage> mensagens = await ctx.Channel.GetMessagesAsync();
            await ctx.Channel.SendMessageAsync(
                "----------------------\n"
                + $"O jogador  {(VezDoJogadorX ? "❌" : "⭕")}  venceu!\n\n"
                + BancoLocal.JogoDaVelha.MostraCampo()
            );

            BancoLocal.JogoDaVelha = new JogoDaVelha();

            await LimparRegistrosJogo(mensagens, ctx);
        }

        public async void Empate(CommandContext ctx)
        {
            IReadOnlyList<DiscordMessage> mensagens = await ctx.Channel.GetMessagesAsync();
            await ctx.Channel.SendMessageAsync(
                "----------------------\n"
                + "O jogo terminou em empate!\n\n"
                + BancoLocal.JogoDaVelha.MostraCampo()
            );

            BancoLocal.JogoDaVelha = new JogoDaVelha();

            await LimparRegistrosJogo(mensagens, ctx);
        }
    }
}
