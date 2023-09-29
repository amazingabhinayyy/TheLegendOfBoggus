using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class MovingRightGoriyaState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private static EnemySpriteFactory enemySpriteFactory;
        public MovingRightGoriyaState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            enemySpriteFactory = new EnemySpriteFactory();
            sprite = EnemySpriteFactory.Instance.CreateMovingRightGoriyaSprite();
            sourceRectangle = Globals.GoriyaBlueRight;
            currentFrame = 0;

        }
        public void ChangeDirection()
        {
            Goriya.State = new MovingDownGoriyaState(Goriya);
        }
        public void ChangeAttackedStatus() {
            Goriya.State.ChangeAttackedStatus();
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame < 30)
            {
                if (currentFrame < 15)
                {
                    sourceRectangle = Globals.GoriyaBlueRight;

                }
                else
                {
                    sourceRectangle = Globals.GoriyaBlueRight2;

                }
                Goriya.X += 1;
            }
            else
            {
                currentFrame = 0;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Goriya.X, Goriya.Y, sourceRectangle);
        }
    }
}
