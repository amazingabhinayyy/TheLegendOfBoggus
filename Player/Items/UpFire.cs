﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Interfaces;

namespace Sprint2_Attempt3.Player.Items
{
    public class UpFire : ILinkItem
    {
        private Link link;
        private int currentFrame;
        private ILinkItemSprite sprite;
        private Vector2 itemPosition;
        private SpriteEffects flip;
        private Rectangle sourceRectangle;
        public UpFire(Link link)
        {
            this.link = link;
            currentFrame = 0;
            sprite = LinkSpriteFactory.Instance.CreateFireItem();
            SetPosition();
        }

        public void SetPosition()
        {
            itemPosition = new Vector2((int)link.position.X, (int)link.position.Y - 45);
            flip = SpriteEffects.None;
            sourceRectangle = new Rectangle(191, 185, 15, 15);
        }

        public void Update()
        {
            if (currentFrame == 60)
            {
                link.Items.Remove(this);
            }
            sprite.Update();
            currentFrame++;
            if (currentFrame < 40)
            {
                itemPosition.Y = itemPosition.Y - 2;
            }

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, itemPosition, sourceRectangle, flip);
        }

    }
}
