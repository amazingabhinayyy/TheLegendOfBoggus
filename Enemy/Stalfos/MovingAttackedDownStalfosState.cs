using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Stalfos
{
    internal class MovingAttackedDownStalfosState : IEnemyState
    {
        private Stalfos Stalfos;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        public MovingAttackedDownStalfosState(Stalfos Stalfos)
        {
            this.Stalfos = Stalfos;
            sprite = EnemySpriteFactory.Instance.CreateStalfosSprite();
            sourceRectangle = Globals.StalfosRed;
            currentFrame = 0;
        }
        public void ChangeDirection()
        {
            Stalfos.State = new MovingAttackedLeftStalfosState(Stalfos);
        }
        public void ChangeAttackedStatus() {
            Stalfos.State = new MovingDownStalfosState(Stalfos);
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
            Stalfos.Y += 1;
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Stalfos.X, Stalfos.Y, sourceRectangle) ;
        }
    }
}
