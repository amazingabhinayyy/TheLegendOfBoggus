using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Sprint2
{
    public class PlainTile : IBlockSprite
    {
        private Rectangle plainSource;
        private int destX, destY;
        private Texture2D tilesSet;
        public PlainTile(Texture2D tilesSet, Vector2 Pos, Rectangle plainSource)
        {
            this.tilesSet = tilesSet;
            this.destX = (int)Pos.X;
            this.destY = (int)Pos.Y;
            this.plainSource = plainSource;
        }

        public void Update()
        {
        }

        public Rectangle DestRectangle()
        {
            int width = this.plainSource.Width;
            int height = this.plainSource.Height;
            return new Rectangle(destX, destY, width*3, height*3);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle scrRectangle = this.plainSource;
            spriteBatch.Draw(tilesSet, DestRectangle(), scrRectangle, Color.White);
        }
    }
}
