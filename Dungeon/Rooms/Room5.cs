using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemClasses;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room5 : RoomSecondary
    {
        //private Boolean spawn = varHoldingTrue;
        //private Boolean closeDoor = varHoldingTrue;
        private Boolean spawn;
       
        public Room5(Game1 game1) : base(game1, 4) {
            spawn = UniqueEventsForRooms;
        }
        public override void SwitchToNorthRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room9(game1));
        }
        public override void SwitchToEastRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room6(game1));
        }

        public override void Update()
        {
            Rectangle EastDoorPos = Globals.EastDoorPosition;

            Rectangle expectedPosition = new Rectangle(EastDoorPos.X + 50, EastDoorPos.Y, EastDoorPos.Width - 50, EastDoorPos.Height);


           
            if (EnemiesKilledList[roomNumber] >= 6 && spawn)
            {
                int index = 0;
                while (spawn) {
                    if (GameObjectLists[roomNumber][index] is IDoor)
                    {
                        IDoor door = (IDoor)GameObjectLists[roomNumber][index];
                        if (door.GetHitBox().Equals(EastDoorPos))
                        {

                            ((IDoor)GameObjectLists[roomNumber][index]).Open();
                            spawn = false;
                            UniqueEventsForRooms = spawn;
                        }
                    }
                    index++;
                }
                
            }/*
            else if(EnemiesKilledList[roomNumber] < 6)
            {
                for (int index = 0; index < GameObjectLists[roomNumber].Count; index++)
                {
                    if (GameObjectLists[roomNumber][index] is IDoor)
                    {
                        IDoor door = (IDoor)GameObjectLists[roomNumber][index];
                        if (door.GetHitBox().Equals(expectedPosition))
                        {

                            ((IDoor)GameObjectLists[roomNumber][index]).DiamondLock();

                        }
                    }

                }
            }*/
            
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
