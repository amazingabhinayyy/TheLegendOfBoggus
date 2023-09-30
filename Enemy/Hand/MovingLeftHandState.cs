using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Hand
{
    internal class MovingLeftHandState : IEnemyState
    {
        private Hand Hand;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        public MovingLeftHandState(Hand Hand)
        {
            this.Hand = Hand;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftHandSprite();
            currentFrame = 0;
            sourceRectangle = Globals.HandRed1;

        }
        public void ChangeDirection()
        {
            Hand.State = new MovingUpHandState(Hand);
        }
        public void ChangeAttackedStatus() {
            Hand.State = new MovingAttackedLeftHandState(Hand);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame < 30)
            {
                if (currentFrame < 15)
                {
                    sourceRectangle = Globals.HandRed1;

                }
                else
                {
                    sourceRectangle = Globals.HandRed2;

                }
            }
            else
            {
                currentFrame = 0;
            }
            Hand.X -= 1;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Hand.X, Hand.Y, sourceRectangle);
        }
    }
}
