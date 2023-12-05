using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Target;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemClasses;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Sounds;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class MinigameRoom : RoomSecondary
    {
        private static List<IEnemy> enemies;
        private int counter;
        bool finish;
        public MinigameRoom(Game1 game1) : base(game1, 18) 
        {
            counter = 0;
            finish = false;
            Target targetTopRight1 = new Target(105, 275, true);
            Target targetTopRight2 = new Target(190, 275, true);
            Target targetTopRight3 = new Target(280, 275, true);
            Target targetTopRight4 = new Target(370, 275, true);
            Target targetTopRight5 = new Target(460, 275, true);
            Target targetTopRight6 = new Target(550, 275, true);
            Target targetMiddleLeft1 = new Target(155, 340, false);
            Target targetMiddleLeft2 = new Target(245, 340, false);
            Target targetMiddleLeft3 = new Target(335, 340, false);
            Target targetMiddleLeft4 = new Target(425, 340, false);
            Target targetMiddleLeft5 = new Target(515, 340, false);
            Target targetMiddleLeft6 = new Target(605, 340, false);
            Target targetLowerRight1 = new Target(105, 405, true);
            Target targetLowerRight2 = new Target(190, 405, true);
            Target targetLowerRight3 = new Target(280, 405, true);
            Target targetLowerRight4 = new Target(370, 405, true);
            Target targetLowerRight5 = new Target(460, 405, true);
            Target targetLowerRight6 = new Target(550, 405, true);

            enemies = new List<IEnemy>();
            gameObjectList.Add(targetTopRight1);
            gameObjectList.Add(targetTopRight2);
            gameObjectList.Add(targetTopRight3);
            gameObjectList.Add(targetTopRight4);
            gameObjectList.Add(targetTopRight5);
            gameObjectList.Add(targetTopRight6);
            gameObjectList.Add(targetMiddleLeft1);
            gameObjectList.Add(targetMiddleLeft2);
            gameObjectList.Add(targetMiddleLeft3);
            gameObjectList.Add(targetMiddleLeft4);
            gameObjectList.Add(targetMiddleLeft5);
            gameObjectList.Add(targetMiddleLeft6);
            gameObjectList.Add(targetLowerRight1);
            gameObjectList.Add(targetLowerRight2);
            gameObjectList.Add(targetLowerRight3);
            gameObjectList.Add(targetLowerRight4);
            gameObjectList.Add(targetLowerRight5);
            gameObjectList.Add(targetLowerRight6);

            foreach (IGameObject obj in gameObjectList)
            {
                if (obj is IEnemy)
                {
                    enemies.Add((IEnemy)obj);
                }
            }
            roomLayout[4, 10] = this;
        }
        public override void SwitchToSouthRoom()
        {
            for (int i = 0; i < gameObjectList.Count; i++)
            {
                IGameObject obj = gameObjectList[i];
                if(obj is IEnemy) { }
                    //((IEnemy)obj).Kill();
            }
            mapY++;
            SwitchRoom();
            SoundFactory.Instance.undertaleMusic.Pause();
            SoundFactory.Instance.backgroundMusic.Resume();
        }
        public override void Update()
        {
            if (!finish)
            {
                if (!TransitionHandler.Instance.Start)
                {
                    if (!game1.deathAnimationActive)
                        collisionManager.Update();
                    int check = gameObjectList.Count;
                    for (int i = 0; i < gameObjectList.Count; i++)
                    {
                        IGameObject obj = gameObjectList[i];
                        if (obj is IEnemy)
                        {
                            if (!spawned)
                            {
                                ((IEnemy)obj).Spawn();
                            }
                            else
                            {
                                if (counter > 1000)
                                {
                                    ((IEnemy)obj).Kill();
                                    finish = true;
                                    SoundFactory.PlaySound(SoundFactory.Instance.rickRoll);
                                }
                            }
                            if (!ClockUsed || ((IEnemy)obj).State is DeathAnimationState)
                                ((IEnemy)obj).Update();

                        }
                        else if (obj is IItem)
                        {
                            ((IItem)obj).Update();
                        }
                        else if (obj is IBlock)
                            ((IBlock)obj).Update();
                    }
                    spawned = true;

                    game1.link.Update();
                    RoomConditionCheck();
                }
                counter++;
            }
            base.Update();
        }
    }
}
