using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.ItemClasses
{
    internal class ClockItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle clockSource;
        public ClockItem(Texture2D clockTexture, Vector2 Pos, Rectangle clockSource)
        {
            texture = clockTexture;
            this.destx = (int)Pos.X;
            this.desty = (int)Pos.Y;
            this.clockSource = clockSource;
        }

        public void Update()
        {
        }

        public Rectangle DestRectangle()
        {
            int width = this.clockSource.Width;
            int height = this.clockSource.Height;
            return new Rectangle(destx, desty, width * 2, height * 2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = this.clockSource;
            spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
        }
    }
}
