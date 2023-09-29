using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;
using Sprint2_Attempt3.Enemy.Gel;
using Sprint2_Attempt3.Enemy.Zol;
using Sprint2_Attempt3.Enemy.SpikeTrap;
using Sprint2_Attempt3.Enemy.Dodongo;

namespace Sprint2_Attempt3.Enemy
{
    internal class EnemySpriteFactory
    {
        private static Texture2D EnemyTexture;
        private static Texture2D BossEnemyTexture;
        private static Texture2D GenerationTexture;

        private static EnemySpriteFactory instance = new EnemySpriteFactory();

        public static EnemySpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }
        public EnemySpriteFactory()
        {

        }

        public void LoadAllTextures(ContentManager content)
        {
            EnemyTexture = content.Load<Texture2D>("Enemies");
            BossEnemyTexture = content.Load<Texture2D>("Bosses");
            GenerationTexture = content.Load<Texture2D>("characterGenerationSprite");
        }

        public IEnemySprite CreateSpawnAnimationSprite()
        {
            return new SpawnAnimationSprite(GenerationTexture);
        }
        public IEnemySprite CreateDeathAnimationSprite()
        {
            return new DeathAnimationSprite(GenerationTexture);
        }
        public IEnemySprite CreateMovingUpKeeseSprite()
        {
            return new MovingUpKeeseSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingDownKeeseSprite()
        {
            return new MovingDownKeeseSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingLeftKeeseSprite()
        {
            return new MovingLeftKeeseSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingRightKeeseSprite()
        {
            return new MovingRightKeeseSprite(EnemyTexture);
        }
 
        public IEnemySprite CreateMovingUpRopeSprite()
        {
            return new MovingUpRopeSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingDownRopeSprite()
        {
            return new MovingDownRopeSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingLeftRopeSprite()
        {
            return new MovingLeftRopeSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingRightRopeSprite()
        {
            return new MovingRightRopeSprite(EnemyTexture);
        }

        public IEnemySprite CreateMovingUpGelSprite()
        {
            return new MovingUpGelSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingDownGelSprite()
        {
            return new MovingDownGelSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingLeftGelSprite()
        {
            return new MovingLeftGelSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingRightGelSprite()
        {
            return new MovingRightGelSprite(EnemyTexture);
        }

        public IEnemySprite CreateMovingUpZolSprite()
        {
            return new MovingUpZolSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingDownZolSprite()
        {
            return new MovingDownZolSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingLeftZolSprite()
        {
            return new MovingLeftZolSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingRightZolSprite()
        {
            return new MovingRightZolSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingUpSpikeTrapSprite()
        {
            return new MovingUpSpikeTrapSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingDownSpikeTrapSprite()
        {
            return new MovingDownSpikeTrapSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingLeftSpikeTrapSprite()
        {
            return new MovingLeftSpikeTrapSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingRightSpikeTrapSprite()
        {
            return new MovingRightSpikeTrapSprite(EnemyTexture);
        }

        public IEnemySprite CreateMovingUpDodongoSprite()
        {
            return new MovingUpDodongoSprite(BossEnemyTexture);
        }
        public IEnemySprite CreateMovingUpAttackedDodongoSprite()
        {
            return new MovingUpAttackedDodongoSprite(BossEnemyTexture);
        }
        public IEnemySprite CreateMovingDownDodongoSprite()
        {
            return new MovingDownDodongoSprite(BossEnemyTexture);
        }
        public IEnemySprite CreateMovingDownAttackedDodongoSprite()
        {
            return new MovingDownAttackedDodongoSprite(BossEnemyTexture);
        }
        public IEnemySprite CreateMovingLeftDodongoSprite()
        {
            return new MovingLeftDodongoSprite(BossEnemyTexture);
        }
        public IEnemySprite CreateMovingLeftAttackedDodongoSprite()
        {
            return new MovingLeftAttackedDodongoSprite(BossEnemyTexture);
        }
        public IEnemySprite CreateMovingRightDodongoSprite()
        {
            return new MovingRightDodongoSprite(BossEnemyTexture);
        }
        public IEnemySprite CreateMovingRightAttackedDodongoSprite()
        {
            return new MovingRightAttackedDodongoSprite(BossEnemyTexture);
        }
    }
}
