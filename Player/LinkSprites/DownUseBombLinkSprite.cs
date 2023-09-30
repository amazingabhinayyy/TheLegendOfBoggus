using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.LinkSprites
{
    public class DownUseBombLinkSprite : ISprite
    {
        private Texture2D linkTexture;
        private Rectangle sourceRectangleLink;
        private Rectangle destinationRectangleLink;

        public DownUseBombLinkSprite(Texture2D linkTexture)
        {
            this.linkTexture = linkTexture;
            sourceRectangleLink = new Rectangle(106, 10, 15, 15);
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
