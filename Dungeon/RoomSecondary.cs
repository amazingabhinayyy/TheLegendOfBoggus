using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Dungeon
{
    public abstract class RoomSecondary : IRoom
    {
        protected static List<IGameObject> gameObjects;
        protected IDungeonRoom room;
        protected Game1 game1;

        public void Update() { 
            //collision handling goes here

            foreach(IEnemy enemy in gameObjects){ 
                enemy.Update();
            }

            /*foreach (IItem item in gameObjects) { 
                item.Update();
            }*/
            
            game1.link.Update();
        }

        public void Draw(SpriteBatch spriteBatch) {
            room.Draw(spriteBatch);
            
            foreach (IEnemy enemy in gameObjects)
            {
                enemy.Draw(spriteBatch);
            }

            /*foreach (IItem item in gameObjects)
            {
                item.Draw(spriteBatch);
            }*/

           /* foreach (IBlock block in gameObjects)
            {
                block.Draw(spriteBatch);
            }*/
            
            game1.link.Draw(spriteBatch, Color.White);
        }
    }
}
