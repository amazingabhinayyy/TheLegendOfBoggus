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
        //private Boolean spawn = varHoldingTrue;
        //private Boolean notMovedYet = varHoldingTrue;
        private Boolean spawn;
        private Boolean notMovedYet = true;
        public Room9(Game1 game1) : base(game1, 8) {
            spawn = UniqueEventsForRooms;
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

        public override void Update()
        {
            

                for(int index = 0; index < GameObjectLists[roomNumber].Count; index++)
                {
                    if (GameObjectLists[roomNumber][index] is IMovingBlock)
                    {
                        if (((IMovingBlock)GameObjectLists[roomNumber][index]).Moved)
                        {
                            int index2 = 0;
                            while (spawn)
                            {
                                if (GameObjectLists[roomNumber][index2] is IDoor)
                                {
                                    IDoor door = (IDoor)GameObjectLists[roomNumber][index2];
                                    if (door.GetHitBox().Equals(Globals.WestDoorPosition))
                                    {

                                        ((IDoor)GameObjectLists[roomNumber][index2]).Open();
                                        spawn = false;
                                        UniqueEventsForRooms = spawn;
                                    }
                                }
                                index2++;
                            }
                        }
                        
                    }
                }

            
            if (!TransitionHandler.Instance.Start)
            {
                collisionDetector.Update();

                for (int i = 0; i < gameObjectLists[roomNumber].Count; i++)
                {
                    IGameObject obj = gameObjectLists[roomNumber][i];
                    if (obj is IEnemy)
                    {
                        if (!spawned)
                        {
                            ((IEnemy)obj).Spawn();
                        }
                        if (!ClockUsed || ((IEnemy)obj).State is DeathAnimationState)
                            ((IEnemy)obj).Update();

                    }
                    else if (obj is IItem)
                    {
                        ((IItem)obj).Update();
                        if (((IItem)obj).exists)
                        {
                            ((IItem)obj).Spawn();
                        }
                    }
                }
                spawned = true;

                game1.link.Update();
            }
        }

    }
}
