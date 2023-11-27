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
using System.Collections.Generic;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room5 : RoomSecondary
    {
        private static List<IEnemy> enemies;
        private static EastDoor diamondDoor;
        private static bool doorOpen;
        public Room5(Game1 game1) : base(game1, 4) 
        {
            doorOpen = false;
            enemies = new List<IEnemy>();
            foreach(IGameObject obj in gameObjectLists[roomNumber])
            {
                if (obj is IEnemy)
                {
                    enemies.Add((IEnemy)obj);
                }
                else if(obj is EastDoor)
                {
                    diamondDoor = (EastDoor)obj;
                }
            }
        }
        public override void SwitchToNorthRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room9(game1));
            for (int i = 0; i < gameObjectLists[8].Count; i++)
            {
                IGameObject obj = gameObjectLists[8][i];
                if (obj is SouthDoor)
                {
                    if (((SouthDoor)obj).IsLocked)
                    {
                        ((SouthDoor)obj).Open();
                    }
                    break;
                }
            }
        }
        public override void SwitchToEastRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room6(game1));
        }
        public override void RoomConditionCheck()
        {
            if(!doorOpen && allEnemiesKilledInRoom(enemies))
            {
                diamondDoor.Open();
                doorOpen = true; 
            }
        }

    }
}
