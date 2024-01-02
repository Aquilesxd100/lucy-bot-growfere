using bot_lucy_growfere.Secrets;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using System;
using System.Collections.Generic;
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
            SecretsReader secrets = new SecretsReader();
            await secrets.GetSecrets();

            DiscordConfiguration discordConfig = new DiscordConfiguration()
            {
                Intents = DiscordIntents.All,
                Token = secrets.botToken,
                TokenType = TokenType.Bot,
                AutoReconnect = true
            };

            Client = new DiscordClient(discordConfig);

            Client.Ready += Client_Ready;

            await Client.ConnectAsync();
            await Task.Delay(-1);
        }
        private static Task Client_Ready(
            DiscordClient sender,
            DSharpPlus.EventArgs.ReadyEventArgs args
        ) {
            return Task.CompletedTask;
        }
    }
}
