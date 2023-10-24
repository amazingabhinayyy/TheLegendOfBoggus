using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.Hand
{
    internal class CapturedState : IEnemyState
    {
        private Hand Hand;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private Random random;
        private int direction;
        public CapturedState(Hand Hand, Vector2 position)
        {
            Hand.X = (int)position.X;
            Hand.Y = (int)position.Y;
            this.Hand = Hand;
            sprite = EnemySpriteFactory.Instance.CreateHandSprite();
            sourceRectangle = Globals.HandRed1;
            Hand.Position = new Rectangle(Hand.X, Hand.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            currentFrame = 0;
            random = new Random();
            direction = random.Next(0, 2);
        }
        public void ChangeDirection()
        {
            
        }
        public void ChangeAttackedStatus() {
        }
        public void Update()
        {
            Hand.Y += 1;
            Hand.Position = new Rectangle(Hand.X, Hand.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Hand.X, Hand.Y, sourceRectangle);
        }
    }
}
