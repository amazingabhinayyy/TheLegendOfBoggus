using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Items
{
    public class Arrow : IItemSprite
    {
        private int xLoc;
        private int yLoc;
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        private int currentFrame;
        private Texture2D texture;
        private SpriteEffects flip = SpriteEffects.None;
        private float rotate;
        public Arrow(Texture2D texture)
        {
            this.texture = texture;
            sourceRectangle = new Rectangle(10, 185, 15, 15);
            currentFrame = 0;
        }
        public void Update(Link link)
        {
            switch (link.Direction)
            {
                case Link.LinkDirection.Right:
                    xLoc += 2;
                    break;
                case Link.LinkDirection.Left:
                    flip = SpriteEffects.FlipHorizontally;
                    xLoc -= 2;
                    break;
                case Link.LinkDirection.Up:
                    yLoc -= 2;
                    rotate = MathHelper.ToRadians(270);
                    break;
                case Link.LinkDirection.Down:
                    yLoc += 2;
                    rotate = MathHelper.ToRadians(90);
                    break;
            }

            if (currentFrame == 60)
            {
                link.Items.Remove(this);
            }
            currentFrame++;

        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {
            if (currentFrame == 1)
            {
                xLoc = (int)location.X;
                yLoc = (int)location.Y;
            }
            else if (currentFrame < 55)
            {
                destinationRectangle = new Rectangle(xLoc, yLoc, 45, 45);
            }
            else
            {
                sourceRectangle = new Rectangle(53, 185, 7, 15);
                destinationRectangle = new Rectangle(xLoc, yLoc, 21, 45);
            }
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, color, rotate, new Vector2(0), flip, 0);
        }
    }
}
