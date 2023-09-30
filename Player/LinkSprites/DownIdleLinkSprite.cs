using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.LinkSprites
{
    public class DownIdleLinkSprite : ISprite
    {
        private Link link;
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        private int currentFrame;
        private Texture2D linkTexture;
        public DownIdleLinkSprite(Texture2D linkTexture)
        {
            sourceRectangle = new Rectangle(1, 11, 15, 15);
            currentFrame = 0;
            this.linkTexture = linkTexture;
        }

        public void Update()
        {
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 45, 45);
            spriteBatch.Draw(linkTexture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
