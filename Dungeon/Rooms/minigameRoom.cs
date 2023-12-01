using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Target;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemClasses;
using Sprint2_Attempt3.Player;
using System;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class MinigameRoom : RoomSecondary
    {
        private static bool keySpawned;
        private static List<IEnemy> enemies;
        private static Key key;
        public MinigameRoom(Game1 game1) : base(game1, 18) 
        {
            Target targetTopRight1 = new Target(105, 55, true);
            Target targetTopRight2 = new Target(200, 55, true);
            Target targetTopRight3 = new Target(300, 55, true);
            Target targetTopRight4 = new Target(400, 55, true);
            Target targetTopRight5 = new Target(500, 55, true);
            Target targetTopRight6 = new Target(600, 55, true);
            Target targetMiddleLeft1 = new Target(155, 155, false);
            Target targetMiddleLeft2 = new Target(255, 155, false);
            Target targetMiddleLeft3 = new Target(355, 155, false);
            Target targetMiddleLeft4 = new Target(455, 155, false);
            Target targetMiddleLeft5 = new Target(555, 155, false);
            Target targetMiddleLeft6 = new Target(655, 155, false);
            Target targetLowerRight1 = new Target(105, 255, true);
            Target targetLowerRight2 = new Target(205, 255, true);
            Target targetLowerRight3 = new Target(305, 255, true);
            Target targetLowerRight4 = new Target(405, 255, true);
            Target targetLowerRight5 = new Target(505, 255, true);
            Target targetLowerRight6 = new Target(605, 255, true);



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
                else if (obj is Key)
                {
                    key = (Key)obj;
                }
            }
        }
        public override void SwitchToSouthRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room2(game1));
           
        }
        
    }
}
