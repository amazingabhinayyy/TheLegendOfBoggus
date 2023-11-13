using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room17 : RoomSecondary
    {
        public Room17(Game1 game1) : base(game1, 16) { }

        public override void SwitchToEastRoom()
        {
            game1.room = new Room18(game1);
        }

        public override void SwitchToLowerRoom()
        {
            game1.room = new Room16(game1);
        }
    }
}
