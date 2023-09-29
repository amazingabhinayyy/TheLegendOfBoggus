using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Sprint2
{
    public class diamondTile : ISprite
    {
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        private int currentFrame;
        private Texture2D tilesSet;
        public diamondTile(Texture2D tilesSet)
        {
            sourceRectangle = new Rectangle(17, 0, 16, 16);
            currentFrame = 0;
            this.tilesSet = tilesSet;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {
            destinationRectangle = new Rectangle(125, 125, 48, 48);
            spriteBatch.Begin();
            spriteBatch.Draw(tilesSet, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
