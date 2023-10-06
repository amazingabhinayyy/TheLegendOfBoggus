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
    public class SideChunk : IBlockSprite
    {
        private Rectangle sideChunkSource;
        private int destX, destY;
        private Texture2D blocks;
        public SideChunk(Texture2D blocks, Vector2 Pos, Rectangle sideChunkSource)
        {
            this.blocks = blocks;
            this.destX = (int)Pos.X;
            this.destY = (int)Pos.Y;
            this.sideChunkSource = sideChunkSource;
        }

        public void Update()
        {
        }

        public Rectangle DestRectangle()
        {
            int width = this.sideChunkSource.Width;
            int height = this.sideChunkSource.Height;
            return new Rectangle(destX, destY, width * 3, height * 3);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle scrRectangle = this.sideChunkSource;
            spriteBatch.Draw(blocks, DestRectangle(), scrRectangle, Color.White);
        }
    }
}
