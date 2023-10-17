using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Interfaces;
using Sprint2_Attempt3.Collision;

namespace Sprint2_Attempt3.Player.Items
{
    public class DownSword : ILinkItem
    {
        private Link link;
        private int currentFrame;
        private ILinkItemSprite sprite;
        private Vector2 itemPosition;
        private SpriteEffects flip;
        private Rectangle sourceRectangle;
        private int HitBoxWidth = 15;
        private int HitBoxHeight = 45;
        public DownSword(Link link)
        {
            this.link = link;
            currentFrame = 0;
            sprite = LinkSpriteFactory.Instance.CreateDownAttackLinkSwordSprite();
            SetPosition();
        }

        public void SetPosition()
        {
            itemPosition = new Vector2((int)link.position.X + 21, (int)link.position.Y + 45);
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
                HitBoxWidth = 9;
                HitBoxHeight = 33;
            }
            else if (currentFrame >= 15 && currentFrame < 22)
            {
                HitBoxWidth = 9;
                HitBoxHeight = 21;
            }
            else if (currentFrame >= 22 && currentFrame < 30)
            {
                HitBoxWidth = 9;
                HitBoxHeight = 9;
            }
            else if (currentFrame >= 0 && currentFrame < 7)
            {
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
