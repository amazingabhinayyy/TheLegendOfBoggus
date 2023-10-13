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
    public class WhiteStair : IBlockSprite
    {
        private Rectangle upChunkSource;
        private int destX, destY;
        private Texture2D tilesSet;
        public WhiteStair(Texture2D tilesSet, Vector2 Pos, Rectangle upChunkSource)
        {
            this.tilesSet = tilesSet;
            destX = (int)Pos.X;
            destY = (int)Pos.Y;
            this.upChunkSource = upChunkSource;
        }

        public void Update()
        {
        }

        public Rectangle DestRectangle()
        {
            int width = upChunkSource.Width;
            int height = upChunkSource.Height;
            return new Rectangle(destX, destY, width * 3, height * 3);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle scrRectangle = upChunkSource;
            spriteBatch.Draw(tilesSet, DestRectangle(), scrRectangle, Color.White);
        }
    }
}
