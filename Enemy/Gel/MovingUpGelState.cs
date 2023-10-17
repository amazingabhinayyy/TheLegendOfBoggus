using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.Gel
{
    internal class MovingUpGelState : IEnemyState
    {
        private Gel gel;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private Random random;
        private int direction;
        public MovingUpGelState(Gel gel)
        {
            this.gel = gel;
            sprite = EnemySpriteFactory.Instance.CreateGelSprite();
            sourceRectangle = Globals.GelSprite1;
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
                    gel.State = new MovingLeftGelState(gel);
                    break;
                case 1:
                    gel.State = new MovingDownGelState(gel);
                    break;
                case 2:
                    gel.State = new MovingRightGelState(gel);
                    break;
            }
        }
        public void ChangeAttackedStatus()
        {
            gel.State = new DeathAnimationState(gel);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame < 30)
            {
                if (currentFrame < 15)
                {
                    sourceRectangle = Globals.GelSprite1;

                }
                else
                {
                    sourceRectangle = Globals.GelSprite2;

                }
                gel.Y -= 1;
            }
            else
            {
                currentFrame = 0;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, gel.X, gel.Y, sourceRectangle);
        }
    }
}
