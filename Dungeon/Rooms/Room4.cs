﻿using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room4 : RoomSecondary
    {
        public Room4(Game1 game1)
        {
            this.game1 = game1;
            room = new DungeonRoom();
            roomNumber = 3;
            if (gameObjectLists[roomNumber] == null)
            {
                gameObjectLists[roomNumber] = RoomGenerator.Instance.LoadFile(roomNumber);
                gameObjectLists[roomNumber].Add(this.game1.link);
            }

            foreach (IGameObject obj in gameObjectLists[roomNumber])
            {
                if (obj is IEnemy)
                {
                    ((IEnemy)obj).Spawn();
                }
                else if (obj is IItem)
                {
                    if (((IItem)obj).exists)
                    {
                        ((IItem)obj).Spawn();
                    }
                }
            }

            collisionDetector = new CollisionDetector(game1);
            CollisionDetector.GameObjectList = gameObjectLists[roomNumber];
        }
        public override void SwitchToNorthRoom()
        {
            game1.room = new Room6(game1);
        }
        public override void SwitchToSouthRoom()
        {
            game1.room = new Room1(game1);
        }

    }
}
