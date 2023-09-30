using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.LinkSprites
{
    public class LeftAttackLinkSprite : ISprite
    {
        private Texture2D linkTexture;
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        private int currentFrame;
        public LeftAttackLinkSprite(Texture2D linkTexture)
        {
            this.linkTexture = linkTexture;
            currentFrame = 0;
            //Need to figure out how to make link face left
            sourceRectangle = new Rectangle(1, 76, 15, 15);
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
                sourceRectangle = new Rectangle(18, 77, 15, 15);
            }
            else if (currentFrame >= 30 && currentFrame < 45)
            {
                sourceRectangle = new Rectangle(47, 77, 15, 15);
            }
            else if (currentFrame >= 45 && currentFrame < 60)
            {
                sourceRectangle = new Rectangle(70, 77, 15, 15);
            }
            else if (currentFrame >= 0 && currentFrame < 15)
            {
                sourceRectangle = new Rectangle(1, 77, 15, 15);
            }

            spritebatch.Draw(linkTexture, destinationRectangle, sourceRectangle, Color.White, 0, new Vector2(0), SpriteEffects.FlipHorizontally, 0);
        }
    }
}
