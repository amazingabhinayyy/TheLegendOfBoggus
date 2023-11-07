using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room2 : RoomSecondary
    {
        public Room2(Game1 game1)
        {
            this.game1 = game1;
            room = new DungeonRoom();
            roomNumber = 1;
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
            
            collisionDetector = new CollisionDetector(game1, game1.link);
            /*
            CollisionDetector.GameObjectList = gameObjectLists[roomNumber];*/

            TransitionHandler.Instance.TransitionGameObjectList = gameObjectLists[roomNumber];
        }
        public override void SwitchToEastRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room1(game1));
            game1.room = new Room1(game1);
            /*roomNumber = 0;
            CollisionDetector.GameObjectList = gameObjectLists[roomNumber];*/
        }

    }
}
