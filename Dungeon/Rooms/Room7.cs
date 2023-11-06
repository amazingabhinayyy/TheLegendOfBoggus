using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room7 : RoomSecondary
    {
        public Room7(Game1 game1) : base(game1, 6) { }
        public override void SwitchToNorthRoom()
        {
            game1.room = new Room11(game1);
        }
        public override void SwitchToWestRoom()
        {
            game1.room = new Room6(game1);
        }

    }
}
