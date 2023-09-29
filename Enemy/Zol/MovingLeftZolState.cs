using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Zol
{
    internal class MovingLeftZolState : IEnemyState
    {
        private Zol zol;
        private IEnemySprite sprite;
        private static EnemySpriteFactory enemySpriteFactory;
        public MovingLeftZolState(Zol zol)
        {
            this.zol = zol;
            enemySpriteFactory = new EnemySpriteFactory();
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftZolSprite();

        }
        public void ChangeDirection()
        {
            zol.State = new MovingUpZolState(zol);
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
