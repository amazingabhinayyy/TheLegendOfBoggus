using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Items.ItemClasses;
using Sprint2_Attempt3.Dungeon.Doors;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room9 : RoomSecondary
    {
        private static bool doorOpen;
        private static IMovingBlock movingBlock;
        private static WestDoor diamondDoor;
        public Room9(Game1 game1) : base(game1, 8)
        {
            doorOpen = false;
            foreach (IGameObject obj in GameObjectLists[roomNumber])
            {
                if (obj is IMovingBlock)
                {
                    movingBlock = (IMovingBlock)obj;
                }
                else if (obj is WestDoor)
                {
                    diamondDoor = (WestDoor)obj;
                }
            }
        }


        public override void SwitchToSouthRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room5(game1));
        }
        public override void SwitchToEastRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room10(game1));
        }
        public override void SwitchToWestRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room8(game1)); 
        }
        public override void RoomConditionCheck()
        {
            if (!doorOpen && movingBlock.Moved)
            {
                diamondDoor.Open();
                doorOpen = true;
            }
        }
    }
}
