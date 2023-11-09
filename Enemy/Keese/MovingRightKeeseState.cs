﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Sprint2_Attempt3.Enemy.Keese
{
    internal class MovingRightKeeseState : IEnemyState
    {
        private Keese keese;
        private IEnemySprite sprite;
        private int currentFrame;
        private Rectangle sourceRectangle;
        private Random random;
        private int direction;
        public MovingRightKeeseState(Keese keese)
        {
            this.keese = keese;
            this.currentFrame = 0;
            this.sprite = EnemySpriteFactory.Instance.CreateKeeseSprite();
            this.sourceRectangle = Globals.KeeseSprite1;
            keese.Position = new Rectangle(keese.X, keese.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            random = new Random();
            direction = random.Next(0, 3);
        }
        public void ChangeDirection()
        {
            direction = random.Next(0, 3);
            switch (direction)
            {
                case 0:
                    keese.State = new MovingLeftKeeseState(keese);
                    break;
                case 1:
                    keese.State = new MovingUpKeeseState(keese);
                    break;
                case 2:
                    keese.State = new MovingDownKeeseState(keese);
                    break;
            }
        }
        public void ChangeAttackedStatus()
        {
            keese.State = new DeathAnimationState(keese);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame < 30)
            {
                if (currentFrame < 15)
                {
                    sourceRectangle = Globals.KeeseSprite1;

                }
                else
                {
                    sourceRectangle = Globals.KeeseSprite2;

                }
                keese.X += 1;
                keese.Position = new Rectangle(keese.X, keese.Y, sourceRectangle.Width, sourceRectangle.Height);
            }
            else
            {
                currentFrame = 0;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, keese.X, keese.Y, sourceRectangle);
        }
    }
}
