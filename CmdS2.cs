//Notice: You will need to edit lines 31, 37, and 39. Replace all [Putranknamehere] to the rank you want it to show. E.g, [Putranknamehere] = Administrator.
//Notice: This will only one rank.
//Notice: You will need to create a file in the text folder named "[Putranknamehere].txt
//Notice: You will have to add the names of the players with [putranknamehere] to the new .txt file you have created.

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
    public sealed class CmAdmins : Command2
    {
        public override string name { get { return "S2"; } }
        public override string type { get { return "other"; } }
        public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }

        public override void Use(Player p, string message, CommandData data)
        {
            string path = @"./text/[Putranknamehere].txt";

            // Check to see if file exists
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path); // Grab lines of file
                string [Putranknamehere] = string.Join(", ", lines); // Use .Join(", ") so output looks like this: admin1, admin2, admin3

                p.Message(Putranknamehere); // Send to player
            }
        }

        public override void Help(Player p)
        {

        }
    }
}
