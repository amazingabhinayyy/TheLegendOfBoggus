using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.ItemClasses
{
    internal class FairyItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle fairySource;
        private int currentFrame;
        private int totalFrames;
        private int time;
        private Rectangle srcRectangle;
        public FairyItem(Texture2D fairyTexture, Vector2 Pos, Rectangle fairySource)
        {
            texture = fairyTexture;
            this.destx = (int)Pos.X;
            this.desty = (int)Pos.Y;
            this.fairySource = fairySource;
            currentFrame = 1;
            totalFrames = 3;
            time = 0;
            srcRectangle = this.fairySource;
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
            int width = this.fairySource.Width;
            int height = this.fairySource.Height;
            return new Rectangle(destx, desty, width * 2, height * 2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (currentFrame == 1)
            {
                srcRectangle = this.fairySource;

            }
            else if (currentFrame == 2)
            {
                srcRectangle = ItemSpriteFactory.fairytwoSrc;
            }
            spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
        }
    }
}
