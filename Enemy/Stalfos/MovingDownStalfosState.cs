using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Stalfos
{
    internal class MovingDownStalfosState : IEnemyState
    {
        private Stalfos Stalfos;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        public MovingDownStalfosState(Stalfos Stalfos)
        {
            this.Stalfos = Stalfos;
            sprite = EnemySpriteFactory.Instance.CreateStalfosSprite();
            sourceRectangle = Globals.StalfosRed;
            currentFrame = 0;
        }
        public void ChangeDirection()
        {
            Stalfos.State = new MovingLeftStalfosState(Stalfos);
        }
        public void ChangeAttackedStatus() {
            Stalfos.State = new MovingAttackedDownStalfosState(Stalfos);
        }
        public void Update()
        {
            Stalfos.Y += 1;
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Stalfos.X, Stalfos.Y, sourceRectangle) ;
        }
    }
}
