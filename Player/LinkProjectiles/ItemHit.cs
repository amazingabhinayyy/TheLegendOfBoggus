using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Interfaces;
using System.ComponentModel;

namespace Sprint2_Attempt3.Player.LinkProjectiles
{
    public class ItemHit: ILinkProjectile
    {
        private Link link;
        private Vector2 itemPosition;
        private int currentFrame;
        private Rectangle sourceRectangle;
        private SpriteEffects flip;
        private ILinkProjectileSprite sprite;
        public ItemHit(Link link, Vector2 itemPosition) 
        {
            this.link = link;
            this.itemPosition = itemPosition;
            currentFrame = 0;
            sourceRectangle = new Rectangle(118, 185, 7, 15);
            flip = SpriteEffects.None;
            sprite = LinkSpriteFactory.Instance.CreateItemHitSprite();
        }
        public void Update()
        {
            if(currentFrame == 5)
            {
                link.Items.Remove(this);
            }
            currentFrame++;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, itemPosition, sourceRectangle, flip);
        }
        public Rectangle GetHitBox()
        {
            //Doesn't have a hit box
            return new Rectangle(0, 0, 0, 0);
        }

    }
}
