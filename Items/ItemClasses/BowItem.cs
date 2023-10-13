using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class BowItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle bowSource;
        public BowItem(Texture2D bowTexture, Vector2 Pos, Rectangle bowSource)
        {
            texture = bowTexture;
            destx = (int)Pos.X;
            desty = (int)Pos.Y;
            this.bowSource = bowSource;
        }

        public void Update()
        {
        }

        public Rectangle DestRectangle()
        {
            int width = bowSource.Width;
            int height = bowSource.Height;
            return new Rectangle(destx, desty, width * 2, height * 2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = bowSource;
            spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
        }
    }
}
