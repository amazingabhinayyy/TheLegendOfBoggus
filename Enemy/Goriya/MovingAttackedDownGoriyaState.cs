﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Projectile.GoriyaProjectiles;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class MovingAttackedDownGoriyaState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private int elaspedFrameCount;
        private int endFrame;
        public MovingAttackedDownGoriyaState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            sprite = EnemySpriteFactory.Instance.CreateMovingDownGoriyaSprite();
            sourceRectangle = Globals.GoriyaRedDown;
            currentFrame = 0;
            elaspedFrameCount = 0;
            endFrame = 100;
        }
        public void ChangeDirection()
        {
            Goriya.BoomerangPosition = new Vector2(Goriya.X, Goriya.Y);
            Goriya.Boomerang = new GoriyaBoomerang(Goriya.BoomerangPosition);
            ((GoriyaBoomerang)Goriya.Boomerang).GenerateDown();
            ((GoriyaBoomerang)Goriya.Boomerang).Throwing = true;
            Goriya.State = new DamagedAttackWithBoomerangDownState(Goriya);
        }
        public void ChangeAttackedStatus() {
            Goriya.State = new MovingDownGoriyaState(Goriya);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame <= 20)
            {
                if (currentFrame == 5)
                {
                    sourceRectangle = Globals.GoriyaGreenDown;
                }
                else if (currentFrame == 10)
                {
                    sourceRectangle = Globals.GoriyaTealDown;
                }
                else if (currentFrame == 15)
                {
                    sourceRectangle = Globals.GoriyaRedDown;
                }
                else if (currentFrame == 20)
                {
                    sourceRectangle = Globals.GoriyaBlueDown;
                }
            }
            else
            {
                currentFrame = 0;
            }
            Goriya.Y += 1;
            sprite.Update();
            elaspedFrameCount++;
            if (elaspedFrameCount >= endFrame)
            {
                ChangeDirection();
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Goriya.X, Goriya.Y, sourceRectangle) ;
        }
    }
}