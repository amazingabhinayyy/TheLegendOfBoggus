using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room11 : RoomSecondary
    {
        public Room11(Game1 game1) : base(game1, 10) { }

        public override void SwitchToSouthRoom()
        {
            game1.room = new Room7(game1);
        }
        public override void SwitchToEastRoom()
        {
            game1.room = new Room12(game1);
        }
        public override void SwitchToWestRoom()
        {
            game1.room = new Room10(game1);
        }

    }
}
