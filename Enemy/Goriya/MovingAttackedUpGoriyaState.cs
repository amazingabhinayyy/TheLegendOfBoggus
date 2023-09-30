using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class MovingAttackedUpGoriyaState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        public MovingAttackedUpGoriyaState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            sprite = EnemySpriteFactory.Instance.CreateMovingUpGoriyaSprite();
            sourceRectangle = Globals.GoriyaRedUp;
            currentFrame = 0;
        }
        public void ChangeDirection()
        {
            Goriya.State = new MovingAttackedRightGoriyaState(Goriya);
        }
        public void ChangeAttackedStatus() {
            Goriya.State = new MovingUpGoriyaState(Goriya);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame <= 20)
            {
                if (currentFrame == 5)
                {
                    sourceRectangle = Globals.GoriyaGreenUp;
                }
                else if (currentFrame == 10)
                {
                    sourceRectangle = Globals.GoriyaTealUp;
                }
                else if (currentFrame == 15)
                {
                    sourceRectangle = Globals.GoriyaRedUp;
                }
                else if (currentFrame == 20)
                {
                    sourceRectangle = Globals.GoriyaBlueUp;
                }
            }
            else
            {
                currentFrame = 0;
            }
            Goriya.Y -= 1;
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Goriya.X, Goriya.Y, sourceRectangle);
        }
    }
}
