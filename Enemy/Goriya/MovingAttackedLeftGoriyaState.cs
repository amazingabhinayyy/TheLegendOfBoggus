using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class MovingAttackedLeftGoriyaState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private static EnemySpriteFactory enemySpriteFactory;
        public MovingAttackedLeftGoriyaState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            enemySpriteFactory = new EnemySpriteFactory();
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftGoriyaSprite();
            currentFrame = 0;
            sourceRectangle = Globals.GoriyaBlueRight;

        }
        public void ChangeDirection()
        {
            Goriya.State = new MovingAttackedUpGoriyaState(Goriya);
        }
        public void ChangeAttackedStatus() {
            Goriya.State = new MovingLeftGoriyaState(Goriya);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame <= 40)
            {
                if (currentFrame == 5)
                {
                    sourceRectangle = Globals.GoriyaBlueRight;
                }
                else if (currentFrame == 10)
                {
                    sourceRectangle = Globals.GoriyaRedRight2;
                }
                else if (currentFrame == 15)
                {
                    sourceRectangle = Globals.GoriyaBlueRight;
                }
                else if (currentFrame == 20)
                {
                    sourceRectangle = Globals.GoriyaRedRight2;
                }
            }
            else
            {
                currentFrame = 0;
            }
            Goriya.X -= 1;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Goriya.X, Goriya.Y, sourceRectangle);
        }
    }
}
