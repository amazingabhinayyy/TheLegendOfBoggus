using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemClasses;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room6 : RoomSecondary
    {
        private Boolean spawn = true;
        public Room6(Game1 game1) : base(game1, 5) { }
        public override void SwitchToNorthRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room10(game1));
        }
        public override void SwitchToSouthRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room4(game1));
        }
        public override void SwitchToEastRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room7(game1));
        }
        public override void SwitchToWestRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room5(game1));
        }
        public override void Update()
        {
            if (EnemiesKilledList[roomNumber] >= 5 && spawn)
            {
                gameObjectLists[roomNumber].Add(new Key(new Vector2(Globals.FloorGrid[19].X + Globals.FloorGrid[19].Width / 4, Globals.FloorGrid[19].Y), true));
                spawn = false;

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
