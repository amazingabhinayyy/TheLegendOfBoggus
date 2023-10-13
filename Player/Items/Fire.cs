using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using static Sprint2_Attempt3.Player.Link;
using Sprint2_Attempt3.Player;

namespace Sprint2_Attempt3.Player.Items
{
    public class Fire : IItemSprite
    {
        private int xLoc;
        private int yLoc;
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        private int currentFrame;
        private Texture2D texture;
        private SpriteEffects flip = SpriteEffects.None;
        private LinkDirection Direction;
        public Fire(Texture2D texture)
        {
            this.texture = texture;
            sourceRectangle = new Rectangle(191, 185, 15, 15);
            currentFrame = 0;
        }
        public void Update(Link link)
        {
            if (currentFrame == 0)
            {
                Direction = link.Direction;
            }
            if (currentFrame == 60)
            {
                link.Items.Remove(this);
            }
            else if (currentFrame >= 0 && currentFrame < 40)
            {
                switch (Direction)
                {
                    case LinkDirection.Right:
                        xLoc += 2;
                        break;
                    case LinkDirection.Left:
                        xLoc -= 2;
                        break;
                    case LinkDirection.Up:
                        yLoc -= 2;
                        break;
                    case LinkDirection.Down:
                        yLoc += 2;
                        break;
                }
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
            else if (currentFrame % 8 >= 0 && currentFrame % 8 < 4)
            {
                flip = SpriteEffects.None;
            }
            else
            {
                flip = SpriteEffects.FlipHorizontally;
            }
            destinationRectangle = new Rectangle(xLoc, yLoc, 45, 45);
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, color, 0, new Vector2(0), flip, 0);
        }
    }
}
