using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.ItemClasses
{
    internal class HeartItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle heartSource;
        public HeartItem(Texture2D heartTexture, Vector2 Pos, Rectangle heartSource)
        {
            texture = heartTexture;
            this.destx = (int)Pos.X;
            this.desty = (int)Pos.Y;
            this.heartSource = heartSource;
        }

        public void Update()
        {
        }

        public Rectangle DestRectangle()
        {
            int width = this.heartSource.Width;
            int height = this.heartSource.Height;
            return new Rectangle(destx, desty, width * 2, height * 2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = this.heartSource;
            spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
        }
    }
}
