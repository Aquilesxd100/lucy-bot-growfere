using bot_lucy_growfere.database.local;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace bot_lucy_growfere.commands
{
    public class Comandos : BaseCommandModule
    {
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

        [Command("info")]
        public async Task Info(CommandContext ctx)
        {
            var message = new DiscordEmbedBuilder()
                    .WithTitle($"Olá {ctx.User.Username}")
                    .WithDescription("Esses são meus comandos 😎")
                    .AddField("!info", "Mostra informações de outros comandos.")
                    .AddField("!clearMessages", "Limpa o canal de texto, podendo passar uma parte de texto da mensagem que deseja deletar.")
                    .AddField("!pr", "Mostra os Mandamentos do PR.")
                    .AddField("!feriados", "Mostra os feriados nacionais do ano, podendo passar uma prop 'prox' para retornar o feriado mais próximo.")
                    .AddField("!trocadilho", "Retorna um pequeno trocadilho engraçado.")
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

        [Command("clearMessages")]
        public async Task ClearMessages(
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
                    message.Content.Length > 0 && (
                        message.Content.Contains("https://prod.liveshare") ||
                        message.Content[0] == '!' ||
                        message.Content.Contains("Apaguei um total de ") ||
                        message.Content.Contains("Digite uma palavra de pelo menos 5 caractéres para ser deletada") ||
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
            await ctx.Channel.SendMessageAsync($"Apaguei um total de {qtdMensagensApagadas} mensagens! 😁");
        }

        [Command("feriados")]
        public async Task Feriados(CommandContext ctx, string proximoFeriado = "mensagem default")
        {
            bool feriadoProximo = false;

            if (proximoFeriado == "prox")
                feriadoProximo = true;

            string baseURL = $"https://brasilapi.com.br/api/feriados/v1/{DateTime.Now.Year}";
            try
            {
                var client = new HttpClient();
                var res = await client.GetAsync(baseURL);
                var content = res.Content;
                string data = await content.ReadAsStringAsync();

                var message = new DiscordEmbedBuilder()
                    .WithTitle(feriadoProximo ? "Esse será seu próximo Feriado Nacional 🤩" : "Esses são os Feriados Nacionais desse ano 🥳");

                var feriadoEhProximoAno = true;
                if (data != null)
                {
                    var jsonObject = JsonConvert.DeserializeObject<dynamic>(data);
                    if (jsonObject != null)
                    {
                        foreach (var item in jsonObject)
                        {
                            string dateAntiga = item["date"];
                            var dateArray = dateAntiga.Split('-');
                            string date = String.Join("/", dateArray.Reverse());

                            if (feriadoProximo)
                            {
                                if (DateTime.Now.CompareTo(DateTime.Parse(date)) <= 0)
                                {
                                    message.AddField($"{date}", $"{item["name"]}");
                                    feriadoEhProximoAno = false;
                                    break;
                                }
                            }
                            else
                                message.AddField($"{date}", $"{item["name"]}");
                        }
                    }
                }
                if (feriadoProximo && feriadoEhProximoAno)
                    message.AddField($"01/01/{DateTime.Now.Year + 1}", "Confraternização mundial");

                await ctx.Channel.SendMessageAsync(embed: message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        [Command("trocadilho")]
        public async Task Trocadilho(CommandContext ctx)
        {
            ITrocadilho trocadilho = Trocadilhos.getTrocadilho();
            await ctx.Channel.SendMessageAsync($"{trocadilho._pergunta}");
            await Task.Delay(3000);
            await ctx.Channel.SendMessageAsync($"{trocadilho._resposta}");
        }
    }
}
