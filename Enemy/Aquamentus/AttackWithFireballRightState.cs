using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Projectile;

namespace Sprint2_Attempt3.Enemy.Aquamentus
{
    internal class AttackWithFireballRightState : IEnemyState
    {
        private Aquamentus Aquamentus;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private int currentFireballFrame;
        private IEnemyProjectile fireball;
       
        public AttackWithFireballRightState(Aquamentus Aquamentus)
        {
            this.Aquamentus = Aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateMovingRightAquamentusSprite();
            currentFrame = 0;
            currentFireballFrame = 0;
            sourceRectangle = Globals.AquamentusGreenLeftMouthOpen;
            fireball = Aquamentus.Fireball;
         

        }
        public void ChangeDirection()
        {
            if (Aquamentus.end)
            {
                Aquamentus.State = new MovingLeftAquamentusState(Aquamentus);
                Aquamentus.end = false;
            }
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
                    sourceRectangle = Globals.AquamentusGreenLeftMouthOpen;

                }
                else
                {
                    sourceRectangle = Globals.AquamentusGreenLeftMouthOpen2;

                }
               
            }
            else
            {
                currentFrame = 0;
            }
            
            fireball.Update();


        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Aquamentus.X, Aquamentus.Y, sourceRectangle);
            fireball.Draw(spriteBatch);
        }
    }
}
