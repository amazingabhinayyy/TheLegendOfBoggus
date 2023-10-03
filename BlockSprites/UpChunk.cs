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
    public class UpChunk : IBlockSprite
    {
        private Rectangle upChunkSource;
        private int destX, destY;
        private Texture2D tilesSet;
        public UpChunk(Texture2D tilesSet, Vector2 Pos, Rectangle upChunkSource)
        {
            this.tilesSet = tilesSet;
            this.destX = (int)Pos.X;
            this.destY = (int)Pos.Y;
            this.upChunkSource = upChunkSource;
        }

        public void Update()
        {
        }

        public Rectangle DestRectangle()
        {
            int width = this.upChunkSource.Width;
            int height = this.upChunkSource.Height;
            return new Rectangle(destX, destY, width * 3, height * 3);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle scrRectangle = this.upChunkSource;
            spriteBatch.Draw(tilesSet, DestRectangle(), scrRectangle, Color.White);
        }
    }
}
