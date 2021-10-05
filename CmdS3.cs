// █▀▀ █▀█ █▀▀ ▄▀█ ▀█▀ █▀█ █▀█ ▀
// █▄▄ █▀▄ ██▄ █▀█ ░█░ █▄█ █▀▄ ▄


// ███╗░░██╗██╗███╗░░██╗░░░░░██╗░█████╗║
// ████╗░██║██║████╗░██║░░░░░██║██╔══██║
// ██╔██╗██║██║██╔██╗██║░░░░░██║███████║
// ██║╚████║██║██║╚████║██╗░░██║██╔══██║
// ██║░╚███║██║██║░╚███║╚█████╔╝██║░░██║

using System;
using System.IO; // Allows us to use File

using MCGalaxy;

namespace MCGalaxy
{
    public sealed class CmdAdmins : Command2
    {
        public override string name { get { return "S1"; } }
        public override string type { get { return "other"; } }
        public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }

        public override void Use(Player p, string message, CommandData data)
        {
            string path = @"./text/Moderators.txt";

            // Check to see if file exists
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path); // Grab lines of file
                string moderators = string.Join(", ", lines); // Use .Join(", ") so output looks like this: admin1, admin2, admin3

                p.Message(moderators); // Send to player
            }
        }

        public override void Help(Player p)
        {

        }
    }
}
