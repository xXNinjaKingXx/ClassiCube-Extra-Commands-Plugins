// █▀▀ █▀█ █▀▀ ▄▀█ ▀█▀ █▀█ █▀█ ▀
// █▄▄ █▀▄ ██▄ █▀█ ░█░ █▄█ █▀▄ ▄


// ███╗░░██╗██╗███╗░░██╗░░░░░██╗░█████╗║
// ████╗░██║██║████╗░██║░░░░░██║██╔══██║
// ██╔██╗██║██║██╔██╗██║░░░░░██║███████║
// ██║╚████║██║██║╚████║██╗░░██║██╔══██║
// ██║░╚███║██║██║░╚███║╚█████╔╝██║░░██║


using System;
using MCGalaxy;

namespace MCGalaxy.Commands.CPE {
    public sealed class CmdDiscordPing : Command2 {
        public override string name { get { return "Staff"; } }
        public override string shortcut { get { return ""; } }
        public override string type { get { return "other"; } }

        public override void Use(Player p, string message)
        {
            Command.Find("S3").Use(p, "");
            Command.Find("S2").Use(p, "");
            Command.Find("S1").Use(p, "");

        }
                
                    
    public override void Help(Player p)
        {
            p.Message("%TShows a list of current staff members.");

        }
    }
}
