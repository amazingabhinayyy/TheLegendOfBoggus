using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Text;
using System.Threading.Tasks;


namespace Sprint2_Attempt3
{
    public class BombSprite : IItemSprite
    {
        private int xLoc;
        private int yLoc;
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        private int currentFrame;
        private Texture2D texture;
        public BombSprite(Texture2D texture) 
        {
            this.texture = texture;
            sourceRectangle = new Rectangle(129, 185, 8, 15);
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
            if(currentFrame == 1)
            {
                xLoc = (int)location.X;
                yLoc = (int)location.Y;
            }
            if (currentFrame >= 0 && currentFrame < 50)
            {
                destinationRectangle = new Rectangle(xLoc + 12, yLoc, 24, 45);
            }
            else if (currentFrame >= 50 && currentFrame < 54)
            {
                sourceRectangle = new Rectangle(138, 185, 15, 15);
                destinationRectangle = new Rectangle(xLoc, yLoc, 45, 45);
            }
            else if (currentFrame >= 54 && currentFrame < 57)
            {
                sourceRectangle = new Rectangle(155, 185, 15, 15); ;
            }
            else
            {
                sourceRectangle = new Rectangle(172, 185, 15, 15);
            }
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, color);
        }
    }
}
