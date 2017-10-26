using System.Threading.Tasks;
using Discord.WebSocket;
using Discord.Commands;
using System.Reflection;

namespace NeubNeub
{
    public class CommandHandler
    {
        private DiscordSocketClient _client;
        private CommandService _service;

        public CommandHandler(DiscordSocketClient client)
        {
            _client = client;

            _service = new CommandService();

            _service.AddModulesAsync(Assembly.GetEntryAssembly());

            _client.MessageReceived += HandleCommandAsync;
        }

        private async Task HandleCommandAsync(SocketMessage s)
        {
            var msg = s as SocketUserMessage;

            if (msg != null)
            {
                var context = new SocketCommandContext(_client, msg);

                int argPos = 0;

                if (msg.HasCharPrefix('!', ref argPos))
                {
                    var result = await _service.ExecuteAsync(context, argPos);

                    if (!result.IsSuccess)
                    {
                        await context.Channel.SendMessageAsync("waduhek");
                    }
                }
            }
        }
    }
}
