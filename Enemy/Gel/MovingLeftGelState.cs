using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Gel
{
    internal class MovingLeftGelState : IEnemyState
    {
        private Gel gel;
        private IEnemySprite sprite;
        private static EnemySpriteFactory enemySpriteFactory;
        public MovingLeftGelState(Gel gel)
        {
            this.gel = gel;
            enemySpriteFactory = new EnemySpriteFactory();
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftGelSprite();

        }
        public void ChangeDirection()
        {
            gel.State = new MovingUpGelState(gel);
        }
        public void ChangeAttackedStatus() {
            gel.State = new DeathAnimationState(gel);
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
