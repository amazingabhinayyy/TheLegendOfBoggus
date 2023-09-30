using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Rope
{
    internal class MovingUpRopeState : IEnemyState
    {
        private Rope rope;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        public MovingUpRopeState(Rope rope)
        {
            this.rope = rope;
            sprite = EnemySpriteFactory.Instance.CreateRopeSprite();
            sourceRectangle = Globals.RopeSprite1;
            currentFrame = 0;
        }
        public void ChangeDirection()
        {
            rope.State = new MovingRightRopeState(rope);
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
                rope.Y -= 1;
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
