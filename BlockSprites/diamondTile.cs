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
    public class DiamondTile : IBlockSprite
    {
        private Rectangle diamondSource;
        private int destX, destY;
        private Texture2D blocks;
        public DiamondTile(Texture2D blocks, Vector2 Pos, Rectangle diamondSource)
        {
            this.blocks = blocks;
            this.destX = (int)Pos.X;
            this.destY = (int)Pos.Y;
            this.diamondSource = diamondSource;
        }

        public void Update()
        {
        }

        public Rectangle DestRectangle()
        {
            int width = this.diamondSource.Width;
            int height = this.diamondSource.Height;
            return new Rectangle(destX, destY, width * 3, height * 3);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle scrRectangle = this.diamondSource;
            spriteBatch.Draw(blocks, DestRectangle(), scrRectangle, Color.White);
        }
    }
}
