using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Player.Interfaces;

namespace Sprint2_Attempt3.Player.LinkSprites
{
    public class DownAttackLinkSwordSprite : ILinkItemSprite
    {
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        private int currentFrame;
        private Texture2D linkTexture;
        public DownAttackLinkSwordSprite(Texture2D linkTexture)
        {
            this.linkTexture = linkTexture;
            sourceRectangle = new Rectangle(1, 47, 15, 15);
            currentFrame = 0;
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame >= 30)
            {
                currentFrame = 0;
            }
        }
        public void Draw(SpriteBatch spritebatch, Vector2 location, Rectangle srcRec, SpriteEffects flip)
        {
            //+7 x, +16 y
            destinationRectangle = new Rectangle((int)location.X + 21, (int)location.Y + 45, 15, 15);

            if (currentFrame >= 7 && currentFrame < 15)
            {
                destinationRectangle = new Rectangle((int)location.X + 21, (int)location.Y + 45, 9, 33);
                sourceRectangle = new Rectangle(25, 63, 3, 11);
            }
            else if (currentFrame >= 15 && currentFrame < 22)
            {
                destinationRectangle = new Rectangle((int)location.X + 21, (int)location.Y + 45, 9, 21);
                sourceRectangle = new Rectangle(42, 63, 3, 7);
            }
            else if (currentFrame >= 22 && currentFrame < 30)
            {
                destinationRectangle = new Rectangle((int)location.X + 21, (int)location.Y + 45, 9, 9);
                sourceRectangle = new Rectangle(59, 63, 3, 3);
            }
            else if (currentFrame >= 0 && currentFrame < 7)
            {
                destinationRectangle = new Rectangle((int)location.X + 21, (int)location.Y + 45, 0, 0);
                sourceRectangle = new Rectangle(8, 63, 0, 0);
            }

            spritebatch.Draw(linkTexture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
