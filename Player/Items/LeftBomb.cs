using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using static Sprint2_Attempt3.Player.Link;

namespace Sprint2_Attempt3.Player.Items
{
    public class LeftBomb : ILinkItem
    {
        private Link link;
        private int currentFrame;
        private ILinkItemSprite sprite;
        private Vector2 itemPosition;
        private Rectangle sourceRectangle;
        private SpriteEffects flip;
        public LeftBomb(Link link)
        {
            this.link = link;
            currentFrame = 0;
            sprite = LinkSpriteFactory.Instance.CreateBombItem();
            SetPosition();
        }

        public void SetPosition()
        {
            itemPosition = new Vector2((int)link.position.X - 24, (int)link.position.Y + 11);
            sourceRectangle = new Rectangle(129, 185, 8, 15);
            flip = SpriteEffects.None;
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == 60)
            {
                link.Items.Remove(this);
            }
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, itemPosition, sourceRectangle, flip);
        }

    }
}
