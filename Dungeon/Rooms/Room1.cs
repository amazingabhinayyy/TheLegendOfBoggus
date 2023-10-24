using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Dodongo;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Player.Interfaces;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room1 : RoomSecondary
    {
        public Room1(Game1 game1)
        {
            this.game1 = game1;
            room = new DungeonRoom();
            roomNumber = 0;
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
            if(game1.link is DamageLinkDecorator)
            {
                ((DamageLinkDecorator)game1.link).RemoveDecorator();
            }

            collisionDetector = new CollisionDetector(game1, game1.link);
            CollisionDetector.GameObjectList = gameObjectLists[roomNumber];
        }

        public override void SwitchToNorthRoom() {
            game1.room = new Room4(game1);
            /*roomNumber = 3;
            CollisionDetector.GameObjectList = gameObjectLists[roomNumber];*/
        }
        public override void SwitchToEastRoom() {
            game1.room = new Room3(game1);
            /*roomNumber = 2;
            CollisionDetector.GameObjectList = gameObjectLists[roomNumber];*/
        }
        public override void SwitchToWestRoom() {
            game1.room = new Room2(game1);
            /*roomNumber = 1;
            CollisionDetector.GameObjectList = gameObjectLists[roomNumber];*/
        }

    }
}
