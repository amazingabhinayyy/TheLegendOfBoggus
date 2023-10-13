using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class HeartItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle heartSource;
        private int currentFrame;
        private int totalFrames;
        private int time;
        private Rectangle srcRectangle;
        public HeartItem(Texture2D heartTexture, Vector2 Pos, Rectangle heartSource)
        {
            texture = heartTexture;
            destx = (int)Pos.X;
            desty = (int)Pos.Y;
            this.heartSource = heartSource;
            currentFrame = 1;
            totalFrames = 3;
            time = 0;
            srcRectangle = this.heartSource;
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
            int width = heartSource.Width;
            int height = heartSource.Height;
            return new Rectangle(destx, desty, width * 2, height * 2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (currentFrame == 1)
            {
                srcRectangle = heartSource;

            }
            else if (currentFrame == 2)
            {
                srcRectangle = ItemSpriteFactory.blueheartSrc;
            }
            spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
        }
    }
}
