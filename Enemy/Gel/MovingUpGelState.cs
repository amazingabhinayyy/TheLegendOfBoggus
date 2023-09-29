using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Gel
{
    internal class MovingUpGelState : IEnemyState
    {
        private Gel gel;
        private IEnemySprite sprite;
        private static EnemySpriteFactory enemySpriteFactory;
        public MovingUpGelState(Gel gel)
        {
            this.gel = gel;
            enemySpriteFactory = new EnemySpriteFactory();
            sprite = EnemySpriteFactory.Instance.CreateMovingUpGelSprite();

        }
        public void ChangeDirection()
        {
            gel .State = new MovingRightGelState(gel);
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
