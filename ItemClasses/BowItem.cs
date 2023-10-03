using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.ItemClasses
{
    internal class BowItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle bowSource;
        public BowItem(Texture2D bowTexture, Vector2 Pos, Rectangle bowSource)
        {
            texture = bowTexture;
            this.destx = (int)Pos.X;
            this.desty = (int)Pos.Y;
            this.bowSource = bowSource;
        }

        public void Update()
        {
        }

        public Rectangle DestRectangle()
        {
            int width = this.bowSource.Width;
            int height = this.bowSource.Height;
            return new Rectangle(destx, desty, width * 2, height * 2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = this.bowSource;
            spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
        }
    }
}
