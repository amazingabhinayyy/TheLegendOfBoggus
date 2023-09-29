using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Zol
{
    internal class MovingUpZolState : IEnemyState
    {
        private Zol zol;
        private IEnemySprite sprite;
        private static EnemySpriteFactory enemySpriteFactory;
        public MovingUpZolState(Zol zol)
        {
            this.zol = zol;
            enemySpriteFactory = new EnemySpriteFactory();
            sprite = EnemySpriteFactory.Instance.CreateMovingUpZolSprite();

        }
        public void ChangeDirection()
        {
            zol .State = new MovingRightZolState(zol);
        }
        public void ChangeAttackedStatus() {
            zol.State = new DeathAnimationState(zol);
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
