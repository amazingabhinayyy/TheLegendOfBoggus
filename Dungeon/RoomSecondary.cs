using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Dungeon
{
    public abstract class RoomSecondary : IRoom
    {
        protected static List<IGameObject>[] gameObjectLists = new List<IGameObject>[18];
        protected static int roomNumber;
        protected DungeonRoom room;
        protected Game1 game1;
        protected CollisionDetector collisionDetector;
        protected BlockCollisionClass blockCollision;

        public RoomSecondary()
        {    
        }
        public void SwitchRooms() {
            if (roomNumber < gameObjectLists.Length - 1)
            {
                roomNumber++;
            }
            else
            {
                roomNumber = 0;
            }
            CollisionDetector.GameObjectList = gameObjectLists[roomNumber];
        }
        public void Update() {
            //collision handling goes here
            collisionDetector.Update();
            blockCollision.Update();

            for (int i = 0; i < gameObjectLists[roomNumber].Count; i++)
            {
                IGameObject obj = gameObjectLists[roomNumber][i];
                if (obj is IEnemy)
                    ((IEnemy)obj).Update();
                else if (obj is IItem)
                    ((IItem)obj).Update();
            }

            game1.link.Update();
        }

        public void Draw(SpriteBatch spriteBatch) {
            room.Draw(spriteBatch);
            
            foreach (IGameObject obj in gameObjectLists[roomNumber])
            {
                if(obj is IEnemy)
                    ((IEnemy)obj).Draw(spriteBatch);
                else if(obj is IItem)
                    ((IItem)obj).Draw(spriteBatch);
                else if(obj is IBlock)
                    ((IBlock)obj).Draw(spriteBatch);
                else if (obj is IDoor)
                    ((IDoor)obj).Draw(spriteBatch);
            }
            
            game1.link.Draw(spriteBatch, Color.White);
        }

        public virtual void SwitchToNorthRoom() { }
        public virtual void SwitchToSouthRoom() { }
        public virtual void SwitchToEastRoom() { }
        public virtual void SwitchToWestRoom() { }
        
    }
}
