﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Projectile;
using Sprint2_Attempt3.Projectile.GoriyaProjectiles;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class AttackWithBoomerangDownState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private int currentBoomerangFrame;
        private IEnemyProjectile boomerang;
       
        public AttackWithBoomerangDownState(Goriya Goriya)
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
                Goriya.State = new MovingLeftGoriyaState(Goriya);
        }
        public void ChangeAttackedStatus() {
            Goriya.State = new MovingAttackedLeftGoriyaState(Goriya);
        }
        public void Update()
        {
            
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