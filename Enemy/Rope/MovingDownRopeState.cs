using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Rope
{
    internal class MovingDownRopeState : IEnemyState
    {
        private Rope rope;
        private IEnemySprite sprite;
        public MovingDownRopeState(Rope rope)
        {
            this.rope = rope;
            sprite = EnemySpriteFactory.Instance.CreateMovingDownRopeSprite();
        }
        public void ChangeDirection()
        {
            rope.State = new MovingLeftRopeState(rope);
        }
        public void ChangeAttackedStatus() {
            rope.State = new DeathAnimationState(rope);
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
