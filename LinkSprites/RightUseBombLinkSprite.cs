using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.LinkSprites
{
    public class RightUseBombLinkSprite : ISprite
    {
        private Texture2D linkTexture;
        private Rectangle sourceRectangleLink;
        private Rectangle destinationRectangleLink;

        public RightUseBombLinkSprite(Texture2D linkTexture)
        {
            this.linkTexture = linkTexture;
            sourceRectangleLink = new Rectangle(124, 11, 15, 15);
        }

        public void Update()
        {
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {
            destinationRectangleLink = new Rectangle((int)location.X, (int)location.Y, 45, 45);

            spriteBatch.Draw(linkTexture, destinationRectangleLink, sourceRectangleLink, color);
        }
    }
}
