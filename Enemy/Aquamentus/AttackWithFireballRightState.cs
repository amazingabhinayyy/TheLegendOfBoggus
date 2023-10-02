using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Projectile;

namespace Sprint2_Attempt3.Enemy.Aquamentus
{
    internal class AttackWithBoomerangRightState : IEnemyState
    {
        private Aquamentus Aquamentus;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private int currentBoomerangFrame;
        private IEnemyProjectile boomerang;
       
        public AttackWithBoomerangRightState(Aquamentus Aquamentus)
        {
            this.Aquamentus = Aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateMovingRightAquamentusSprite();
            currentFrame = 0;
            currentBoomerangFrame = 0;
            sourceRectangle = Globals.AquamentusRedRight;
            boomerang = Aquamentus.Boomerang;
         

        }
        public void ChangeDirection()
        {
            if (Aquamentus.end)
            {
                Aquamentus.State = new MovingDownAquamentusState(Aquamentus);
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
