﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.Stalfos
{
    internal class MovingAttackedLeftStalfosState : IEnemyState
    {
        private Stalfos Stalfos;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private Random random;
        private int direction;
        public MovingAttackedLeftStalfosState(Stalfos Stalfos)
        {
            this.Stalfos = Stalfos;
            sprite = EnemySpriteFactory.Instance.CreateStalfosSprite();
            currentFrame = 0;
            sourceRectangle = Stalfos.Stalfoses[0];
            Stalfos.Position = new Rectangle(Stalfos.X, Stalfos.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            random = new Random();
            direction = random.Next(0, 2);

        }
        public void ChangeDirection()
        {
            direction = random.Next(0, 2);
            switch (direction)
            {
                case 0:
                    Stalfos.State = new MovingAttackedDownStalfosState(Stalfos);
                    break;
                case 1:
                    Stalfos.State = new MovingAttackedUpStalfosState(Stalfos);
                    break;
                case 2:
                    Stalfos.State = new MovingAttackedRightStalfosState(Stalfos);
                    break;
            }
        }
        public void ChangeAttackedStatus() {
            Stalfos.State = new MovingLeftStalfosState(Stalfos);
        }
        public void Update()
        {
            
            currentFrame++;
            sourceRectangle = Stalfos.Stalfoses[Globals.FindIndex(currentFrame % (Stalfos.Stalfoses.Length * Stalfos.DamageAnimateRate), Stalfos.DamageAnimateRate, Stalfos.Stalfoses.Length)];
            Stalfos.X -= 1;
            Stalfos.Position = new Rectangle(Stalfos.X, Stalfos.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            sprite.Update();

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Stalfos.X, Stalfos.Y, sourceRectangle);
        }
    }
}
