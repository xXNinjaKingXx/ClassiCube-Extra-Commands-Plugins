//reference MCGalaxy_.dll
//reference System.dll

/*
Staff - Staff command to print out the staff ranks and members on the server above a threshold permission level.
@author Panda
*/
using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

using MCGalaxy;
using MCGalaxy.Commands;
using MCGalaxy.Commands.Chatting;

namespace MCGalaxy {

    public class StaffPlugin : Plugin {
        public override string creator { get { return "Panda"; } }
        public override string MCGalaxy_Version { get { return "1.9.1.2"; } }
        public override string name { get { return "Staff"; } }

        public override void Load(bool startup) {
            Command.Register(new CmdStaff());
        }

        public override void Unload(bool shutdown) {
            Command.Unregister(Command.Find("Staff"));
        }
    }

    public sealed class CmdStaff : Command {
        public override string name { get { return "Staff"; } }
        public override string type { get { return "info"; } }
        public override bool museumUsable { get { return true; } }
        public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }

        public override void Use(Player p, string message) {
            LevelPermission minRankPermission = LevelPermission.AdvBuilder;
			List<Group> ranks = Group.GroupList;
			List<string> output = new List<string>();
			foreach (Group rank in ranks)
			{
				// If the rank permission is >= min, add it to the list.
				if (rank.Permission.CompareTo(minRankPermission) >= 0)
				{
					List<string> users = rank.Players.All();
					StringBuilder formatUsers = new StringBuilder();
					users.ForEach(s => formatUsers.Append(s + ", "));
					string rankOutput = $"{rank.ColoredName}%S: {formatUsers}";
					output.Add(rankOutput);
				}
			}

            // Reverse print the list for structure.
			for (int idx = output.Count-1; idx > 0; idx--)
				p.Message(output[idx].ToString());
        }

        public override void Help(Player p)
		{
			p.Message("/Staff - Print a list of all staff ranks on the server.");
		}
    }
}
