﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile.GoriyaProjectiles;
using System;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class MovingLeftGoriyaState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private int elaspedFrameCount;
        private int endFrame;
        private Random random;
        private int direction;
        public MovingLeftGoriyaState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftGoriyaSprite();
            currentFrame = 0;
            sourceRectangle = Globals.GoriyaRedRight;
            Goriya.Position = new Rectangle(Goriya.X, Goriya.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            this.Goriya.Direction = Goriya.ProjectileDirection.Left;
            elaspedFrameCount = 0;
            endFrame = 100;

        }
        public void ChangeDirection()
        {
            Goriya.BoomerangPosition = new Vector2(Goriya.X, Goriya.Y);
            Goriya.Boomerang = new GoriyaBoomerang(Goriya.BoomerangPosition);
            ((GoriyaBoomerang)Goriya.Boomerang).GenerateLeft();
            ((GoriyaBoomerang)Goriya.Boomerang).Throwing = true;
            Goriya.State = new AttackWithBoomerangLeftState(Goriya);
        }
        public void ChangeAttackedStatus() {
            Goriya.State = new MovingAttackedLeftGoriyaState(Goriya);
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
                Goriya.X -= 1;
                Goriya.Position = new Rectangle(Goriya.X, Goriya.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
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
