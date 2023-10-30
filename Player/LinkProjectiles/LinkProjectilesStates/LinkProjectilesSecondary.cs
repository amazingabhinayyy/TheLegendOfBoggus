using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates
{
    public abstract class LinkProjectilesSecondary : ILinkProjectile
    {
        protected Link link;
        protected int currentFrame;
        protected ILinkProjectileSprite sprite;
        protected ILinkProjectileSprite Sprite { set { sprite = value; } }
        protected Vector2 itemPosition;
        protected Vector2 ItemPosition { set { itemPosition = value; } }
        protected Rectangle sourceRectangle;
        protected Rectangle SourceRectangle { set { sourceRectangle = value; } }
        protected SpriteEffects flip;
        protected const int HitBoxWidth = 7;
        protected const int HitBoxHeight = 7;
        public LinkProjectilesSecondary(Link link)
        {
            this.link = link;
            currentFrame = 0;
            flip = SpriteEffects.None;
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
