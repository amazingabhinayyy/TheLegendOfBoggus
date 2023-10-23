﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Interfaces;
using Sprint2_Attempt3.Collision;

namespace Sprint2_Attempt3.Player.LinkProjectiles
{
    public class LeftBoomerang : Boomerang, ILinkProjectile
    {
        private Link link;
        private int currentFrame;
        private ILinkProjectileSprite sprite;
        private Vector2 itemPosition;
        private SpriteEffects flip;
        private Rectangle sourceRectangle;
        private const int HitBoxWidth = 21;
        private const int HitBoxHeight = 21;
        public LeftBoomerang(Link link)
        {
            this.link = link;
            currentFrame = 0;
            sprite = LinkSpriteFactory.Instance.CreateBoomerangItem();
            SetPosition();
        }
        public void SetPosition()
        {
            itemPosition = new Vector2((int)link.position.X - 23, (int)link.position.Y + 12);
            flip = SpriteEffects.None;
            sourceRectangle = new Rectangle(64, 189, 7, 7);
        }

        public void Update()
        {
            int speed;
            if (currentFrame >= 0 && currentFrame < 50)
            {
                speed = 3;
                itemPosition.X = itemPosition.X - speed;
            }
            else if (currentFrame >= 50 && currentFrame < 60)
            {
                speed = 1;
                itemPosition.X = itemPosition.X - speed;
            }
            else if (currentFrame >= 60 && currentFrame < 70)
            {
                speed = -1;
                itemPosition.X = itemPosition.X - speed;
            }
            else
            {
                itemPosition = BoomerangPositionUpdater(itemPosition, link.position, 3);
            }
            sprite.Update();
            currentFrame++;

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