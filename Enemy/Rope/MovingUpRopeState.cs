using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Rope
{
    internal class MovingUpRopeState : IEnemyState
    {
        private Rope rope;
        private IEnemySprite sprite;
        private static EnemySpriteFactory enemySpriteFactory;
        public MovingUpRopeState(Rope rope)
        {
            this.rope = rope;
            enemySpriteFactory = new EnemySpriteFactory();
            sprite = EnemySpriteFactory.Instance.CreateMovingUpRopeSprite();

        }
        public void ChangeDirection()
        {
            rope.State = new MovingRightRopeState(rope);
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
