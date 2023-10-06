using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Projectile;
using Sprint2_Attempt3.Projectile.AquamentusProjectiles;

namespace Sprint2_Attempt3.Enemy.Aquamentus
{
    internal class AttackedAttackWithFireballRightState : IEnemyState
    {
        private Aquamentus Aquamentus;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private int currentFireballFrame;
        private IEnemyProjectile fireball;
        private int elapsedFrameCount;
        private int endFrame;
        public AttackedAttackWithFireballRightState(Aquamentus Aquamentus)
        {
            this.Aquamentus = Aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateMovingRightAquamentusSprite();
            currentFrame = 0;
            currentFireballFrame = 0;
            sourceRectangle = Globals.AquamentusGreenLeftMouthOpen;
            fireball = Aquamentus.Fireball;
            elapsedFrameCount = 0;
            endFrame = 20;

        }
        public void ChangeDirection()
        {
            
                Aquamentus.State = new MovingAttackedLeftAquamentusState(Aquamentus);
                
        }
        public void ChangeAttackedStatus() {
            Aquamentus.State = new MovingAttackedRightAquamentusState(Aquamentus);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame < 30)
            {
                if (currentFrame == 5)
                {
                    sourceRectangle = Globals.AquamentusOrangeLeft1;
                }
                else if (currentFrame == 10)
                {
                    sourceRectangle = Globals.AquamentusBlueLeft;
                }
                else if (currentFrame == 15)
                {
                    sourceRectangle = Globals.AquamentusOrangeLeft2;
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

            }


        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Aquamentus.X, Aquamentus.Y, sourceRectangle);
            
        }
    }
}
