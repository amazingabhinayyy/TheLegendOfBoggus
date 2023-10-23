using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room9 : RoomSecondary
    {
        public Room9(Game1 game1)
        {
            this.game1 = game1;
            room = new DungeonRoom();
            roomNumber = 8;
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

            collisionDetector = new CollisionDetector(game1, (Link)game1.link);
            CollisionDetector.GameObjectList = gameObjectLists[roomNumber];
        }
        public override void SwitchToSouthRoom()
        {
            game1.room = new Room5(game1);
        }
        public override void SwitchToEastRoom()
        {
            game1.room = new Room10(game1);
        }
        public override void SwitchToWestRoom()
        {
            game1.room = new Room8(game1);
        }

    }
}
