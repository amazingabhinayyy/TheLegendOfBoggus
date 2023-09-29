using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.LinkSprites
{
    public class UpUseBombLinkSprite : ISprite
    {
        private Texture2D linkTexture;
        private Rectangle sourceRectangleLink;
        private Rectangle destinationRectangleLink;

        public UpUseBombLinkSprite(Texture2D linkTexture)
        {
            this.linkTexture = linkTexture;
            sourceRectangleLink = new Rectangle(106, 10, 17, 16);
        }

        public void Update()
        {
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {
            destinationRectangleLink = new Rectangle((int)location.X, (int)location.Y, 51, 48);

            spriteBatch.Draw(linkTexture, destinationRectangleLink, sourceRectangleLink, color);
        }
    }
}

