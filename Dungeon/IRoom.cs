using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Dungeon
{
    public interface IRoom
    {
        private static List<IGameObject> gameObjects;
        public void Update();
        public void Draw(SpriteBatch spriteBatch);
    }
}
