using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Enemy.Keese
{
    internal class MovingLeftKeeseState : IEnemyState
    {
        private Keese keese;
        private IEnemySprite sprite;
        private static EnemySpriteFactory enemySpriteFactory;
        public MovingLeftKeeseState(Keese keese)
        {
            this.keese = keese;
            enemySpriteFactory = new EnemySpriteFactory();
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftKeeseSprite();

        }
        public void ChangeDirection()
        {
            keese.State = new MovingUpKeeseState(keese);
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
