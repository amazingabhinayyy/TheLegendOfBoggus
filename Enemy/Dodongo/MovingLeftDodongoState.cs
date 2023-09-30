using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class MovingLeftDodongoState : IEnemyState
    {
        private Dodongo dodongo;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;

        public MovingLeftDodongoState(Dodongo dodongo)
        {
            this.dodongo = dodongo;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftDodongoSprite();
            sourceRectangle = Globals.DodongoRight1;
            currentFrame = 0;
        }
        public void ChangeDirection()
        {
            dodongo.State = new MovingUpDodongoState(dodongo);
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
