using Microsoft.Xna.Framework.Input;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemClasses;
using Sprint2_Attempt3.Player;
using System;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room11 : RoomSecondary
    {
        private static bool boomerangSpawned;
        private static List<IEnemy> enemies;
        private static Boomerang boomerang;
        public Room11(Game1 game1) : base(game1, 10) 
        {
            boomerangSpawned = false;
            enemies = new List<IEnemy>();
            foreach (IGameObject obj in gameObjectLists[roomNumber])
            {
                if (obj is IEnemy)
                {
                    enemies.Add((IEnemy)obj);
                }
                else if (obj is Boomerang)
                {
                    boomerang = (Boomerang)obj;
                }
            }
        }

        public override void SwitchToSouthRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room7(game1));
            for (int i = 0; i < gameObjectLists[6].Count; i++)
            {
                IGameObject obj = gameObjectLists[6][i];
                if (obj is NorthDoor)
                {
                    if (((NorthDoor)obj).IsBombWall)
                    {
                        ((NorthDoor)obj).Damage();
                    }
                    break;
                }
            }
        }
        public override void SwitchToEastRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room12(game1));
        }
        public override void SwitchToWestRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room10(game1));
        }
        public override void RoomConditionCheck()
        {
            if (!boomerangSpawned && allEnemiesKilledInRoom(enemies))
            {
                boomerang.Spawn();
                boomerangSpawned = true;
            }
        }

    }
}
