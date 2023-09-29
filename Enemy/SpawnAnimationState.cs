using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Enemy.Keese
{
    internal class SpawnAnimationState : IEnemyState
    {
        private IEnemy enemy;
        private SpawnAnimationSprite sprite;
        private static EnemySpriteFactory enemySpriteFactory;
        public SpawnAnimationState(IEnemy enemy)
        {
            this.enemy = enemy;
            enemySpriteFactory = new EnemySpriteFactory();
            sprite = (SpawnAnimationSprite)EnemySpriteFactory.Instance.CreateSpawnAnimationSprite();

        }
        public void ChangeDirection()
        {
            
        }
        public void ChangeAttackedStatus() {

        }
        public void Update()
        {
            if (sprite.Spawn) {
                enemy.Generate();
            }
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch);
        }
    }
}
