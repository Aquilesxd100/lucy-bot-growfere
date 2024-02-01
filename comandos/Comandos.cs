using bot_lucy_growfere.comandos;
using bot_lucy_growfere.controladores;
using bot_lucy_growfere.database.local;
using bot_lucy_growfere.modelos.api;
using bot_lucy_growfere.modelos.jogos;
using bot_lucy_growfere.requisicoes;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.Lavalink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_lucy_growfere.commands
{
    public class Comandos : BaseCommandModule
    {
        public static DiscordClient Client { get; set; }
        [Command("ping")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("pong");
        }

        [Command("soma")]
        public async Task Soma(CommandContext ctx, int n1, int n2)
        {
            int result = n1 + n2;
            await ctx.Channel.SendMessageAsync($"{result}");
        }

        [Command("tempoRefere")]
        public async Task TempoRefere(CommandContext ctx)
        {
            string msgTempoTrabalhado = "";
            TimeSpan tempoTotalTrabalhado = DateTime.Now.Subtract(BancoLocal.dataInicioEmpregoRefere);

            int mesesTrabalhados = (int)(tempoTotalTrabalhado.TotalDays / 30);
            if (mesesTrabalhados > 0) msgTempoTrabalhado += $" {mesesTrabalhados} meses";

            tempoTotalTrabalhado = tempoTotalTrabalhado.Subtract(TimeSpan.FromDays(mesesTrabalhados * 30));

            int diasTrabalhados = (int)(tempoTotalTrabalhado.TotalDays);
            if (diasTrabalhados > 0)
            {
                msgTempoTrabalhado += mesesTrabalhados > 0
                    ? $" e {diasTrabalhados} dias"
                    : $" {diasTrabalhados} dias";
            }

            await ctx.Channel.SendMessageAsync($"Fernando e Lucas já trabalharam{msgTempoTrabalhado} na Refere.");
        }

        [Command("info")]
        public async Task Info(CommandContext ctx)
        {
            var message = new DiscordEmbedBuilder()
                    .WithTitle($"Olá {ctx.User.Username}")
                    .WithDescription("Esses são meus comandos 😎")
                    .AddField("!info", "Mostra informações de outros comandos.")
                    .AddField("!limparMensagens", "Limpa o canal de texto, podendo passar uma parte de texto da mensagem que deseja deletar.")
                    .AddField("!pr", "Mostra os Mandamentos do PR.")
                    .AddField("!feriados", "Mostra os feriados nacionais do ano, podendo passar uma prop 'prox' para retornar o feriado mais próximo.")
                    .AddField("!trocadilho", "Retorna um pequeno trocadilho engraçado.")
                    .AddField("!tocar", "Insira esse comando com o nome da musica que deseja tocar. (obs: se o nome tiver mais de uma palavra use _ para separa-lo)")
                    .AddField("!parar", "Usado para parar o tocar.")
                    .AddField("!tempoRefere", "Mostra quanto tempo o pessoal esta trabalhando na Refere.")
                    .AddField("!iniciarJogoVelha", "Começa um novo Jogo da Velha.")
                    .AddField("!jogar 'A1'", "Faz uma jogada no Jogo da Velha no local passado.")
                    .AddField("!pararJogoVelha", "Para imediatamente o Jogo da Velha.")
                    .AddField("!iniciarJogoAdivinhacao '0' '100'", "Começa um novo jogo de adivinhação começando no primeiro número e terminando no segundo.")
                    .AddField("!adivinhar '13'", "Tenta adivinhar o número sortiado no jogo de adivinhaçao.")
                    .AddField("!pararJogoAdivinhacao", "Para imediatamente o jogo de adivinhação.")
                    .WithColor(new DiscordColor(143, 0, 255));

            await ctx.Channel.SendMessageAsync(embed: message);
        }

        [Command("pr")]
        public async Task Pr(CommandContext ctx)
        {
            var message = new DiscordEmbedBuilder()
                .WithTitle($"Olá {ctx.User.Username}")
                .WithTitle("Aqui estão os Mandamentos do PR 😁")
                .AddField("1:", "Remover console.logs.")
                .AddField("2:", "Verificar nomes de variaveis e funções, torna-las auto-explicativas de preferencia em portugues.")
                .AddField("3:", "trocar nomes de variaveis de MAP e outros metodos do tipo para algo auto-explicativo.")
                .AddField("4:", "Verificar valores do Payload, se tipo e valores estão adequados (YUP safado), lembrar de utilizar funções de formatos diretamente no fetch.")
                .AddField("5:", "Deixar tela responsiva até o minimo de 360p de largura.")
                .AddField("6:", "Indentar o codigo para facil entendimento (If....).")
                .AddField("7:", "Priorizar clareza ao invez de compactibilidade, usando mais espaço porem tornando fácil o entendimento.")
                .AddField("8:", "Deixar Imports organizados de acordo com o padrão da imagem.")
                .AddField("9:", "Excluir virgulas e pontos&virgulas de interfaces caso houver.")
                .AddField("10:", "Remover codigo comentado que for possivel remover.")
                .AddField("11:", "Efetuar um merge com a main em sua versão mais recente.")
                .AddField("12:", "Verificar se há algo que não tem necessidade de estar dentro do componente, colocar fora.")
                .AddField("13:", "Conferir antes de efetuar a PR se há alguma modificação desnecessária (ex:   ,   ;   espaço   tab).")
                .AddField("14:", "Acessar pelo http://desenvolvimento.sigas.com.br/ e criar uma nova simulacao para testar, TESTAR SOMENTE COM SIMULAÇÕES NOVAS.")
                .AddField("15:", "Seguir avisando de TODA E QUALQUER mudança na estrutura, seja qual for.")
                .AddField("16:", "Nome de PR deve explicar o que foi desenvolvido na Task, se necessário usar a descrição para falar em detalhes tudo que foi desenvolvido.")
                .AddField("17:", "Rodar projeto e verificar o console por warnings ou erros.")
                .WithColor(new DiscordColor(245, 64, 64));

            await ctx.Channel.SendMessageAsync(embed: message);
        }

        [Command("limparMensagens")]
        public async Task LimparMensagens(
            CommandContext ctx,
            string mensagemADeletar = "mensagem default para deletar"
        )
        {
            var permissoesUsuario = ctx.Channel.PermissionsFor(ctx.Member);
            if (permissoesUsuario != DSharpPlus.Permissions.All)
            {
                await ctx.Channel.SendMessageAsync($"Somente administradores podem user este comando para deletar mensagens específicas! 🙂");
                return;
            }

            if (mensagemADeletar.Length < 4)
            {
                await ctx.Channel.SendMessageAsync($"Digite uma palavra de pelo menos 4 caractéres para ser deletada! 😬");
                return;
            }

            var mensagens = await ctx.Channel.GetMessagesAsync();
            int qtdMensagensApagadas = 0;

            foreach (var message in mensagens)
            {
                if (
                    message.Embeds.Count > 0 ||
                    message.Content.Length > 0 && (
                        message.Content.Contains("https://prod.liveshare") ||
                        message.Content[0] == '!' ||
                        message.Author.IsBot ||
                        (
                            mensagemADeletar.Length >= 4 &&
                            message.Content.Contains(mensagemADeletar)
                        )
                    )
                )
                {
                    qtdMensagensApagadas++;
                    await ctx.Channel.DeleteMessageAsync(message);
                }
            }
            string nivelCansacoLucy = "😁";
            if (qtdMensagensApagadas > 8) nivelCansacoLucy = "🥲";
            if (qtdMensagensApagadas > 18) nivelCansacoLucy = "🥴";
            if (qtdMensagensApagadas > 30) nivelCansacoLucy = "😵";
            await ctx.Channel.SendMessageAsync($"Apaguei um total de {qtdMensagensApagadas} mensagens! {nivelCansacoLucy}");
        }

        [Command("feriados")]
        public async Task Feriados(CommandContext ctx, string proximoFeriado = "mensagem default")
        {
            bool feriadoProximo = false;

            if (proximoFeriado == "prox")
                feriadoProximo = true;

            int anoAtual = DateTime.Now.Year;
            BrasilAPIFeriadoPorAno[] feriados = await BrasilAPI.ListarFeriadosDeUmAno(anoAtual);

            if (feriados == null)
                return;

            var message = new DiscordEmbedBuilder()
                .WithTitle(feriadoProximo ? "Esse será seu próximo Feriado Nacional 🤩" : "Esses são os Feriados Nacionais desse ano 🥳");

            var feriadoEhProximoAno = true;
            foreach (BrasilAPIFeriadoPorAno feriado in feriados)
            {
                string dateAntiga = feriado.date;
                var dateArray = dateAntiga.Split('-');
                string date = String.Join("/", dateArray.Reverse());

                if (feriadoProximo)
                {
                    if (DateTime.Now.CompareTo(DateTime.Parse(date)) <= 0)
                    {
                        message.AddField($"{date}", feriado.name);
                        feriadoEhProximoAno = false;
                        break;
                    }
                }
                else
                {
                    message.AddField($"{date}", feriado.name);
                }
            }
            if (feriadoProximo && feriadoEhProximoAno) 
                message.AddField($"01/01/{DateTime.Now.Year + 1}", "Confraternização mundial");

            await ctx.Channel.SendMessageAsync(embed: message);
        }

        [Command("trocadilho")]
        public async Task Trocadilho(CommandContext ctx)
        {
            ITrocadilho trocadilho = Trocadilhos.getTrocadilho();
            await ctx.Channel.SendMessageAsync($"{trocadilho._pergunta}");
            await Task.Delay(3000);
            await ctx.Channel.SendMessageAsync($"{trocadilho._resposta}");
        }

        [Command("tocar")]
        public async Task Tocar(CommandContext ctx, string musica)
        {
            if (musica.Length <= 3)
            {
                return;
            }

            musica = musica.Replace('_', ' ');

            LavalinkExtension lavaLink = Program.Client.GetLavalink();

            if (!lavaLink.ConnectedNodes.Any())
            {
                return;
            }

            DiscordChannel canalDeVoz = ctx.Channel;
            var nodeLavaLink = lavaLink.ConnectedNodes.Values.First();
            await nodeLavaLink.ConnectAsync(canalDeVoz);
            var conexao = nodeLavaLink.GetGuildConnection(ctx.Guild);
            ControladorChamadaVoz.conexaoVoz = conexao;

            if (conexao == null)
            {
                return;
            }

            LavalinkLoadResult resultadoPesquisa = await nodeLavaLink.Rest.GetTracksAsync(musica);

            if (
                resultadoPesquisa.LoadResultType == LavalinkLoadResultType.NoMatches
                || resultadoPesquisa.LoadResultType == LavalinkLoadResultType.LoadFailed
            )
            {
                return;
            }

            var audio = resultadoPesquisa.Tracks.First();
            conexao.PlaybackFinished += ComandosVoz.SairChamadaAposTocarAudioAsync;
            await conexao.PlayAsync(audio);
        }

        //[Command("parar")]
        //public async Task Parar()
        //{
        //   Console.WriteLine("entrou");
        //   ControladorChamadaVoz.conexaoVoz.DisconnectAsync();
        //}

        [Command("iniciarJogoVelha")]
        public async Task IniciarJogoVelha(CommandContext ctx)
        {
            if (BancoLocal.JogoDaVelha.JogoIniciado)
            {
                await ctx.Channel.SendMessageAsync("Um jogo da velha já está em progresso.");
                return;
            }

            BancoLocal.JogoDaVelha.JogoIniciado = true;
            await ctx.Channel.SendMessageAsync(
                "Novo jogo iniciado.\nJogador  ❌  começa!\n\n"
                + BancoLocal.JogoDaVelha.MostraCampo()
            );
        }

        [Command("pararJogoVelha")]
        public async Task PararJogoVelha(CommandContext ctx)
        {
            if (!BancoLocal.JogoDaVelha.JogoIniciado)
            {
                await ctx.Channel.SendMessageAsync("Nenhum jogo está em progresso atualmente.");
                return;
            }

            IReadOnlyList<DiscordMessage> mensagens = await ctx.Channel.GetMessagesAsync();

            BancoLocal.JogoDaVelha = new JogoDaVelha();
            await ctx.Channel.SendMessageAsync("O jogo da velha foi cancelado.");

            await BancoLocal.JogoDaVelha.LimparRegistrosJogo(mensagens, ctx);
        }

        [Command("jogar")]
        public async Task JogarJogoVelha(CommandContext ctx, string posicao)
        {
            if (!BancoLocal.JogoDaVelha.JogoIniciado)
            {
                await ctx.Channel.SendMessageAsync("Nenhum jogo está em progresso atualmente.");
                return;
            }

            await BancoLocal.JogoDaVelha.Jogar(ctx, posicao);
        }

        [Command("iniciarJogoAdivinhacao")]
        public async Task IniciarJogoAdivinhacao(CommandContext ctx, int min, int max)
        {
            if (BancoLocal.JogoAdivinhacao.JogoIniciado)
            {
                await ctx.Channel.SendMessageAsync("Um jogo de adivinhação já está em progresso.");
                return;
            }

            if (min > max || min < 0 || max < 0)
            {
                await ctx.Channel.SendMessageAsync("O número inicial não pode ser maior que o final e ambos precisam ser positivos. Ex: !iniciarJogoAdivinhacao 1 10");
                return;
            }

            BancoLocal.JogoAdivinhacao = new Adivinhacao(min, max, true);
            await ctx.Channel.SendMessageAsync("Jogo de adivinhação iniciado.");
        }

        [Command("pararJogoAdivinhacao")]
        public async Task PararJogoAdivinhacao(CommandContext ctx)
        {
            if (!BancoLocal.JogoAdivinhacao.JogoIniciado)
            {
                await ctx.Channel.SendMessageAsync("Nenhum jogo está em progresso atualmente.");
                return;
            }

            IReadOnlyList<DiscordMessage> mensagens = await ctx.Channel.GetMessagesAsync();

            BancoLocal.JogoAdivinhacao.JogoIniciado = false;
            await ctx.Channel.SendMessageAsync("O jogo da adivinhação foi cancelado.");

            await BancoLocal.JogoAdivinhacao.LimparRegistrosJogo(mensagens, ctx);
        }

        [Command("adivinhar")]
        public async Task Adivinhar(CommandContext ctx, int numeroAdivinhado)
        {
            if (!BancoLocal.JogoAdivinhacao.JogoIniciado)
            {
                await ctx.Channel.SendMessageAsync("Nenhum jogo de adivinhação está em progresso atualmente.");
                return;
            }

            await BancoLocal.JogoAdivinhacao.Adivinhar(ctx, numeroAdivinhado);
        }

        [Command("testeTraducao")]
        public async Task TesteTraducao(CommandContext ctx, string textoIngles)
        {
            string textoProcessado = textoIngles.Replace('_', ' ');

            string textoTraduzido = await MyMemoryAPI.TraduzirENparaPTBR(textoProcessado);
            if (textoTraduzido != null)
            {
                await ctx.Channel.SendMessageAsync($"Tradução de {textoIngles}: {textoTraduzido}");
            } else
            {
                await ctx.Channel.SendMessageAsync("Não encontrei nenhuma tradução.");
            }
        }
    }
}
