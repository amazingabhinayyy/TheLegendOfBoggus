using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.Rope
{
    internal class MovingRightRopeState : IEnemyState
    {
        private Rope rope;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private Random random;
        private int direction;
        public MovingRightRopeState(Rope rope)
        {
            this.rope = rope;
            sprite = EnemySpriteFactory.Instance.CreateRopeSprite();
            sourceRectangle = Globals.RopeSprite1;
            rope.Position = new Rectangle(rope.X, rope.Y, sourceRectangle.Width, sourceRectangle.Height);
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
                    rope.State = new MovingLeftRopeState(rope);
                    break;
                case 1:
                    rope.State = new MovingUpRopeState(rope);
                    break;
                case 2:
                    rope.State = new MovingDownRopeState(rope);
                    break;
            }
        }
        public void ChangeAttackedStatus()
        {
            rope.State = new DeathAnimationState(rope);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame < 30)
            {
                if (currentFrame < 15)
                {
                    sourceRectangle = Globals.RopeSprite1;

                }
                else
                {
                    sourceRectangle = Globals.RopeSprite2;

                }
                rope.X += 1;
                rope.Position = new Rectangle(rope.X, rope.Y, sourceRectangle.Width, sourceRectangle.Height);
            }
            else
            {
                currentFrame = 0;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, rope.X, rope.Y, sourceRectangle);
        }
    }
}
