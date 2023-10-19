using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Microsoft.Xna.Framework;
using System;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class MovingLeftDodongoState : IEnemyState
    {
        private Dodongo dodongo;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private Random random;
        private int direction;

        public MovingLeftDodongoState(Dodongo dodongo)
        {
            this.dodongo = dodongo;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftDodongoSprite();
            sourceRectangle = Globals.DodongoRight1;
            dodongo.Position = new Rectangle(dodongo.X, dodongo.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
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
                    dodongo.State = new MovingDownDodongoState(dodongo);
                    break;
                case 1:
                    dodongo.State = new MovingUpDodongoState(dodongo);
                    break;
                case 2:
                    dodongo.State = new MovingRightDodongoState(dodongo);
                    break;
            }
        }
        public void ChangeAttackedStatus()
        {
            dodongo.State = new MovingLeftAttackedDodongoState(dodongo);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame < 30)
            {
                if (currentFrame < 15)
                {
                    sourceRectangle = Globals.DodongoRight1;

                }
                else
                {
                    sourceRectangle = Globals.DodongoRight2;

                }
                dodongo.X -= 1;
                dodongo.Position = new Rectangle(dodongo.X, dodongo.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            }
            else
            {
                currentFrame = 0;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, dodongo.X, dodongo.Y, sourceRectangle);
        }
    }
}
