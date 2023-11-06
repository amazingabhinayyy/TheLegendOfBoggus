using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room2 : RoomSecondary
    {
        public Room2(Game1 game1) : base(game1, 1) { }
        public override void SwitchToEastRoom()
        {
            game1.room = new Room1(game1);
        }

    }
}
