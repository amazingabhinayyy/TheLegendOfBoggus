using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room12 : RoomSecondary
    {
        public Room12(Game1 game1)
        {
            this.game1 = game1;
            room = new DungeonRoom();
            roomNumber = 11;
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
            blockCollision = new BlockCollisionClass(game1);
        }
        public override void SwitchToNorthRoom()
        {
            game1.room = new Room14(game1);
        }
        public override void SwitchToWestRoom()
        {
            game1.room = new Room11(game1);
        }

    }
}
