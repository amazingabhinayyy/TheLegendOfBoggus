using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3
{
    public class DownAttackLinkSprite : ISprite
    {
        private Link link;
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        private int currentFrame;
        private Texture2D linkTexture;
        public DownAttackLinkSprite(Texture2D linkTexture)
        {
            this.linkTexture = linkTexture;
            sourceRectangle = new Rectangle(1, 47, 15, 15);
            currentFrame = 0;
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == 60)
            {
                currentFrame = 0;
            }
        }
        public void Draw(SpriteBatch spritebatch, Vector2 location, Color color)
        {
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 45, 45);

            if (currentFrame >= 15 && currentFrame < 30)
            {
                sourceRectangle = new Rectangle(18, 47, 15, 15);
            }
            else if (currentFrame >= 30 && currentFrame < 45)
            {
                sourceRectangle = new Rectangle(35, 47, 15, 15);
            }
            else if (currentFrame >= 45 && currentFrame < 60)
            {
                sourceRectangle = new Rectangle(52, 47, 15, 15);
            }
            else if (currentFrame >= 0 && currentFrame < 15)
            {
                sourceRectangle = new Rectangle(1, 47, 15, 15);
            }

            spritebatch.Draw(linkTexture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
