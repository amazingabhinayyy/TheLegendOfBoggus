using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Enemy.Keese
{
    internal class DeathAnimationState : IEnemyState
    {
        private IEnemy enemy;
        private DeathAnimationSprite sprite;
        private static EnemySpriteFactory enemySpriteFactory;
        public DeathAnimationState(IEnemy enemy)
        {
            this.enemy = enemy;
            enemySpriteFactory = new EnemySpriteFactory();
            sprite = (DeathAnimationSprite)EnemySpriteFactory.Instance.CreateDeathAnimationSprite();

        }
        public void ChangeDirection()
        {
            
        }
        public void ChangeAttackedStatus() {
            enemy.Spawn();
        }
        public void Update()
        {
            if (!sprite.Died) {
                sprite.Update();
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (!sprite.Died)
            {
                sprite.Draw(spriteBatch);
            }
        }
    }
}
