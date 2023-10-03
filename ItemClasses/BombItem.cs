using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.ItemClasses
{
    internal class BombItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle bombSource;
        public BombItem(Texture2D bombTexture, Vector2 Pos, Rectangle bombSource)
        {
            texture = bombTexture;
            this.destx = (int)Pos.X;
            this.desty = (int)Pos.Y;
            this.bombSource = bombSource;
        }

        public void Update()
        {
        }

        public Rectangle DestRectangle()
        {
            int width = this.bombSource.Width;
            int height = this.bombSource.Height;
            return new Rectangle(destx, desty, width*2, height*2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = this.bombSource;
            spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
        }
    }
}
