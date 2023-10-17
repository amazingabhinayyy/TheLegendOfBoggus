﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Gel;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class MovingDownDodongoState : IEnemyState
    {
        private Dodongo dodongo;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private Random random;
        private int direction;

        public MovingDownDodongoState(Dodongo dodongo)
        {
            this.dodongo = dodongo;
            sprite = EnemySpriteFactory.Instance.CreateMovingVerticallyDodongoSprite();
            sourceRectangle = Globals.DodongoDown;
            dodongo.Position = new Rectangle(dodongo.X, dodongo.Y, sourceRectangle.Width, sourceRectangle.Height);
            random = new Random();
            direction = random.Next(0, 2);
        }
        public void ChangeDirection()
        {
            direction = random.Next(0, 2);
            switch (direction)
            {
                case 0:
                    dodongo.State = new MovingLeftDodongoState(dodongo);
                    break;
                case 1:
                    dodongo.State = new MovingUpDodongoState(dodongo);
                    break;
                case 2:
                    dodongo.State = new MovingRightDodongoState(dodongo);
                    break;
            }
        }
        public void ChangeAttackedStatus() {
            dodongo.State = new MovingDownAttackedDodongoState(dodongo);
        }
        public void Update()
        {
            dodongo.Y += 1;
            dodongo.Position = new Rectangle(dodongo.X, dodongo.Y, sourceRectangle.Width, sourceRectangle.Height);
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, dodongo.X, dodongo.Y, sourceRectangle);
        }
    }
}
