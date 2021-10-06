//Notice: You Will Need To Edit Line 17.\\
// █▀▀ █▀█ █▀▀ ▄▀█ ▀█▀ █▀█ █▀█ ▀
// █▄▄ █▀▄ ██▄ █▀█ ░█░ █▄█ █▀▄ ▄


// ███╗░░██╗██╗███╗░░██╗░░░░░██╗░█████╗║
// ████╗░██║██║████╗░██║░░░░░██║██╔══██║
// ██╔██╗██║██║██╔██╗██║░░░░░██║███████║
// ██║╚████║██║██║╚████║██╗░░██║██╔══██║
// ██║░╚███║██║██║░╚███║╚█████╔╝██║░░██║

using System;

namespace MCGalaxy 
{
	public class CmdDiscord : Command2
	{
		
		public override string name { get { return "Discord"; } }
		public override string shortcut { get { return ""; } }
		public override string type { get { return "other"; } }
		public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }
		public override void Use(Player p, string message, CommandData data)
		{
		p.Message("%lHere is the link to the Discord Server:");
    		p.Message("Put discord invite link here");
		}
		public override void Help(Player p)
		{
		p.Message("&SShows the link to discord server.");
		}
	}
}
