using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Interfaces;

namespace Sprint2_Attempt3.Player.Items
{
    public class DownArrow : ILinkItem
    {
        private Link link;
        private int currentFrame;
        private ILinkItemSprite sprite;
        private Vector2 itemPosition;
        private SpriteEffects flip;
        private Rectangle sourceRectangle;
        public DownArrow(Link link)
        {
            this.link = link;
            currentFrame = 0;
            sprite = LinkSpriteFactory.Instance.CreateArrowItem();
            SetPosition();
        }
        public Rectangle GetHitBox()
        {
            return new Rectangle(0, 0, 0, 0);
        }
        public void SetPosition()
        {
            itemPosition = new Vector2((int)link.position.X + 15, (int)link.position.Y + 45);
            flip = SpriteEffects.FlipVertically;
            sourceRectangle = new Rectangle(3, 185, 5, 15);                   
        }

        public void Update()
        {
            if (currentFrame == 60)
            {
                link.Items.Remove(this);
            }
            sprite.Update();
            currentFrame++;
            itemPosition.Y = itemPosition.Y + 3;

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, itemPosition, sourceRectangle, flip);
        }

    }
}
