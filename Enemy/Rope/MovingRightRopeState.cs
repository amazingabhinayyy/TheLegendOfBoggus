using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Rope
{
    internal class MovingRightRopeState : IEnemyState
    {
        private Rope rope;
        private IEnemySprite sprite;
        private static EnemySpriteFactory enemySpriteFactory;
        public MovingRightRopeState(Rope rope)
        {
            this.rope = rope;
            enemySpriteFactory = new EnemySpriteFactory();
            sprite = EnemySpriteFactory.Instance.CreateMovingRightRopeSprite();

        }
        public void ChangeDirection()
        {
            rope.State = new MovingDownRopeState(rope);
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
