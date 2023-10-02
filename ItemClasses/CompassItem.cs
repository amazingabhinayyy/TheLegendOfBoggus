using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.ItemClasses
{
    internal class CompassItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle compassSource;
        public CompassItem(Texture2D compassTexture, Vector2 Pos, Rectangle source)
        {
            texture = compassTexture;
            this.destx = (int)Pos.X;
            this.desty = (int)Pos.Y;
            compassSource = source;
        }

        public void Update()
        {
        }

        public Rectangle DestRectangle()
        {
            int width = compassSource.Width;
            int height = compassSource.Height;
            return new Rectangle(destx, desty, width * 2, height * 2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = compassSource;
            spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
        }
    }
}
