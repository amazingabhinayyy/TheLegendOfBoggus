using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Interfaces;
using Sprint2_Attempt3.Collision;

namespace Sprint2_Attempt3.Player.LinkProjectiles
{
    public class RightSword : ILinkProjectile
    {
        private Link link;
        private int currentFrame;
        private ILinkProjectileSprite sprite;
        private Vector2 itemPosition;
        private SpriteEffects flip;
        private Rectangle sourceRectangle;
        private int HitBoxWidth = 15;
        private int HitBoxHeight = 45;
        public RightSword(Link link)
        {
            this.link = link;
            currentFrame = 0;
            sprite = LinkSpriteFactory.Instance.CreateRightAttackLinkSwordSprite();
            SetPosition();
        }

        public void SetPosition()
        {
            itemPosition = new Vector2((int)link.position.X - 33, (int)link.position.Y + 24);
        }

        public void Update()
        {
            if (currentFrame == 30)
            {
                link.Items.Remove(this);
                CollisionDetector.GameObjectList.Remove(this);
            }
            if (currentFrame >= 7 && currentFrame < 15)
            {
                itemPosition.X = link.position.X + 45;
                itemPosition.Y = link.position.Y + 24;
                HitBoxWidth = 36;
                HitBoxHeight = 9;
            }
            else if (currentFrame >= 15 && currentFrame < 22)
            {
                itemPosition.X = link.position.X + 45;
                itemPosition.Y = link.position.Y + 24;
                HitBoxWidth = 27;
                HitBoxHeight = 9;
            }
            else if (currentFrame >= 22 && currentFrame < 30)
            {

                itemPosition.X = link.position.X + 45;
                itemPosition.Y = link.position.Y + 24;
                HitBoxWidth = 12;
                HitBoxHeight = 9;
            }
            else if (currentFrame >= 0 && currentFrame < 7)
            {

                itemPosition.X = link.position.X + 45;
                itemPosition.Y = link.position.Y + 24;
                HitBoxHeight = 0;
                HitBoxWidth = 0;
            }
            sprite.Update();
            currentFrame++;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, link.position, sourceRectangle, flip);
        }
        public Rectangle GetHitBox()
        {
            return new Rectangle((int)itemPosition.X, (int)itemPosition.Y, HitBoxWidth, HitBoxHeight);
        }

    }
}
