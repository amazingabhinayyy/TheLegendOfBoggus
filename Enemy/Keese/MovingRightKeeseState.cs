using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Enemy.Keese
{
    internal class MovingRightKeeseState : IEnemyState
    {
        private Keese keese;
        private IEnemySprite sprite;
        private static EnemySpriteFactory enemySpriteFactory;
        public MovingRightKeeseState(Keese keese)
        {
            this.keese = keese;
            enemySpriteFactory = new EnemySpriteFactory();
            sprite = EnemySpriteFactory.Instance.CreateMovingRightKeeseSprite();

        }
        public void ChangeDirection()
        {
            keese.State = new MovingDownKeeseState(keese);
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
