﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Enemy.Stalfos
{
    internal class StunnedStalfosState : IEnemyState
    {
        private Stalfos Stalfos;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private Random random;
        private int direction;
        private int stunCounter;
        public StunnedStalfosState(Stalfos Stalfos)
        {
            this.Stalfos = Stalfos;
            sprite = EnemySpriteFactory.Instance.CreateStalfosSprite();
            sourceRectangle = Stalfos.Stalfoses[0];
            Stalfos.Position = new Rectangle(Stalfos.X, Stalfos.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
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
        public void ChangeAttackedStatus()
        {
            Stalfos.State = new MovingAttackedRightStalfosState(Stalfos);
        }
        public void Update()
        {

            stunCounter++;
            if(stunCounter == 200)
            {
                ChangeDirection();
            }
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Stalfos.X, Stalfos.Y, sourceRectangle);
        }
    }
}
