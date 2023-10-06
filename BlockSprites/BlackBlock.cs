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
    public class BlackBlock : IBlockSprite
    {
        private Rectangle blackBlockSource;
        private int destX, destY;
        private Texture2D blocks;
        public BlackBlock(Texture2D blocks, Vector2 Pos, Rectangle diamondSource)
        {
            this.blocks = blocks;
            this.destX = (int)Pos.X;
            this.destY = (int)Pos.Y;
            this.blackBlockSource = blackBlockSource;
        }

        public void Update()
        {
        }

        public Rectangle DestRectangle()
        {
            int width = this.blackBlockSource.Width;
            int height = this.blackBlockSource.Height;
            return new Rectangle(destX, destY, width * 3, height * 3);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle scrRectangle = this.blackBlockSource;
            spriteBatch.Draw(blocks, DestRectangle(), scrRectangle, Color.White);
        }
    }
}
