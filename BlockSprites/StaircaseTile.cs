using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.BlockSprites
{
    public class StaircaseTile : IBlockSprite
    {
        private Rectangle diamondSource;
        private int destX, destY;
        private Texture2D tilesSet;
        public StaircaseTile(Texture2D tilesSet, Vector2 Pos, Rectangle diamondSource)
        {
            this.tilesSet = tilesSet;
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
            spriteBatch.Draw(tilesSet, DestRectangle(), scrRectangle, Color.White);
        }
    }
}
