using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Enemy.Keese
{
    internal class MovingDownKeeseState : IEnemyState
    {
        private Keese keese;
        private IEnemySprite sprite;
        public MovingDownKeeseState(Keese keese)
        {
            this.keese = keese;
            sprite = EnemySpriteFactory.Instance.CreateMovingDownKeeseSprite();
        }
        public void ChangeDirection()
        {
            keese.State = new MovingLeftKeeseState(keese);
        }
        public void ChangeAttackedStatus() {
            keese.State = new DeathAnimationState(keese);
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
