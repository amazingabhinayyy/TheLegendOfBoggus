using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Dodongo;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Player.Interfaces;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room1 : RoomSecondary
    {
        public Room1(Game1 game1): base(game1, 0) { }

        public override void SwitchToNorthRoom() {
            game1.room = new Room4(game1);
        }
        public override void SwitchToEastRoom() {
            game1.room = new Room3(game1);
        }
        public override void SwitchToWestRoom() {
            game1.room = new Room2(game1);
        }

    }
}
