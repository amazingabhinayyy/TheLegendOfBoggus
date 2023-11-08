using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.WallBlocks;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room16 : RoomSecondary
    {
        public Room16(Game1 game1) : base(game1, 15) {
            room = new WhiteStairRoom();
        }
        public override void SwitchToEastRoom()
        {
            game1.room = new Room17(game1);
        }

    }
}
