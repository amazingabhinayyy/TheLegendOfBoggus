using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Hand
{
    internal class MovingRightHandState : IEnemyState
    {
        private Hand Hand;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        public MovingRightHandState(Hand Hand)
        {
            this.Hand = Hand;
            sprite = EnemySpriteFactory.Instance.CreateHandSprite();
            sourceRectangle = Globals.HandRed1;
            currentFrame = 0;

        }
        public void ChangeDirection()
        {
            Hand.State = new MovingDownHandState(Hand);
        }
        public void ChangeAttackedStatus() {
            Hand.State = new MovingAttackedRightHandState(Hand);
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
            Hand.X += 1;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Hand.X, Hand.Y, sourceRectangle);
        }
    }
}
