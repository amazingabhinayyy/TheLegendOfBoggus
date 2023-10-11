﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Hand
{
    internal class MovingAttackedRightHandState : IEnemyState
    {
        private Hand Hand;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        public MovingAttackedRightHandState(Hand Hand)
        {
            this.Hand = Hand;
            sprite = EnemySpriteFactory.Instance.CreateHandSprite();
            sourceRectangle = Globals.HandBlue1;
            currentFrame = 0;

        }
        public void ChangeDirection()
        {
            Hand.State = new MovingAttackedDownHandState(Hand);
        }
        public void ChangeAttackedStatus() {
            Hand.State = new MovingRightHandState(Hand);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame <= 20)
            {
                if (currentFrame == 5)
                {
                    sourceRectangle = Globals.HandGreen2;
                }
                else if (currentFrame == 10)
                {
                    sourceRectangle = Globals.HandTeal1;
                }
                else if (currentFrame == 15)
                {
                    sourceRectangle = Globals.HandRed2;
                }
                else if (currentFrame == 20)
                {
                    sourceRectangle = Globals.HandBlue1;
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