using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Sprint2_Attempt3.Blocks;

namespace Sprint2_Attempt3.Blocks.BlockSprites
{
    public class PlainTile : IBlockSprite
    {
        private Rectangle plainSource;
        private int destX, destY;
        private Texture2D blocks;
        public PlainTile(Texture2D blocks, Vector2 Pos, Rectangle plainSource)
        {
            this.blocks = blocks;
            destX = (int)Pos.X;
            destY = (int)Pos.Y;
            this.plainSource = plainSource;
        }

        public void Update()
        {
        }

        public Rectangle DestRectangle()
        {
            int width = plainSource.Width;
            int height = plainSource.Height;
            return new Rectangle(destX, destY, width * 3, height * 3);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle scrRectangle = plainSource;
            spriteBatch.Draw(blocks, DestRectangle(), scrRectangle, Color.White);
        }
    }
}
