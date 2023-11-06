using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room4 : RoomSecondary
    {
        public Room4(Game1 game1) : base(game1, 3) { }
        public override void SwitchToNorthRoom()
        {
            game1.room = new Room6(game1);
        }
        public override void SwitchToSouthRoom()
        {
            game1.room = new Room1(game1);
        }

    }
}
