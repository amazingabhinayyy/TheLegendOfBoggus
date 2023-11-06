using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room12 : RoomSecondary
    {
        public Room12(Game1 game1) : base(game1, 11) { }

        public override void SwitchToNorthRoom()
        {
            game1.room = new Room14(game1);
        }
        public override void SwitchToWestRoom()
        {
            game1.room = new Room11(game1);
        }

    }
}
