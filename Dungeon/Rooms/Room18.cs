using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room18 : RoomSecondary
    {
        public Room18(Game1 game1) : base(game1, 17) { }

        public override void SwitchToSouthRoom()
        {
            game1.room = new Room13(game1);
        }
        public override void SwitchToWestRoom()
        {
            game1.room = new Room17(game1);
        }

    }
}
