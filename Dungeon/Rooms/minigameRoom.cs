﻿using Microsoft.Xna.Framework;
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
            Target targetTopRight2 = new Target(200, 275, true);
            Target targetTopRight3 = new Target(300, 275, true);
            Target targetTopRight4 = new Target(400, 275, true);
            Target targetTopRight5 = new Target(500, 275, true);
            Target targetTopRight6 = new Target(600, 275, true);
            Target targetMiddleLeft1 = new Target(155, 340, false);
            Target targetMiddleLeft2 = new Target(255, 340, false);
            Target targetMiddleLeft3 = new Target(355, 340, false);
            Target targetMiddleLeft4 = new Target(455, 340, false);
            Target targetMiddleLeft5 = new Target(555, 340, false);
            Target targetMiddleLeft6 = new Target(655, 340, false);
            Target targetLowerRight1 = new Target(105, 405, true);
            Target targetLowerRight2 = new Target(205, 405, true);
            Target targetLowerRight3 = new Target(305, 405, true);
            Target targetLowerRight4 = new Target(405, 405, true);
            Target targetLowerRight5 = new Target(505, 405, true);
            Target targetLowerRight6 = new Target(605, 405, true);

            enemies = new List<IEnemy>();
            gameObjectLists[roomNumber].Add(targetTopRight1);
            gameObjectLists[roomNumber].Add(targetTopRight2);
            gameObjectLists[roomNumber].Add(targetTopRight3);
            gameObjectLists[roomNumber].Add(targetTopRight4);
            gameObjectLists[roomNumber].Add(targetTopRight5);
            gameObjectLists[roomNumber].Add(targetTopRight6);
            gameObjectLists[roomNumber].Add(targetMiddleLeft1);
            gameObjectLists[roomNumber].Add(targetMiddleLeft2);
            gameObjectLists[roomNumber].Add(targetMiddleLeft3);
            gameObjectLists[roomNumber].Add(targetMiddleLeft4);
            gameObjectLists[roomNumber].Add(targetMiddleLeft5);
            gameObjectLists[roomNumber].Add(targetMiddleLeft6);
            gameObjectLists[roomNumber].Add(targetLowerRight1);
            gameObjectLists[roomNumber].Add(targetLowerRight2);
            gameObjectLists[roomNumber].Add(targetLowerRight3);
            gameObjectLists[roomNumber].Add(targetLowerRight4);
            gameObjectLists[roomNumber].Add(targetLowerRight5);
            gameObjectLists[roomNumber].Add(targetLowerRight6);

            foreach (IGameObject obj in gameObjectLists[roomNumber])
            {
                if (obj is IEnemy)
                {
                    enemies.Add((IEnemy)obj);
                }
            }
        }
        public override void SwitchToSouthRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room2(game1));
           
        }
        public override void Update()
        {
            if (!finish)
            {
                if (!TransitionHandler.Instance.Start)
                {
                    if (!game1.deathAnimationActive)
                        collisionManager.Update();
                    int check = gameObjectLists[roomNumber].Count;
                    for (int i = 0; i < gameObjectLists[roomNumber].Count; i++)
                    {
                        IGameObject obj = gameObjectLists[roomNumber][i];
                        if (obj is IEnemy)
                        {
                            if (!spawned)
                            {
                                ((IEnemy)obj).Spawn();
                            }
                            else
                            {
                                if (counter > 100)
                                {
                                    ((IEnemy)obj).Kill();
                                    finish = true;
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
