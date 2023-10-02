using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Aquamentus
{
    internal class MovingAttackedRightAquamentusState : IEnemyState
    {
        private Aquamentus Aquamentus;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        public MovingAttackedRightAquamentusState(Aquamentus Aquamentus)
        {
            this.Aquamentus = Aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateMovingRightAquamentusSprite();
            sourceRectangle = Globals.AquamentusOrangeLeft1;
            currentFrame = 0;

        }
        public void ChangeDirection()
        {
            Aquamentus.State = new MovingAttackedLeftAquamentusState(Aquamentus);
        }
        public void ChangeAttackedStatus() {
            Aquamentus.State = new MovingRightAquamentusState(Aquamentus);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame <= 20)
            {
                if (currentFrame == 5)
                {
                    sourceRectangle = Globals.AquamentusOrangeLeft1;
                }
                else if (currentFrame == 10)
                {
                    sourceRectangle = Globals.AquamentusBlueLeft;
                }
                else if (currentFrame == 15)
                {
                    sourceRectangle = Globals.AquamentusOrangeLeft2;
                }
                
            }
            else
            {
                currentFrame = 0;
            }
            Aquamentus.X += 1;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Aquamentus.X, Aquamentus.Y, sourceRectangle);
        }
    }
}
