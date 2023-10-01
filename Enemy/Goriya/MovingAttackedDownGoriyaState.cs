using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class MovingAttackedDownGoriyaState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        public MovingAttackedDownGoriyaState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            sprite = EnemySpriteFactory.Instance.CreateMovingDownGoriyaSprite();
            sourceRectangle = Globals.GoriyaRedDown;
            currentFrame = 0;
        }
        public void ChangeDirection()
        {
            Goriya.State = new MovingAttackedLeftGoriyaState(Goriya);
        }
        public void ChangeAttackedStatus() {
            Goriya.State = new MovingDownGoriyaState(Goriya);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame <= 20)
            {
                if (currentFrame == 5)
                {
                    sourceRectangle = Globals.GoriyaGreenDown;
                }
                else if (currentFrame == 10)
                {
                    sourceRectangle = Globals.GoriyaTealDown;
                }
                else if (currentFrame == 15)
                {
                    sourceRectangle = Globals.GoriyaRedDown;
                }
                else if (currentFrame == 20)
                {
                    sourceRectangle = Globals.GoriyaBlueDown;
                }
            }
            else
            {
                currentFrame = 0;
            }
            Goriya.Y += 1;
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Goriya.X, Goriya.Y, sourceRectangle) ;
        }
    }
}
