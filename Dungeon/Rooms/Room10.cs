using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room10 : RoomSecondary
    {
        public Room10(Game1 game1) : base(game1, 9) { }

        public override void SwitchToNorthRoom()
        {
            game1.room = new Room13(game1);
        }
        public override void SwitchToSouthRoom()
        {
            game1.room = new Room6(game1);
        }
        public override void SwitchToEastRoom()
        {
            game1.room = new Room11(game1);
        }
        public override void SwitchToWestRoom()
        {
            game1.room = new Room9(game1);
        }

    }
}
