using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Projectile;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class AttackWithBoomerangLeftState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private int currentBoomerangFrame;
        private IEnemyProjectile boomerang;
        private int elapsedFrameCount;
        private int endFrame;
        public AttackWithBoomerangLeftState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftGoriyaSprite();
            currentFrame = 0;
            currentBoomerangFrame = 0;
            sourceRectangle = Globals.GoriyaRedRight;
            boomerang = Goriya.Boomerang;
            elapsedFrameCount = 0;
            endFrame = 20;


        }
        public void ChangeDirection()
        {
                Goriya.State = new MovingUpGoriyaState(Goriya);
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
               
            }
            else
            {
                currentFrame = 0;
            }
            elapsedFrameCount++;
            if()

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Goriya.X, Goriya.Y, sourceRectangle);
            boomerang.Draw(spriteBatch);
        }
    }
}
