using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.Items
{
    public class RightArrow : ILinkItem
    {
        private Link link;
        private int currentFrame;
        private ILinkItemSprite sprite;
        private Vector2 itemPosition;
        private SpriteEffects flip;
        private Rectangle sourceRectangle;
        public RightArrow(Link link)
        {
            this.link = link;
            currentFrame = 0;
            sprite = LinkSpriteFactory.Instance.CreateArrowItem();
            SetPosition();
        }

        public void SetPosition()
        {
            itemPosition = new Vector2((int)link.position.X + 45, (int)link.position.Y + 15);
            flip = SpriteEffects.None;
            sourceRectangle = new Rectangle(10, 190, 15, 5);                   
        }

        public void Update()
        {
            if (currentFrame == 60)
            {
                link.Items.Remove(this);
            }
            sprite.Update();
            currentFrame++;
            itemPosition.X = itemPosition.X + 3;

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, itemPosition, sourceRectangle, flip);
        }

    }
}
