using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Gel
{
    internal class MovingDownGelState : IEnemyState
    {
        private Gel gel;
        private IEnemySprite sprite;
        public MovingDownGelState(Gel gel)
        {
            this.gel = gel;
            sprite = EnemySpriteFactory.Instance.CreateMovingDownGelSprite();
        }
        public void ChangeDirection()
        {
            gel.State = new MovingLeftGelState(gel);
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
