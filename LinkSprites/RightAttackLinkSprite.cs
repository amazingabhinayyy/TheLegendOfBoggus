using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.LinkSprites
{
    public class RightAttackLinkSprite : ISprite
    {
        private Texture2D linkTexture;
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        private int currentFrame;
        public RightAttackLinkSprite(Texture2D linkTexture)
        {
            this.linkTexture = linkTexture;
            sourceRectangle = new Rectangle(1, 77, 15, 15);
            currentFrame = 0;

        }
        public void Update()
        {
            currentFrame++;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 45, 48);

            if (currentFrame >= 7 && currentFrame < 15)
            {
                sourceRectangle = new Rectangle(18, 77, 15, 16);
            }
            else if (currentFrame >= 15 && currentFrame < 22)
            {
                sourceRectangle = new Rectangle(46, 77, 15, 16);
            }
            else if (currentFrame >= 22 && currentFrame < 30)
            {
                sourceRectangle = new Rectangle(70, 77, 15, 16);
            }
            else if (currentFrame >= 0 && currentFrame < 7)
            {
                sourceRectangle = new Rectangle(1, 77, 15, 16);
            }

            spriteBatch.Draw(linkTexture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
