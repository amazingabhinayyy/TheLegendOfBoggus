using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.ItemClasses
{
    internal class RupeeItem : IJustItemSprite
    {
        private Texture2D rupeeTexture;
        public int destx, desty;
        public Rectangle rupeeSource;
        public RupeeItem(Texture2D rupeeTexture, Vector2 Pos, Rectangle rupeeSource)
        {
            this.rupeeTexture = rupeeTexture;
            this.destx = (int)Pos.X;
            this.desty = (int)Pos.Y;
            this.rupeeSource = rupeeSource;
        }

        public void Update()
        { 
        }

        public Rectangle DestRectangle()
        {
            int width = this.rupeeSource.Width;
            int height = this.rupeeSource.Height;
            //int height = ItemSpriteFactory.rupee.Height;
            return new Rectangle(destx, desty, width*2, height*2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = this.rupeeSource;
            spriteBatch.Draw(rupeeTexture, DestRectangle(), srcRectangle, Color.White);
        }
    }
}
