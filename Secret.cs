using System;

namespace MCGalaxy 
{
	public class CmdSecret : Command2
	{
		
		public override string name { get { return "Secret"; } }
		public override string shortcut { get { return ""; } }
		public override bool MessageBlockRestricted { get { return false; } }
		public override string type { get { return "other"; } }
		public override bool museumUsable { get { return false; } }
		public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }
		public override void Use(Player p, string message, CommandData data)
		{
		p.Message("%3Just What Do You Think You Are Doing?");
		}
		public override void Help(Player p)
		{
			
		}
	}
}
