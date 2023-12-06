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
            foreach (IWall wall in IWall.Room16WallBlocks) {
                gameObjectLists[roomNumber].Add(wall);
            }
        }

        public override void SwitchToUpperRoom()
        {
            Room16TransitionHandler.Instance.Start = true;
            Room16TransitionHandler.Instance.Transition(this, new Room17(game1));
        }

    }
}
