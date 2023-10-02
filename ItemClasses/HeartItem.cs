using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sprint2_Attempt3.ItemClasses
{
    internal class HeartItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle heartSource;
        private int currentFrame;
        private int totalFrames;
        private int time;
        public HeartItem(Texture2D heartTexture, Vector2 Pos, Rectangle heartSource)
        {
            texture = heartTexture;
            this.destx = (int)Pos.X;
            this.desty = (int)Pos.Y;
            this.heartSource = heartSource;
            currentFrame = 1;
            totalFrames = 2;
            time = 0;
        }

        public void Update()
        {
            if (time % 15 == 0)
            {
                currentFrame++;
                if (currentFrame == totalFrames)
                {
                    currentFrame = 0;
                }
            }
            time++;
        }

        public Rectangle DestRectangle()
        {
            int width = this.heartSource.Width;
            int height = this.heartSource.Height;
            return new Rectangle(destx, desty, width * 2, height * 2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = this.heartSource;
            if (currentFrame == 1)
            {
                srcRectangle = this.heartSource;
            }
            else if (currentFrame == 2)
            {
                srcRectangle = ItemSpriteFactory.blueheartSrc;
                Debug.WriteLine("test");
            }
            spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
        }
    }
}
