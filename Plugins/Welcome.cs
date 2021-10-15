// █▀▀ █▀█ █▀▀ ▄▀█ ▀█▀ █▀█ █▀█ ▀
// █▄▄ █▀▄ ██▄ █▀█ ░█░ █▄█ █▀▄ ▄


// ███╗░░██╗██╗███╗░░██╗░░░░░██╗░█████╗║
// ████╗░██║██║████╗░██║░░░░░██║██╔══██║
// ██╔██╗██║██║██╔██╗██║░░░░░██║███████║
// ██║╚████║██║██║╚████║██╗░░██║██╔══██║
// ██║░╚███║██║██║░╚███║╚█████╔╝██║░░██║

using System;
using System.Threading;

using MCGalaxy;
using MCGalaxy.Tasks;
using MCGalaxy.Events;
using MCGalaxy.Events.PlayerEvents;

namespace McGalaxy {
    public class Welcome : Plugin {  
        public override string creator { get { return "Nin"; } }
        public override string MCGalaxy_Version { get { return "1.9.3.0"; } }
        public override string name { get { return "Welcome"; } }

        public override void Load(bool startup) {
            // Register events using handlers. OnPlayerConnectEvent -> HandlePlayerConnect for example
            // Every event needs a handler, you can name it whatever you like but ideally Handle[event name here] is best.
            OnPlayerConnectEvent.Register(HandlePlayerConnect, Priority.High);
        }
        
        public override void Unload(bool shutdown) {
            // Unregister event(s)
        }
    
        // Player connect event handler
        void HandlePlayerConnect(Player p) {
            // Better to not use a command for this
            p.SendCpeMessage(CpeMessageType.BigAnnouncement, "%b♦ %iWelcome to $server $skin %b♦");
            p.SendCpeMessage(CpeMessageType.SmallAnnouncement, "%bType in chat %a/faq %band %a/rules %bto get started");
        }

         public override void Help(Player p) {
            p.Message("%TAnnounces Welcome Message When Player Joins.");
        }
    }
}
