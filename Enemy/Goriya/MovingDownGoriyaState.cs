using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class MovingDownGoriyaState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        public MovingDownGoriyaState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            sprite = EnemySpriteFactory.Instance.CreateMovingDownGoriyaSprite();
            sourceRectangle = Globals.GoriyaBlueDown;
        }
        public void ChangeDirection()
        {
            Goriya.State = new MovingLeftGoriyaState(Goriya);
        }
        public void ChangeAttackedStatus() {
            Goriya.State.ChangeAttackedStatus();
        }
        public void Update()
        {
            Goriya.Y += 1;
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Goriya.X, Goriya.Y, sourceRectangle) ;
        }
    }
}
