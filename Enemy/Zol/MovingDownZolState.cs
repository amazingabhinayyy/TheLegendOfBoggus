using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Zol
{
    internal class MovingDownZolState : IEnemyState
    {
        private Zol zol;
        private IEnemySprite sprite;
        public MovingDownZolState(Zol zol)
        {
            this.zol = zol;
            sprite = EnemySpriteFactory.Instance.CreateMovingDownZolSprite();
        }
        public void ChangeDirection()
        {
            zol.State = new MovingLeftZolState(zol);
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
