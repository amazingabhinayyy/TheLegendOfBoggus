﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Interfaces;

namespace Sprint2_Attempt3.Player.LinkSprites
{
    public class UpMovingLinkSprite : ILinkSprite
    {
        private Texture2D linkTexture;
        private int currentFrame;
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        public UpMovingLinkSprite(Texture2D linkTexture)
        {
            this.linkTexture = linkTexture;
            currentFrame = 0;
            sourceRectangle = new Rectangle(86, 11, 15, 15);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame >= 20)
            {
                currentFrame = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 45, 45);

            if (currentFrame >= 0 && currentFrame <= 10)
            {
                sourceRectangle = new Rectangle(86, 11, 15, 15);
            }
            else
            {
                sourceRectangle = new Rectangle(69, 11, 15, 15);
            }

            spriteBatch.Draw(linkTexture, destinationRectangle, sourceRectangle, color);
        }
    }
}