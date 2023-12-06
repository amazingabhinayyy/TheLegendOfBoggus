using System;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Portal;


namespace Sprint2_Attempt3.Collision
{
    public class PlayerPortalHandler
    {
        private static TimeSpan timeBuffer;
        private static DateTime lastTeleportTime { get; set; }
        public static void HandlePlayerPortalCollision(ILink link, IGameObject portal, Game1 game)
        {
            timeBuffer = DateTime.Now - lastTeleportTime;
            TimeSpan coolDown = TimeSpan.FromSeconds(1);
            if (timeBuffer >= coolDown)
            {
                if (portal is FirstPortal)
                {
                    if (game.room is Room2)
                    {
                        link.Position = new Vector2(200, 535);
                    }
                    else if (game.room is Room10)
                    {
                        link.Position = new Vector2(550, 575);
                    }
                }
                else if (portal is SecondPortal)
                {
                    if (game.room is Room2)
                    {
                        link.Position = new Vector2(600, 390);
                    }
                    else if (game.room is Room10)
                    {
                        link.Position = new Vector2(210, 270);
                    }
                }
            }
            lastTeleportTime = DateTime.Now;

        }
    }
}
