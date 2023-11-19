using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Aquamentus;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemClasses;
using Sprint2_Attempt3.Player;
using System;
using System.Linq;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room14 : RoomSecondary
    {
        private static bool doorOpen;
        private static Aquamentus aquamentus;
        private static HeartContainer heartContainer;
        private static EastDoor diamondDoor;
        public Room14(Game1 game1) : base(game1, 13) 
        {
            doorOpen = false;
            foreach (IGameObject obj in GameObjectLists[roomNumber])
            {
                if (obj is Aquamentus)
                {
                    aquamentus = (Aquamentus)obj;
                }
                else if (obj is HeartContainer)
                {
                    heartContainer = (HeartContainer)obj;
                }
                else if (obj is EastDoor)
                {
                    diamondDoor = (EastDoor)obj;
                }
            }
        }

        public override void SwitchToSouthRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room12(game1));
        }
        public override void SwitchToEastRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room15(game1));
        }
        public override void RoomConditionCheck()
        {
            if (!doorOpen && !aquamentus.exists)
            {
                diamondDoor.Open();
                heartContainer.Spawn();
                doorOpen = true;
            }
        }

    }
}
