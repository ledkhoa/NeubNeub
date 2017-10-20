using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace NeubNeub
{
    public class NeubNeub
    {
        DiscordSocketClient _client;
        readonly string TOKEN = "MzcwNzI4NzEzMTQ4NDMyMzg0.DMrTpA.BPcHkYou4ISWJkQie-81uODo3xc";
        CommandHandler _handler;

        public async Task Start()
        {
            _client = new DiscordSocketClient();
            _handler = new CommandHandler(_client);
            await _client.LoginAsync(TokenType.Bot, TOKEN);
            await _client.StartAsync();

            await Task.Delay(-1);
        }
    }
}
