using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Dungeon
{
    public abstract class RoomSecondary : IRoom
    {
        protected static List<IGameObject>[] gameObjectLists = { null };
        protected static int roomNumber;
        protected DungeonRoom room;
        protected Game1 game1;

        public RoomSecondary()
        {
        }
        public void Update() {
            //collision handling goes here

            foreach (IGameObject obj in gameObjectLists[roomNumber])
            {
                obj.Update();
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
    }
}
