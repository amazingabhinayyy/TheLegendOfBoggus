﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sprint2_Attempt3.Link;
using System.Net.NetworkInformation;

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
        private SpriteEffects flip = SpriteEffects.None;
        private float rotate;
        private LinkDirection Direction;
        public Boomerang(Texture2D texture) 
        {
            this.texture = texture;
            sourceRectangle = new Rectangle(64, 185, 7, 15);
            currentFrame = 0;
        }

        public void Update(Link link)
        {
            if (currentFrame == 0)
            {
                Direction = link.Direction;
            }
            if (currentFrame == 120)
            {
                link.Items.Remove(this);
            }
            else if (currentFrame >= 0 && currentFrame < 120)
            {
                int speed;
                if (currentFrame >= 0 && currentFrame < 50)
                    speed = 3;
                else if (currentFrame >= 50 && currentFrame < 60)
                    speed = 1;
                else if (currentFrame >= 60 && currentFrame < 70)
                    speed = -1;
                else
                    speed = -3;
                switch (Direction)
                {
                    case Link.LinkDirection.Right:
                        xLoc += speed;
                        break;
                    case Link.LinkDirection.Left:
                        flip = SpriteEffects.FlipHorizontally;
                        xLoc -= speed;
                        break;
                    case Link.LinkDirection.Up:
                        yLoc -= speed;
                        rotate = MathHelper.ToRadians(270);
                        break;
                    case Link.LinkDirection.Down:
                        yLoc += speed;
                        rotate = MathHelper.ToRadians(90);
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
            else if (currentFrame % 40 >= 0 && currentFrame % 40 < 5)
            {
                sourceRectangle = new Rectangle(64, 185, 7, 15);
                flip = SpriteEffects.None;
            }
            else if (currentFrame % 40 >= 5 && currentFrame % 40 < 10)
            {
                sourceRectangle = new Rectangle(73, 185, 7, 15);
                flip = SpriteEffects.None;
            }
            else if (currentFrame % 40 >= 10 && currentFrame % 40 < 15)
            {
                sourceRectangle = new Rectangle(82, 185, 7, 15);
                flip = SpriteEffects.None;
            }
            else if (currentFrame % 40 >= 15 && currentFrame % 40 < 20)
            {
                sourceRectangle = new Rectangle(73, 185, 7, 15);
                flip = SpriteEffects.FlipHorizontally;
            }
            else if (currentFrame % 40 >= 20 && currentFrame % 40 < 25)
            {
                sourceRectangle = new Rectangle(64, 185, 7, 15);
                flip = SpriteEffects.FlipHorizontally;
            }
            else if (currentFrame % 40 >= 25 && currentFrame % 40 < 30)
            {
                //ToDo
                sourceRectangle = new Rectangle(140, 206, 7, 15);
                flip = SpriteEffects.None;
            }
            else if (currentFrame % 40 >= 30 && currentFrame % 40 < 35)
            {
                sourceRectangle = new Rectangle(82, 185, 7, 15);
                flip = SpriteEffects.FlipVertically;
            }
            else if (currentFrame % 40 >= 35 && currentFrame % 40 < 40)
            {
                sourceRectangle = new Rectangle(73, 185, 7, 15);
                flip = SpriteEffects.FlipVertically;
            }
            destinationRectangle = new Rectangle(xLoc, yLoc, 21, 45);
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, color, rotate, new Vector2(0), flip, 0);
            rotate = 0;
        }
    }
}

