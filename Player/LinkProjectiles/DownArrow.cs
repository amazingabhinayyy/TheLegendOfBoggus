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
    public class DownArrow : ILinkProjectile, IArrow
    {
        private Link link;
        private int currentFrame;
        private ILinkProjectileSprite sprite;
        private Vector2 itemPosition;
        private SpriteEffects flip;
        private Rectangle sourceRectangle;
        private const int HitBoxWidth = 15;
        private const int HitBoxHeight = 45;
        public DownArrow(Link link)
        {
            this.link = link;
            currentFrame = 0;
            sprite = LinkSpriteFactory.Instance.CreateArrowItem();
            SetPosition();
        }
        public void DestroyArrow()
        {
            link.Items.Remove(this);
            link.Items.Add(new ItemHit(link, itemPosition));
            CollisionDetector.GameObjectList.Remove(this);
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
                DestroyArrow();
            }
            sprite.Update();
            currentFrame++;
            itemPosition.Y = itemPosition.Y + 3;

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