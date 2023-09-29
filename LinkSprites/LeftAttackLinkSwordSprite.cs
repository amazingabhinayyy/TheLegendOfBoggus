﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3
{
    public class LeftAttackLinkSwordSprite : ISprite
    {
        private Link link;
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        private int currentFrame;
        private Texture2D linkTexture;
        public LeftAttackLinkSwordSprite(Texture2D linkTexture)
        {
            this.linkTexture = linkTexture;
            sourceRectangle = new Rectangle(1, 47, 15, 15);
            currentFrame = 0;
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame >= 60)
            {
                currentFrame = 0;
            }
        }
        public void Draw(SpriteBatch spritebatch, Vector2 location, Color color)
        {
            //+16 x, +8 y
            destinationRectangle = new Rectangle(((int)location.X +-15), ((int)location.Y + 24), 15, 15);

            if (currentFrame >= 15 && currentFrame < 30)
            {
                destinationRectangle = new Rectangle(((int)location.X-33), ((int)location.Y + 24), 33, 9);
                sourceRectangle = new Rectangle(34, 85, 11, 3);
            }
            else if (currentFrame >= 30 && currentFrame < 45)
            {
                destinationRectangle = new Rectangle(((int)location.X-21), ((int)location.Y + 24), 21, 9);
                sourceRectangle = new Rectangle(60, 85, 7, 3);
            }
            else if (currentFrame >= 45 && currentFrame < 60)
            {
                destinationRectangle = new Rectangle(((int)location.X-9), ((int)location.Y + 24), 9, 9);
                sourceRectangle = new Rectangle(85, 85, 3, 3);
            }
            else if (currentFrame >= 0 && currentFrame < 15)
            {
                destinationRectangle = new Rectangle(((int)location.X), ((int)location.Y + 24), 0, 0);
                sourceRectangle = new Rectangle(1, 47, 0, 0);
            }

            spritebatch.Draw(linkTexture, destinationRectangle, sourceRectangle, Color.White, 0, new Vector2(0), SpriteEffects.FlipHorizontally, 0);
        }
    }
}
