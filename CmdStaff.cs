using System;

namespace MCGalaxy 
{
	public class CmdStaff : Command2
	{
		
		public override string name { get { return "Staff"; } }
		public override string shortcut { get { return ""; } }
		public override bool MessageBlockRestricted { get { return false; } }
		public override string type { get { return "other"; } }
		public override bool museumUsable { get { return false; } }
		public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }
		public override void Use(Player p, string message, CommandData data)
		{
    p.Message("[(rankcolor)rankname]: %7[Player(s) With Given Rank]");
    p.Message("[(rankcolor)rankname]: %7[Player(s) With Given Rank]");
    p.Message("[(rankcolor)rankname]: %7[Player(s) With Given Rank]");
		}
		public override void Help(Player p)
		{
		p.Message("%lShows Current Staff Members.");
		}
	}
}
