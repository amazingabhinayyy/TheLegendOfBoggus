﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Enemy.Projectile.GoriyaProjectiles;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class DamagedAttackWithBoomerangDownState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private int currentBoomerangFrame;
        private IEnemyProjectile boomerang;
       
        public DamagedAttackWithBoomerangDownState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            sprite = EnemySpriteFactory.Instance.CreateMovingDownGoriyaSprite();
            currentFrame = 0;
            currentBoomerangFrame = 0;
            sourceRectangle = Globals.GoriyaRedDown;
            boomerang = Goriya.Boomerang;
         

        }
        public void ChangeDirection()
        {
                Goriya.State = new MovingAttackedLeftGoriyaState(Goriya);
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
            sprite.Update();
            if (!((GoriyaBoomerang)Goriya.Boomerang).Throwing)
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
