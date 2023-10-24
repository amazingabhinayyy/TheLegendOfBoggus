using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using static Sprint2_Attempt3.Player.Link;
using Sprint2_Attempt3.Interfaces;
using Sprint2_Attempt3.Collision;

namespace Sprint2_Attempt3.Player.LinkProjectiles
{
    public class RightBomb : IBomb, ILinkProjectile
    {
        private Link link;
        private int currentFrame;
        private ILinkProjectileSprite sprite;
        private Vector2 itemPosition;
        private Rectangle sourceRectangle;
        private SpriteEffects flip;
        private const int HitBoxWidth = 24;
        private const int HitBoxHeight = 45;
        public RightBomb(Link link)
        {
            this.link = link;
            currentFrame = 0;
            sprite = LinkSpriteFactory.Instance.CreateBombItem();
            SetPosition();
        }

        public void SetPosition()
        {
            itemPosition = new Vector2((int)link.position.X + 45, (int)link.position.Y + 11);
            sourceRectangle = new Rectangle(129, 185, 8, 15);
            flip = SpriteEffects.None;
        }
        public void RemoveBomb()
        {
            link.Items.Remove(this);
            CollisionDetector.GameObjectList.Remove(this);
        }
        public void Explode()
        {
            RemoveBomb();
            BombExplosion explosion = new BombExplosion(link, itemPosition);
            link.Items.Add(explosion);
            CollisionDetector.GameObjectList.Add(explosion);
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == 50)
            {
                Explode();
            }
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, itemPosition, sourceRectangle, flip);
        }
        public Rectangle GetHitBox()
        {
            return new Rectangle((int)itemPosition.X, (int)itemPosition.Y, HitBoxWidth, HitBoxHeight);
        }
    }
}
