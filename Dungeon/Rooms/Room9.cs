using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;
using Sprint2_Attempt3.Blocks;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room9 : RoomSecondary
    {
        public Room9(Game1 game1) : base(game1, 8) { }

        public override void SwitchToSouthRoom()
        {
            game1.room = new Room5(game1);
        }
        public override void SwitchToEastRoom()
        {
            game1.room = new Room10(game1);
        }
        public override void SwitchToWestRoom()
        {
            game1.room = new Room8(game1);
        }

    }
}
