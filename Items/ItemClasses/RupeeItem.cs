using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class RupeeItem : IJustItemSprite
    {
        private Texture2D rupeeTexture;
        public int destx, desty;
        public Rectangle rupeeSource;
        private int currentFrame;
        private int totalFrames;
        private int time;
        private Rectangle srcRectangle;
        public bool isCollected { get; private set; } = false;

        public RupeeItem(Texture2D rupeeTexture, Vector2 Pos, Rectangle rupeeSource)
        {
            this.rupeeTexture = rupeeTexture;
            destx = (int)Pos.X;
            desty = (int)Pos.Y;
            this.rupeeSource = rupeeSource;
            currentFrame = 1;
            totalFrames = 3;
            time = 0;
            srcRectangle = this.rupeeSource;
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
        public void Spawn()
        {
            //Draw()
        }
        public void Collected()
        {
            isCollected = true;
        }
        public Rectangle DestRectangle()
        {
            int width = rupeeSource.Width;
            int height = rupeeSource.Height;
            return new Rectangle(destx, desty, width * 2, height * 2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (currentFrame == 1)
            {
                srcRectangle = rupeeSource;

            }
            else if (currentFrame == 2)
            {
                srcRectangle = ItemSpriteFactory.bluerupeeSrc;
            }
            if (!isCollected)
            {
                spriteBatch.Draw(rupeeTexture, DestRectangle(), srcRectangle, Color.White);
            }
        }
    }
}
