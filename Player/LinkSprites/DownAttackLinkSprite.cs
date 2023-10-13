using Sprint2_Attempt3.Player;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Player.LinkSprites
{
    public class DownAttackLinkSprite : ISprite
    {
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
        }
        public void Draw(SpriteBatch spritebatch, Vector2 location, Color color)
        {
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 45, 45);

            if (currentFrame >= 7 && currentFrame < 15)
            {
                sourceRectangle = new Rectangle(18, 47, 15, 15);
            }
            else if (currentFrame >= 15 && currentFrame < 22)
            {
                sourceRectangle = new Rectangle(35, 47, 15, 15);
            }
            else if (currentFrame >= 22 && currentFrame < 30)
            {
                sourceRectangle = new Rectangle(52, 47, 15, 15);
            }
            else if (currentFrame >= 0 && currentFrame < 7)
            {
                sourceRectangle = new Rectangle(1, 47, 15, 15);
            }

            spritebatch.Draw(linkTexture, destinationRectangle, sourceRectangle, color);
        }
    }
}
