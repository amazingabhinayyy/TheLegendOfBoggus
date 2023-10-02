﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Projectile;

namespace Sprint2_Attempt3.Enemy.Aquamentus
{
    internal class AttackWithBoomerangLeftState : IEnemyState
    {
        private Aquamentus Aquamentus;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private int currentBoomerangFrame;
        private IEnemyProjectile boomerang;
       
        public AttackWithBoomerangLeftState(Aquamentus Aquamentus)
        {
            this.Aquamentus = Aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftAquamentusSprite();
            currentFrame = 0;
            currentBoomerangFrame = 0;
            sourceRectangle = Globals.AquamentusRedRight;
            boomerang = Aquamentus.Boomerang;
         

        }
        public void ChangeDirection()
        {
            if (Aquamentus.end)
            {
                Aquamentus.State = new MovingUpAquamentusState(Aquamentus);
                Aquamentus.end = false;
            }
        }
        public void ChangeAttackedStatus() {
            Aquamentus.State = new MovingAttackedLeftAquamentusState(Aquamentus);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame < 30)
            {
                if (currentFrame < 15)
                {
                    sourceRectangle = Globals.AquamentusRedRight;

                }
                else
                {
                    sourceRectangle = Globals.AquamentusRedRight2;

                }
               
            }
            else
            {
                currentFrame = 0;
            }
            
            boomerang.Update();


        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Aquamentus.X, Aquamentus.Y, sourceRectangle);
            boomerang.Draw(spriteBatch);
        }
    }
}
