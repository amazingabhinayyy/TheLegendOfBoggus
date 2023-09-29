using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class MovingUpGoriyaState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private static EnemySpriteFactory enemySpriteFactory;
        public MovingUpGoriyaState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            enemySpriteFactory = new EnemySpriteFactory();
            sprite = EnemySpriteFactory.Instance.CreateMovingUpGoriyaSprite();

        }
        public void ChangeDirection()
        {
            Goriya.State = new MovingRightGoriyaState(Goriya);
        }
        public void ChangeAttackedStatus() {
            Goriya.State = new DeathAnimationState(Goriya);
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
