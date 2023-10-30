using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Interfaces;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Player.LinkProjectiles.ProjectileInterfaces;


namespace Sprint2_Attempt3.Player.LinkProjectiles
{
    public class DownFire : IFire
    {
        private Link link;
        private int currentFrame;
        private ILinkProjectileSprite sprite;
        private Vector2 itemPosition;
        private SpriteEffects flip;
        private Rectangle sourceRectangle;
        private const int HitBoxWidth = 45;
        private const int HitBoxHeight = 45;
        private bool stop;
        public DownFire(Link link)
        {
            this.link = link;
            currentFrame = 0;
            sprite = LinkSpriteFactory.Instance.CreateFireItem();
            SetPosition();
        }

        public void SetPosition()
        {
            itemPosition = new Vector2((int)link.position.X, (int)link.position.Y + 45);
            flip = SpriteEffects.None;
            sourceRectangle = new Rectangle(191, 185, 15, 15);
        }
        public void Stop()
        {
            stop = true;
        }

        public void Update()
        {
            if (currentFrame == 60)
            {
                link.Items.Remove(this);
                CollisionDetector.GameObjectList.Remove(this);
            }
            sprite.Update();
            currentFrame++;
            if (!stop &&currentFrame < 40)
            {
                itemPosition.Y = itemPosition.Y + 2;
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
    }
}
