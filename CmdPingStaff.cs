// This Command Was Made By: Ninja_King. Helped by SpicyCombo
// Please Edit Lines 17, 18, 19, 20, 21, and 22
// Notice: You will Need to add the discrodbroadcast Cmd before being able to use this Command

using System;
using MCGalaxy;

namespace MCGalaxy.Commands.CPE {
    public sealed class CmdDiscordPing : Command2 {
        public override string name { get { return "PingStaff"; } }
        public override string shortcut { get { return "png"; } }
        public override string type { get { return "other"; } }

        public override void Use(Player p, string message)
        {
            string[] args = message.SplitSpaces(2);
            if (args[0] == "Ingame Username 1")
            { Command.Find("DiscordBroadcast").Use(p, "Discord User ID 1"); }
            else if (args[0] == "Ingame Username 2")
            { Command.Find("DiscordBroadcast").Use(p, "Discord User ID 2"); }
            else if (args[0] == "Ingame Username 3")
            { Command.Find("DiscordBroadcast").Use(p, "<Discord User ID 3"); }

        }
                
                    
    public override void Help(Player p)
        {
            p.Message("%T/Ping [Staff Member] <Message>");
            p.Message("%HPings [Staff Member] on Discord");
            p.Message("%4It's case sensitive! &4Use If Necessary");
        }
    }
}
