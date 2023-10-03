using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.ItemClasses
{
    internal class KeyItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle keySource;
        public KeyItem(Texture2D keyTexture, Vector2 Pos, Rectangle keySource)
        {
            texture = keyTexture;
            this.destx = (int)Pos.X;
            this.desty = (int)Pos.Y;
            this.keySource = keySource;
        }

        public void Update()
        {
        }

        public Rectangle DestRectangle()
        {
            int width = this.keySource.Width;
            int height = this.keySource.Height;
            return new Rectangle(destx, desty, width * 2, height * 2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = this.keySource;
            spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
        }
    }
}
