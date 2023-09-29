using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Zol
{
    internal class MovingRightZolState : IEnemyState
    {
        private Zol zol;
        private IEnemySprite sprite;
        private static EnemySpriteFactory enemySpriteFactory;
        public MovingRightZolState(Zol zol)
        {
            this.zol = zol;
            enemySpriteFactory = new EnemySpriteFactory();
            sprite = EnemySpriteFactory.Instance.CreateMovingRightZolSprite();

        }
        public void ChangeDirection()
        {
            zol .State = new MovingDownZolState(zol);
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
