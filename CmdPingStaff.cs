// This Command Was Made By: Ninja_King
// Please Edit Lines 20,21,22 
// Notice: You will Need to add the discrodbroadcast Cmd before being able to use this Command

using System;

namespace MCGalaxy 
{
	public class CmdPingStaff : Command2
	{
		
		public override string name { get { return "PingStaff"; } }
		public override string shortcut { get { return "png"; } }
		public override bool MessageBlockRestricted { get { return false; } }
		public override string type { get { return "other"; } }
		public override bool museumUsable { get { return false; } }
		public override LevelPermission defaultRank { get { return LevelPermission.Operator; } }
		public override void Use(Player p, string message, CommandData data)
		{
        	// Configure Ping Names below.
            Command.Find("discordbroadcast").Use(p, "<Discord Id here");
            Command.Find("discordbroadcast").Use(p, "<Discord Id here>");
            Command.Find("discordbroadcast").Use(p, "<Discord Id here>");
		}
		public override void Help(Player p)
		{
			p.Message("/PingStaff");
            p.Message("%HPings Staff Members Ranked Administrator+");
		}
	}
}
