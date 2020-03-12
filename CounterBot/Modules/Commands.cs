using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace CounterBot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("nazi")]
        public async Task Rip()
        {
            await ReplyAsync("Das kommt auf den Counter");
        }

    }
}
