using System;
using System.Threading;

using MCGalaxy;
using MCGalaxy.Tasks;

namespace Core {
    public class Welcome : Plugin {  
        public override string creator { get { return "Nin"; } }
        public override string MCGalaxy_Version { get { return "1.9.3.0"; } }
        public override string name { get { return "Welcome"; } }

    protected override void HookEventHandlers() {
        	OnPlayerConnectEvent.Register(HandlePlayerConnect, Priority.High);
            OnJoinedLevelEvent.Register(HandleJoinedLevel, Priority.High);
        	base.HookEventHandlers();
        }

    protected override void HookEventHandlers() {
        	OnPlayerConnectEvent.Unregister(HandlePlayerConnect, Priority.High);
            OnJoinedLevelEvent.Unregister(HandleJoinedLevel, Priority.High);
        	base.UnhookEventHandlers();
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
