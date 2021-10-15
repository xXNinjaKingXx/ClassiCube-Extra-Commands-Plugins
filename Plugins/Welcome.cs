using System;
using System.Threading;

using MCGalaxy;
using MCGalaxy.Tasks;

namespace Core {
    public class Welcome : Plugin {  
        public override string creator { get { return "Nin"; } }
        public override string MCGalaxy_Version { get { return "1.9.3.0"; } }
        public override string name { get { return "Welcome"; } }
        
public override void Load(bool startup) {
            Command.Register(new CmdSomething());
        }
        
        public override void Unload(bool shutdown) {
        	Command.Unregister(Command.Find("Something"));
        }
    }
    
    public class CmdSomething : Command2 {
        public override string name { get { return "Welcome"; } }
        public override string type { get { return "Other"; } }
        public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }
        
        public override void Use(Player p, string message) {
            p.SendCpeMessage(CpeMessageType.Announcement, "%bType in chat %a/faq %band %a/rules %bto get started");
            p.SendCpeMessage(CpeMessageType.BigAnnouncement, "%b♦ %iWelcome to $server $skin %b♦");
        }

        public override void Help(Player p) {
        }
    }
}
