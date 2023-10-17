using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles;
using System;
using System.Timers;

namespace Sprint2_Attempt3.Enemy.Aquamentus
{
    internal class AttackWithFireballLeftState : IEnemyState
    {
        private Aquamentus Aquamentus;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private Rectangle[] sourceRectangles = { Globals.AquamentusGreenLeftMouthOpen, Globals.AquamentusGreenLeftMouthOpen2 };
        private int currentFrame;
        private int currentFireballFrame;
        private IEnemyProjectile fireball;
        private int elapsedFrameCount;
        private int endFrame;
        public AttackWithFireballLeftState(Aquamentus Aquamentus)
        {
            this.Aquamentus = Aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftAquamentusSprite();
            currentFrame = 0;
            currentFireballFrame = 0;
            sourceRectangle = Globals.AquamentusGreenLeftMouthOpen;
            fireball = Aquamentus.Fireball;
            
            elapsedFrameCount = 0;
            endFrame = 10;
         

        }
        public void ChangeDirection()
        {
            Aquamentus.State = new MovingRightAquamentusState(Aquamentus);
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
                    sourceRectangle = sourceRectangles[0];

                }
                else
                {
                    sourceRectangle = sourceRectangles[1];

                }
               
            }
            else
            {
                currentFrame = 0;
            }
            elapsedFrameCount++;
            if (elapsedFrameCount >= endFrame *1.2)
            {
                ChangeDirection();
            }
            if (elapsedFrameCount >= endFrame)
            {
                ((AquamentusFireball)fireball).Fire = true;
                sourceRectangles[0] = Globals.AquamentusGreenLeft;
                sourceRectangles[1] = Globals.AquamentusGreenLeft2;

            }


        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Aquamentus.X, Aquamentus.Y, sourceRectangle);
          
        }
    }
}
