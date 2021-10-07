//This is a simple vertion of /Staff i think this is way better then my other creation but ill still keep that public for the time being.
//Notice: you can edit this only to replace the rank names 
//if there are issues feel free to report an issue here: https://github.com/xXNinjaKingXx/ClassiCube-Extra-Commands-Plugins/issues

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
        public override string MCGalaxy_Version { get { return "1.9.3.0"; } }
        public override string name { get { return "Staff"; } }

        public override void Load(bool startup) {
            Command.Register(new CmdS1());
            Command.Register(new CmdS2());
            Command.Register(new CmdS3());
        }
        
        public override void Unload(bool shutdown) {
        	Command.Unregister(Command.Find("S1"));
            Command.Unregister(Command.Find("S2"));
            Command.Unregister(Command.Find("S3"));
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
