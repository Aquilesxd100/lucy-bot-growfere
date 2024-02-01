using bot_lucy_growfere.commands;
using bot_lucy_growfere.controladores;
using bot_lucy_growfere.Secrets;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.Lavalink;
using DSharpPlus.Net;
using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace bot_lucy_growfere
{
    internal class Program
    {
        public static DiscordClient Client { get; set; }

        public static HttpClient HTTPclient = new HttpClient();
        public static CommandsNextExtension Commands { get; set; }

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

            Commands.RegisterCommands<Comandos>();

            Client.VoiceStateUpdated += ControladorChamadaVoz.DeteccaoMudancaEstadoVoz;

            var endPointLavaLink = new ConnectionEndpoint
            {
                Hostname = "lavalink.teramont.net", 
                Port = 443,
                Secured = true
            };

            var lavaLinkConfig = new LavalinkConfiguration
            {
                Password = "eHKuFcz67k4lBS64",
                RestEndpoint = endPointLavaLink,
                SocketEndpoint = endPointLavaLink
            };

            var lavaLink = Client.UseLavalink();

            await Client.ConnectAsync();
            await lavaLink.ConnectAsync(lavaLinkConfig);
            Console.WriteLine("_Lucy: Oii, estou pronta mais uma vez!");
            await Task.Delay(-1);
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
