﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.Hand
{
    internal class MovingAttackedLeftHandState : IEnemyState
    {
        private Hand Hand;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private Random random;
        private int direction;
        private int colorTimer;
        public MovingAttackedLeftHandState(Hand Hand)
        {
            this.Hand = Hand;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftHandSprite();
            currentFrame = 0;
            sourceRectangle = Globals.HandRed1;
            Hand.Position = new Rectangle(Hand.X, Hand.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            random = new Random();
            direction = random.Next(0, 3);
            colorTimer = 0;
        }
        public void ChangeDirection()
        {
            direction = random.Next(0, 3);
            switch (direction)
            {
                case 0:
                    Hand.State = new MovingAttackedDownHandState(Hand);
                    break;
                case 1:
                    Hand.State = new MovingAttackedUpHandState(Hand);
                    break;
                case 2:
                    Hand.State = new MovingAttackedRightHandState(Hand);
                    break;
            }
        }
        public void ChangeAttackedStatus() {
            if(colorTimer >= 60)
                Hand.State = new MovingLeftHandState(Hand);
        }
        public void Update()
        {
            colorTimer++;
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
            Hand.X -= 1;
            Hand.Position = new Rectangle(Hand.X, Hand.Y, sourceRectangle.Width, sourceRectangle.Height);
            ChangeAttackedStatus();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Hand.X, Hand.Y, sourceRectangle);
        }
    }
}
