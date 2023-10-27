using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Interfaces;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Player.LinkProjectiles
{
    public abstract class Boomerang : IBoomerang
    {
        protected bool changeDirection;
        protected Link link;
        protected int currentFrame;
        protected ILinkProjectileSprite sprite;
        protected ILinkProjectileSprite Sprite { set { sprite = value; } }
        protected Vector2 itemPosition;
        protected Vector2 ItemPosition { set { itemPosition = value; } } 
        protected SpriteEffects flip;
        protected Rectangle sourceRectangle;
        protected Rectangle SourceRectangle { set { sourceRectangle = value; } }
        protected const int HitBoxWidth = 7;
        protected const int HitBoxHeight = 7;

        public Boomerang(Link link) 
        { 
            this.link = link;
            changeDirection = false;
            currentFrame = 0;
            sprite = LinkSpriteFactory.Instance.CreateBlueBoomerangItem();
            flip = SpriteEffects.None;
        }
        public Vector2 BoomerangPositionUpdater(Vector2 itemPosition, Vector2 linkPosition, int speed)
        {
            Vector2 newItemPosition = itemPosition;
            Vector2 actualLinkPosition;
            //The center of link
            actualLinkPosition.X = linkPosition.X + 7;
            actualLinkPosition.Y = linkPosition.Y + 7;

            //Find the slope and yInt for vector pointing towards link from the boomerang
            float slope = (itemPosition.Y - actualLinkPosition.Y) / (itemPosition.X - actualLinkPosition.X);
            float yInt = itemPosition.Y - (slope * itemPosition.X);

            if (Math.Abs(itemPosition.X - actualLinkPosition.X) > Math.Abs(itemPosition.Y - actualLinkPosition.Y))
            {
                if (itemPosition.X > actualLinkPosition.X)
                {
                    newItemPosition.X -= speed;
                }
                else
                {
                    newItemPosition.X += speed;
                }
                newItemPosition.Y = slope * newItemPosition.X + yInt;
            }
            else
            {
                if (itemPosition.Y > actualLinkPosition.Y)
                {
                    newItemPosition.Y -= speed;
                }
                else
                {
                    newItemPosition.Y += speed;
                }
                newItemPosition.X = (newItemPosition.Y - yInt)/ slope;
            }
            return newItemPosition;
        }
        public void ReverseDirection()
        {
            if (!changeDirection)
            {
                link.Items.Add(new ItemHit(link, itemPosition));
                changeDirection = true;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, itemPosition, sourceRectangle, flip);
        }
        public Rectangle GetHitBox()
        {
            return new Rectangle((int)itemPosition.X, (int)itemPosition.Y, HitBoxWidth, HitBoxHeight);
        }
        public abstract void Update();
    }

}
