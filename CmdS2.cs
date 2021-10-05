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
        public override string name { get { return "S2"; } }
        public override string type { get { return "other"; } }
        public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }

        public override void Use(Player p, string message, CommandData data)
        {
            string path = @"./text/Administrators.txt";

            // Check to see if file exists
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path); // Grab lines of file
                string administrators = string.Join(", ", lines); // Use .Join(", ") so output looks like this: admin1, admin2, admin3

                p.Message(administrators); // Send to player
            }
        }

        public override void Help(Player p)
        {

        }
    }
}