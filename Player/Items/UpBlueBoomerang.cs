using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.Items
{
    public class UpBlueBoomerang : ILinkItem
    {
        private Link link;
        private int currentFrame;
        private ILinkItemSprite sprite;
        private Vector2 itemPosition;
        private SpriteEffects flip;
        private Rectangle sourceRectangle;
        public UpBlueBoomerang(Link link)
        {
            this.link = link;
            currentFrame = 0;
            sprite = LinkSpriteFactory.Instance.CreateBlueBoomerangItem();
            SetPosition();
        }

        public void SetPosition()
        {
            itemPosition = new Vector2((int)link.position.X + 12, (int)link.position.Y - 23);
            flip = SpriteEffects.None;
            sourceRectangle = new Rectangle(91, 189, 7, 7);
        }

        public void Update()
        {
            if (currentFrame == 120)
            {
                link.Items.Remove(this);
            }

            int speed;
            if (currentFrame >= 0 && currentFrame < 50)
                speed = 5;
            else if (currentFrame >= 50 && currentFrame < 60)
                speed = 2;
            else if (currentFrame >= 60 && currentFrame < 70)
                speed = -2;
            else
                speed = -5;

            sprite.Update();
            currentFrame++;
            itemPosition.Y = itemPosition.Y - speed;

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, itemPosition, sourceRectangle, flip);
        }

    }
}