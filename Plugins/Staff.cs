//This is a simple vertion of /Staff i think this is way better then my other creation but ill still keep that public for the time being.

// █▀▀ █▀█ █▀▀ ▄▀█ ▀█▀ █▀█ █▀█ ▀
// █▄▄ █▀▄ ██▄ █▀█ ░█░ █▄█ █▀▄ ▄


// ███╗░░██╗██╗███╗░░██╗░░░░░██╗░█████╗║
// ████╗░██║██║████╗░██║░░░░░██║██╔══██║
// ██╔██╗██║██║██╔██╗██║░░░░░██║███████║
// ██║╚████║██║██║╚████║██╗░░██║██╔══██║
// ██║░╚███║██║██║░╚███║╚█████╔╝██║░░██║


using System;
using MCGalaxy;
using System.IO;

namespace McGalaxy {
    public class Staff : Plugin {  
        public override string creator { get { return "Ninja_King"; } }
        public override string MCGalaxy_Version { get { return "1.9.3.4"; } }
        public override string name { get { return "Staff"; } }

        public override void Load(bool startup) {
            Command.Register(new CmdSomething());
        }
        
        public override void Unload(bool shutdown) {
        	Command.Unregister(Command.Find("Something"));
        }
    }
    
    public class CmdS1 : Command2 {
        public override string name { get { return "S1"; } }
        public override string type { get { return "other"; } }
        public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }
        
        public override void Use(Player p, string message, CommandData data)
            {
            string path = @"./text/Moderators.txt";
        }
        if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path); 
                string moderators = string.Join(", ", lines); 

                p.Message(moderators); 
            }
        }
       
       public class CmdS2 : Command2 {
        public override string name { get { return "S2"; } }
        public override string type { get { return "other"; } }
        public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }
        
        public override void Use(Player p, string message, CommandData data)
            {
            string path = @"./text/Administrators.txt";
        }
        if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path); 
                string administrators = string.Join(", ", lines); 

                p.Message(administrators); 
            }
        }
        
        public class CmdS3 : Command2 {
        public override string name { get { return "S3"; } }
        public override string type { get { return "other"; } }
        public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }
        
        public override void Use(Player p, string message, CommandData data)
            {
            string path = @"./text/Leaders.txt";
        }
        if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path); 
                string leaders = string.Join(", ", lines); 

                p.Message(leaders); 
            }
        }

        
        }
    }
}
