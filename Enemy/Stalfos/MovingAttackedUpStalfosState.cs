using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Stalfos
{
    internal class MovingAttackedUpStalfosState : IEnemyState
    {
        private Stalfos Stalfos;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        public MovingAttackedUpStalfosState(Stalfos Stalfos)
        {
            this.Stalfos = Stalfos;
            sprite = EnemySpriteFactory.Instance.CreateStalfosSprite();
            sourceRectangle = Globals.StalfosRed;
            currentFrame = 0;
        }
        public void ChangeDirection()
        {
            Stalfos.State = new MovingAttackedRightStalfosState(Stalfos);
        }
        public void ChangeAttackedStatus() {
            Stalfos.State = new MovingUpStalfosState(Stalfos);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame <= 20)
            {
                if (currentFrame == 5)
                {
                    sourceRectangle = Globals.StalfosGreen;
                }
                else if (currentFrame == 10)
                {
                    sourceRectangle = Globals.StalfosTeal;
                }
                else if (currentFrame == 15)
                {
                    sourceRectangle = Globals.StalfosRed;
                }
                else if (currentFrame == 20)
                {
                    sourceRectangle = Globals.StalfosBlue;
                }
            }
            else
            {
                currentFrame = 0;
            }
            Stalfos.Y -= 1;
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Stalfos.X, Stalfos.Y, sourceRectangle);
        }
    }
}
