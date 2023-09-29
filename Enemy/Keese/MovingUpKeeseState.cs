using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Enemy.Keese
{
    internal class MovingUpKeeseState : IEnemyState
    {
        private Keese keese;
        private IEnemySprite sprite;
        private static EnemySpriteFactory enemySpriteFactory;
        public MovingUpKeeseState(Keese keese)
        {
            this.keese = keese;
            enemySpriteFactory = new EnemySpriteFactory();
            sprite = EnemySpriteFactory.Instance.CreateMovingUpKeeseSprite();

        }
        public void ChangeDirection()
        {
            keese.State = new MovingRightKeeseState(keese);
        }
        public void ChangeAttackedStatus() {
            keese.State = new DeathAnimationState(keese);
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
