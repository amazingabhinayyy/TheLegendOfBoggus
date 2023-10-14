using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class TriforcePieceItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle triforcepieceSource;
        private int currentFrame;
        private int totalFrames;
        private int time;
        private Rectangle srcRectangle;
        public TriforcePieceItem(Texture2D triforcepieceTexture, Vector2 Pos, Rectangle triforcepieceSource)
        {
            texture = triforcepieceTexture;
            destx = (int)Pos.X;
            desty = (int)Pos.Y;
            this.triforcepieceSource = triforcepieceSource;
            currentFrame = 1;
            totalFrames = 3;
            time = 0;
            srcRectangle = this.triforcepieceSource;
        }

        public void Update()
        {
            if (time % 8 == 0)
            {
                currentFrame++;
                if (currentFrame == totalFrames)
                {
                    currentFrame = 1;
                }
            }
            time++;
        }

        public Rectangle DestRectangle()
        {
            int width = triforcepieceSource.Width;
            int height = triforcepieceSource.Height;
            return new Rectangle(destx, desty, width * 2, height * 2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (currentFrame == 1)
            {
                srcRectangle = triforcepieceSource;

            }
            else if (currentFrame == 2)
            {
                srcRectangle = ItemSpriteFactory.bluetriforcepieceSrc;
            }
            spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
        }
    }
}
