using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.WallBlocks;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room16 : RoomSecondary
    {
        public Room16(Game1 game1) : base(game1, 15) {
            room = new WhiteStairRoom();
            foreach (IWall wall in Globals.Room16WallBlocks) {
                gameObjectLists[roomNumber].Add(wall);
            }
        }
        public override void SwitchToEastRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room17(game1));
        }

        public override void SwitchToUpperRoom()
        {
            game1.room = new Room17(game1);
        }

    }
}
