using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class BoomerangItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle boomerangSource;
        public BoomerangItem(Texture2D boomerangTexture, Vector2 Pos, Rectangle boomerangSource)
        {
            texture = boomerangTexture;
            destx = (int)Pos.X;
            desty = (int)Pos.Y;
            this.boomerangSource = boomerangSource;
        }

        public void Update()
        {
        }

        public Rectangle DestRectangle()
        {
            int width = boomerangSource.Width;
            int height = boomerangSource.Height;
            return new Rectangle(destx, desty, width * 2, height * 2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = boomerangSource;
            spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
        }
    }
}
