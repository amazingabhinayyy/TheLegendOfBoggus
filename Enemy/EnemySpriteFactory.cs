using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;
using Sprint2_Attempt3.Enemy.Gel;
using Sprint2_Attempt3.Enemy.Zol;
using Sprint2_Attempt3.Enemy.SpikeTrap;
using Sprint2_Attempt3.Enemy.Dodongo;
using Sprint2_Attempt3.Enemy.Goriya;

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
        public IEnemySprite CreateKeeseSprite()
        {
            return new KeeseSprite(EnemyTexture);
        }
        public IEnemySprite CreateRopeSprite()
        {
            return new RopeSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingLeftRopeSprite()
        {
            return new MovingLeftRopeSprite(EnemyTexture);
        }
        public IEnemySprite CreateZolSprite()
        {
            return new ZolSprite(EnemyTexture);
        }
        public IEnemySprite CreateGelSprite()
        {
            return new GelSprite(EnemyTexture);
        }
        public IEnemySprite CreateSpkieTrapSprite()
        {
            return new SpikeTrapSprite(EnemyTexture);
        }

        public IEnemySprite CreateDodongoSprite()
        {
            return new DodongoSprite(BossEnemyTexture);
        }
        public IEnemySprite CreateMovingVerticallyDodongoSprite()
        {
            return new MovingVerticallyDodongoSprite(BossEnemyTexture);
        }
        public IEnemySprite CreateMovingLeftDodongoSprite()
        {
            return new MovingLeftDodongoSprite(BossEnemyTexture);
        }
        public IEnemySprite CreateMovingLeftAttackedDodongoSprite()
        {
            return new MovingLeftAttackedDodongoSprite(BossEnemyTexture);
        }

        public IEnemySprite CreateMovingUpGoriyaSprite()
        {
            return new MovingUpGoriyaSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingDownGoriyaSprite()
        {
            return new MovingDownGoriyaSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingRightGoriyaSprite()
        {
            return new MovingRightGoriyaSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingLeftGoriyaSprite()
        {
            return new MovingLeftGoriyaSprite(EnemyTexture);
        }
    }
}
