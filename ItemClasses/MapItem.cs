using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.ItemClasses
{
    internal class MapItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle mapSource;
        public MapItem(Texture2D mapTexture, Vector2 Pos, Rectangle mapSource)
        {
            texture = mapTexture;
            this.destx = (int)Pos.X;
            this.desty = (int)Pos.Y;
            this.mapSource = mapSource;
        }

        public void Update()
        {
        }

        public Rectangle DestRectangle()
        {
            int width = this.mapSource.Width;
            int height = this.mapSource.Height;
            return new Rectangle(destx, desty, width * 2, height * 2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = this.mapSource;
            spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
        }
    }
}
