//This is an edited version of Compass.cs Made by Venk.
//I have no right say i made this as my own and so does anybody else.


using System;
using System.Threading;

using MCGalaxy;
using MCGalaxy.Tasks;

namespace MCGalaxy
{
    public class Compass : Plugin
    {
        public override string creator { get { return "Ninja_King"; } }
        public override string MCGalaxy_Version { get { return "1.9.1.2"; } }
        public override string name { get { return "Compass"; } }

        public static SchedulerTask task;

        public override void Load(bool startup)
        {
            task = Server.MainScheduler.QueueRepeat(CheckDirection, null, TimeSpan.FromMilliseconds(100));
        }

        void CheckDirection(SchedulerTask task)
        {
            Player[] players = PlayerInfo.Online.Items;
            foreach (Player p in players)
            {
                if (Orientation.PackedToDegrees(p.Rot.RotY) >= 0 && Orientation.PackedToDegrees(p.Rot.RotY) < 45)
                {
                    p.SendCpeMessage(CpeMessageType.Status1, "%SFacing: %bWest");
                    p.SendCpeMessage(CpeMessageType.Status2, "%b♦ &iEpic Legends Survival%b ♦");
                    p.SendCpeMessage(CpeMessageType.Status3, "%b There are currently %a$online%b players online.");;
                }

                if (Orientation.PackedToDegrees(p.Rot.RotY) >= 45 && Orientation.PackedToDegrees(p.Rot.RotY) < 90)
                {
                    p.SendCpeMessage(CpeMessageType.Status1, "%SFacing: %bNorth West");
                    p.SendCpeMessage(CpeMessageType.Status2, "%b♦ &iEpic Legends Survival%b ♦");
                    p.SendCpeMessage(CpeMessageType.Status3, "%b There are currently %a$online%b players online.");
                }

                if (Orientation.PackedToDegrees(p.Rot.RotY) >= 90 && Orientation.PackedToDegrees(p.Rot.RotY) < 135)
                {
                    p.SendCpeMessage(CpeMessageType.Status1, "%SFacing: %bNorth");
                    p.SendCpeMessage(CpeMessageType.Status2, "%b♦ &iEpic Legends Survival%b ♦");
                    p.SendCpeMessage(CpeMessageType.Status3, "%b There are currently %a$online%b players online.");
                }

                if (Orientation.PackedToDegrees(p.Rot.RotY) >= 135 && Orientation.PackedToDegrees(p.Rot.RotY) < 180)
                {
                    p.SendCpeMessage(CpeMessageType.Status1, "%SFacing: %bNorth East");
                    p.SendCpeMessage(CpeMessageType.Status2, "%b♦ &iEpic Legends Survival%b ♦");
                    p.SendCpeMessage(CpeMessageType.Status3, "%b There are currently %a$online%b players online.");
                }

                if (Orientation.PackedToDegrees(p.Rot.RotY) >= 180 && Orientation.PackedToDegrees(p.Rot.RotY) < 225)
                {
                    p.SendCpeMessage(CpeMessageType.Status1, "%SFacing: %bEast");
                    p.SendCpeMessage(CpeMessageType.Status2, "%b♦ &iEpic Legends Survival%b ♦");
                    p.SendCpeMessage(CpeMessageType.Status3, "%b There are currently %a$online%b players online.");
                }

                if (Orientation.PackedToDegrees(p.Rot.RotY) >= 225 && Orientation.PackedToDegrees(p.Rot.RotY) < 270)
                {
                    p.SendCpeMessage(CpeMessageType.Status1, "%SFacing: %bSouth East");
                    p.SendCpeMessage(CpeMessageType.Status2, "%b♦ &iEpic Legends Survival%b ♦");
                    p.SendCpeMessage(CpeMessageType.Status3, "%b There are currently %a$online%b players online.");
                }

                if (Orientation.PackedToDegrees(p.Rot.RotY) >= 270 && Orientation.PackedToDegrees(p.Rot.RotY) < 315)
                {
                    p.SendCpeMessage(CpeMessageType.Status1, "%SFacing: %bSouth");
                    p.SendCpeMessage(CpeMessageType.Status2, "%b♦ &iEpic Legends Survival%b ♦");
                    p.SendCpeMessage(CpeMessageType.Status3, "%b There are currently %a$online%b players online.");
                }

                if (Orientation.PackedToDegrees(p.Rot.RotY) >= 315 && Orientation.PackedToDegrees(p.Rot.RotY) < 361)
                {
                    p.SendCpeMessage(CpeMessageType.Status1, "%SFacing: %bSouth West");
                    p.SendCpeMessage(CpeMessageType.Status2, "%b♦ &iEpic Legends Survival%b ♦");
                    p.SendCpeMessage(CpeMessageType.Status3, "%b There are currently %a$online%b players online.");
                }
            }
        }

        public override void Unload(bool shutdown)
        {
            Server.MainScheduler.Cancel(task);
        }
    }
}
