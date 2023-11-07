using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room14 : RoomSecondary
    {
        public Room14(Game1 game1) : base(game1, 13) { }

        public override void SwitchToSouthRoom()
        {
            game1.room = new Room12(game1);
        }
        public override void SwitchToEastRoom()
        {
            game1.room = new Room15(game1);
        }

    }
}
