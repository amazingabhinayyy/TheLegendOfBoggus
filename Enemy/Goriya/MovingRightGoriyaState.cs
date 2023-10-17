﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile.GoriyaProjectiles;
using System;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class MovingRightGoriyaState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private int elaspedFrameCount;
        private int endFrame;
        private Random random;
        private int direction;
        public MovingRightGoriyaState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            sprite = EnemySpriteFactory.Instance.CreateMovingRightGoriyaSprite();
            sourceRectangle = Globals.GoriyaRedRight;
            Goriya.Position = new Rectangle(Goriya.X, Goriya.Y, sourceRectangle.Width, sourceRectangle.Height);
            currentFrame = 0;
            elaspedFrameCount = 0;
            endFrame = 100;

        }
        public void ChangeDirection()
        {
            Goriya.BoomerangPosition = new Vector2(Goriya.X, Goriya.Y);
            Goriya.Boomerang = new GoriyaBoomerang(Goriya.BoomerangPosition);
            ((GoriyaBoomerang)Goriya.Boomerang).GenerateRight();
            ((GoriyaBoomerang)Goriya.Boomerang).Throwing = true;
            Goriya.State = new AttackWithBoomerangRightState(Goriya);
        }
        public void ChangeAttackedStatus() {
            Goriya.State = new MovingAttackedRightGoriyaState(Goriya);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame < 30)
            {
                if (currentFrame < 15)
                {
                    sourceRectangle = Globals.GoriyaRedRight;

                }
                else
                {
                    sourceRectangle = Globals.GoriyaRedRight2;

                }
                Goriya.X += 1;
                Goriya.Position = new Rectangle(Goriya.X, Goriya.Y, sourceRectangle.Width, sourceRectangle.Height);
            }
            else
            {
                currentFrame = 0;
            }
            elaspedFrameCount++;
            if (elaspedFrameCount >= endFrame)
            {
                ChangeDirection();
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Goriya.X, Goriya.Y, sourceRectangle);
        }
    }
}
