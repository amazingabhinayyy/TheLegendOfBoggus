using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class ShootingStillLeftGoriyaState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private static EnemySpriteFactory enemySpriteFactory;
        public ShootingStillLeftGoriyaState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            enemySpriteFactory = new EnemySpriteFactory();
            sprite = EnemySpriteFactory.Instance.CreateShootingStillLeftGoriyaSprite();

        }
        public void ChangeDirection()
        {
            if (Globals.changeDirection)
            {
                Goriya.State = new MovingUpGoriyaState(Goriya);
                Globals.changeDirection = false;
            }
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
