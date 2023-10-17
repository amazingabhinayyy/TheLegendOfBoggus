﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.Stalfos
{
    internal class MovingRightStalfosState : IEnemyState
    {
        private Stalfos Stalfos;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private Random random;
        private int direction;
        public MovingRightStalfosState(Stalfos Stalfos)
        {
            this.Stalfos = Stalfos;
            sprite = EnemySpriteFactory.Instance.CreateStalfosSprite();
            sourceRectangle = Globals.StalfosRed;
            Stalfos.Position = new Rectangle(Stalfos.X, Stalfos.Y, sourceRectangle.Width, sourceRectangle.Height);
            currentFrame = 0;
            random = new Random();
            direction = random.Next(0, 2);

        }
        public void ChangeDirection()
        {
            direction = random.Next(0, 2);
            switch (direction)
            {
                case 0:
                    Stalfos.State = new MovingLeftStalfosState(Stalfos);
                    break;
                case 1:
                    Stalfos.State = new MovingUpStalfosState(Stalfos);
                    break;
                case 2:
                    Stalfos.State = new MovingDownStalfosState(Stalfos);
                    break;
            }
        }
        public void ChangeAttackedStatus() {
            Stalfos.State = new MovingAttackedRightStalfosState(Stalfos);
        }
        public void Update()
        {
            Stalfos.X += 1;
            Stalfos.Position = new Rectangle(Stalfos.X, Stalfos.Y, sourceRectangle.Width, sourceRectangle.Height);
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Stalfos.X, Stalfos.Y, sourceRectangle);
        }
    }
}
