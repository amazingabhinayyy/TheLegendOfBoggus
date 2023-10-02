using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Stalfos
{
    internal class MovingLeftStalfosState : IEnemyState
    {
        private Stalfos Stalfos;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        public MovingLeftStalfosState(Stalfos Stalfos)
        {
            this.Stalfos = Stalfos;
            sprite = EnemySpriteFactory.Instance.CreateStalfosSprite();
            currentFrame = 0;
            sourceRectangle = Globals.StalfosRed;

        }
        public void ChangeDirection()
        {
            Stalfos.State = new MovingUpStalfosState(Stalfos);
        }
        public void ChangeAttackedStatus() {
            Stalfos.State = new MovingAttackedLeftStalfosState(Stalfos);
        }
        public void Update()
        {

            Stalfos.X -= 1;
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Stalfos.X, Stalfos.Y, sourceRectangle);
        }
    }
}
