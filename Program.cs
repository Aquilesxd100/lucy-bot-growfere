﻿using bot_lucy_growfere.commands;
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

            var commandsConfig = new CommandsNextConfiguration()
            {
                StringPrefixes = new string[] { "!" },
                EnableMentionPrefix = true,
                EnableDms = true,
                EnableDefaultHelp = false,
            };

            Commands = Client.UseCommandsNext(commandsConfig);

            Commands.RegisterCommands<Commands>();

            var endPointLavaLink = new ConnectionEndpoint
            {
                Hostname = "lavalink.lexnet.cc",
                Port = 443,
                Secure = true
            };

            var lavaLinkConfig = new LavalinkConfiguration
            {
                Password = "lexn3tl@val!nk"
            };

            await Client.ConnectAsync();
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
