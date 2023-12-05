using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room12 : RoomSecondary
    {
        public Room12(Game1 game1) : base(game1, 11) 
        {
            roomLayout[7, 8] = this;
        }

        public override void SwitchToNorthRoom()
        {
            mapY -= 1;
            SwitchRoom(mapX, mapY);
        }
        public override void SwitchToWestRoom()
        {
            mapY -= 1;
            SwitchRoom(mapX, mapY);
        }

    }
}
