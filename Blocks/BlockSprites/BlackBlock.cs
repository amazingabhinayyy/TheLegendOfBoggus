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
    public class BlackBlock : IBlockSprite
    {
        private Rectangle blackBlockSource;
        private int destX, destY;
        private Texture2D blocks;
        public BlackBlock(Texture2D blocks, Vector2 Pos, Rectangle diamondSource)
        {
            this.blocks = blocks;
            destX = (int)Pos.X;
            destY = (int)Pos.Y;
            blackBlockSource = blackBlockSource;
        }

        public void Update()
        {
        }

        public Rectangle DestRectangle()
        {
            int width = blackBlockSource.Width;
            int height = blackBlockSource.Height;
            return new Rectangle(destX, destY, width * 3, height * 3);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle scrRectangle = blackBlockSource;
            spriteBatch.Draw(blocks, DestRectangle(), scrRectangle, Color.White);
        }
    }
}
