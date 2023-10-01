using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Items
{
    public class Boomerang : IItemSprite
    {
        private int xLoc;
        private int yLoc;
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        private int currentFrame;
        private Texture2D texture;
        public Boomerang(Texture2D texture) 
        {
            this.texture = texture;
            sourceRectangle = new Rectangle(64, 185, 7, 15);
            currentFrame = 0;
        }

        public void Update(Link link)
        {
            currentFrame++;
            if (currentFrame == 60)
            {
                link.Items.Remove(this);
            }
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {

        }
    }
}
