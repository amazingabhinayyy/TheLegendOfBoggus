using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Aquamentus
{
    internal class MovingAttackedLeftAquamentusState : IEnemyState
    {
        private Aquamentus Aquamentus;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        public MovingAttackedLeftAquamentusState(Aquamentus Aquamentus)
        {
            this.Aquamentus = Aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftAquamentusSprite();
            currentFrame = 0;
            sourceRectangle = Globals.AquamentusRedRight;

        }
        public void ChangeDirection()
        {
            Aquamentus.State = new MovingAttackedUpAquamentusState(Aquamentus);
        }
        public void ChangeAttackedStatus() {
            Aquamentus.State = new MovingLeftAquamentusState(Aquamentus);
        }
        public void Update()
        {
            
            currentFrame++;
            if (currentFrame <= 20)
            {
                if (currentFrame == 5)
                {
                    sourceRectangle = Globals.AquamentusGreenRight2;
                }
                else if (currentFrame == 10)
                {
                    sourceRectangle = Globals.AquamentusTealRight;
                }
                else if (currentFrame == 15)
                {
                    sourceRectangle = Globals.AquamentusRedRight2;
                }
                else if (currentFrame == 20)
                {
                    sourceRectangle = Globals.AquamentusBlueRight;
                }
            }
            else
            {
                currentFrame = 0;
            }
            Aquamentus.X -= 1;

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Aquamentus.X, Aquamentus.Y, sourceRectangle);
        }
    }
}
