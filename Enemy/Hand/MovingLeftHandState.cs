using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;
using System;

namespace Sprint2_Attempt3.Enemy.Hand
{
    internal class MovingLeftHandState : IEnemyState
    {
        private Hand Hand;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private Random random;
        private int direction;
        public MovingLeftHandState(Hand Hand)
        {
            this.Hand = Hand;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftHandSprite();
            currentFrame = 0;
            sourceRectangle = Hand.Hands[0];
            Hand.Position = new Rectangle(Hand.X, Hand.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            random = new Random();
            direction = random.Next(0, 3);

        }
        public void ChangeDirection()
        {
            direction = random.Next(0, 3);
            switch (direction)
            {
                case 0:
                    Hand.State = new MovingLeftHandState(Hand);
                    break;
                case 1:
                    Hand.State = new MovingUpHandState(Hand);
                    break;
                case 2:
                    Hand.State = new MovingRightHandState(Hand);
                    break;
            }
        }
        public void ChangeAttackedStatus() {
            Hand.State = new MovingAttackedLeftHandState(Hand);
        }
        public void Update()
        {
            currentFrame++;
            sourceRectangle = Hand.Hands[Globals.FindIndex(currentFrame % (2 * Hand.AnimateRate), Hand.AnimateRate, 2)];
            Hand.X -= 1;
            Hand.Position = new Rectangle(Hand.X, Hand.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Hand.X, Hand.Y, sourceRectangle);
        }
    }
}
