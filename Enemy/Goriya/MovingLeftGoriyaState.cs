using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class MovingLeftGoriyaState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private static EnemySpriteFactory enemySpriteFactory;
        public MovingLeftGoriyaState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            enemySpriteFactory = new EnemySpriteFactory();
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftGoriyaSprite();

        }
        public void ChangeDirection()
        {
            Goriya.State = new MovingUpGoriyaState(Goriya);
        }
        public void ChangeAttackedStatus() {
            Goriya.State.ChangeAttackedStatus();
        }
        public void Update()
        {
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch);
        }
    }
}
