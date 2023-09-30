﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.LinkSprites
{
    public class DownMovingLinkSprite : ISprite
    {
        private Texture2D linkTexture;
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        private int currentFrame;
        public DownMovingLinkSprite(Texture2D linkTexture)
        {
            this.linkTexture = linkTexture;
            sourceRectangle = new Rectangle(1, 11, 15, 15);
            currentFrame = 0;
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == 20)
            {
                currentFrame = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 45, 45);

            if (currentFrame >= 0 && currentFrame <= 10)
            {
                sourceRectangle = new Rectangle(1, 11, 15, 15);
            }
            else
            {
                sourceRectangle = new Rectangle(18, 11, 15, 15);
            }


            spriteBatch.Draw(linkTexture, destinationRectangle, sourceRectangle, color);

        }
    }
}
