using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles;
using System;

namespace Sprint2_Attempt3.Enemy.Aquamentus
{
    internal class AttackWithFireballRightState : IEnemyState
    {
        private Aquamentus Aquamentus;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private Rectangle[] sourceRectangles = { Globals.AquamentusGreenLeftMouthOpen, Globals.AquamentusGreenLeftMouthOpen2 };
        private int currentFrame;
        private int currentFireballFrame;
        private IEnemyProjectile fireball;
        private IEnemyProjectile fireball2;
        private IEnemyProjectile fireball3;
        private int elapsedFrameCount;
        private int endFrame;
        public AttackWithFireballRightState(Aquamentus Aquamentus)
        {
            this.Aquamentus = Aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateMovingRightAquamentusSprite();
            currentFrame = 0;
            currentFireballFrame = 0;
            sourceRectangle = Globals.AquamentusGreenLeftMouthOpen;
            Aquamentus.Position = new Rectangle(Aquamentus.X, Aquamentus.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            fireball = Aquamentus.Fireball;
            fireball2 = Aquamentus.Fireball2;
            fireball3 = Aquamentus.Fireball3;
            elapsedFrameCount = 0;
            endFrame = 10;

        }
        public void ChangeDirection()
        {            
                Aquamentus.State = new MovingLeftAquamentusState(Aquamentus);                
        }
        public void ChangeAttackedStatus() {
            Aquamentus.State = new MovingAttackedRightAquamentusState(Aquamentus);
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
            if (elapsedFrameCount >= endFrame * 1.2)
            {
                ChangeDirection();
            }
            if (elapsedFrameCount >= endFrame)
            {
            ((AquamentusFireball)fireball).Fire = true;
            ((AquamentusFireball)fireball2).Fire = true;
            ((AquamentusFireball)fireball3).Fire = true;
                sourceRectangles[0] = Globals.AquamentusGreenLeft;
                sourceRectangles[1] = Globals.AquamentusGreenLeft2;

            }
            Aquamentus.Position = new Rectangle(Aquamentus.X, Aquamentus.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Aquamentus.X, Aquamentus.Y, sourceRectangle);
            
        }
    }
}
