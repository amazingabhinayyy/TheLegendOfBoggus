using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Aquamentus;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemClasses;
using Sprint2_Attempt3.Player;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room19 : RoomSecondary
    {

        private static SouthDoor diamondDoor;
        private static List<IEnemy> enemies;
        private bool doorOpen;
        public Room19(Game1 game1) : base(game1, 19) 
        {
            roomLayout[8, 6] = this;
            doorOpen = false;
            enemies = new List<IEnemy>();
            foreach (IGameObject obj in gameObjectList)
            {
                if (obj is IEnemy)
                {
                    enemies.Add((IEnemy)obj);
                }

                if (obj is SouthDoor)
                {
                    diamondDoor = (SouthDoor)obj;
                }
            }
        }

        public override void SwitchToSouthRoom()
        {
            mapY += 1;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }
        public override void RoomConditionCheck()
        {
            if (!doorOpen && allEnemiesKilledInRoom(enemies))
            {
                diamondDoor.Open();
                doorOpen = true;
            }
        }
    }
}
