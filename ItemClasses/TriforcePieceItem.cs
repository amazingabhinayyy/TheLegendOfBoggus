using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.ItemClasses
{
    internal class TriforcePieceItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle triforcepieceSource;
        public TriforcePieceItem(Texture2D triforcepieceTexture, Vector2 Pos, Rectangle triforcepieceSource)
        {
            texture = triforcepieceTexture;
            this.destx = (int)Pos.X;
            this.desty = (int)Pos.Y;
            this.triforcepieceSource = triforcepieceSource;
        }

        public void Update()
        {
        }

        public Rectangle DestRectangle()
        {
            int width = this.triforcepieceSource.Width;
            int height = this.triforcepieceSource.Height;
            return new Rectangle(destx, desty, width*2, height*2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = this.triforcepieceSource;
            spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
        }
    }
}
