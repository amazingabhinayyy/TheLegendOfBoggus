using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class MovingUpGoriyaState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        public MovingUpGoriyaState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            sprite = EnemySpriteFactory.Instance.CreateMovingUpGoriyaSprite();
            sourceRectangle = Globals.GoriyaRedUp;
        }
        public void ChangeDirection()
        {
            Goriya.State = new MovingRightGoriyaState(Goriya);
        }
        public void ChangeAttackedStatus() {
            Goriya.State = new MovingAttackedUpGoriyaState(Goriya);
        }
        public void Update()
        {
            Goriya.Y -= 1;
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Goriya.X, Goriya.Y, sourceRectangle);
        }
    }
}
