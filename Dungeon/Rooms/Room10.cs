using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room10 : RoomSecondary
    {
        public Room10(Game1 game1)
        {
            this.game1 = game1;
            room = new DungeonRoom();
            roomNumber = 9;
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
            if (game1.link is DamageLinkDecorator)
            {
                ((DamageLinkDecorator)game1.link).RemoveDecorator();
            }
            collisionDetector = new CollisionDetector(game1, (Link)game1.link);
            CollisionDetector.GameObjectList = gameObjectLists[roomNumber];
        }

        public override void SwitchToNorthRoom()
        {
            game1.room = new Room13(game1);
        }
        public override void SwitchToSouthRoom()
        {
            game1.room = new Room6(game1);
        }
        public override void SwitchToEastRoom()
        {
            game1.room = new Room11(game1);
        }
        public override void SwitchToWestRoom()
        {
            game1.room = new Room9(game1);
        }

    }
}
