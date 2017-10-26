using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace NeubNeub.Modules
{
    public class Misc : ModuleBase<SocketCommandContext>
    {
        [Command("rules")]
        public async Task Rules()
        {
            await Context.Channel.SendMessageAsync("Don't be a dork");
        }
    }
}
