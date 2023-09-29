using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class MovingLeftAttackedDodongoState : IEnemyState
    {
        private Dodongo dodongo;
        private IEnemySprite sprite;
        public MovingLeftAttackedDodongoState(Dodongo dodongo)
        {
            this.dodongo = dodongo;

            sprite = EnemySpriteFactory.Instance.CreateMovingLeftAttackedDodongoSprite();

        }
        public void ChangeDirection()
        {
        }
        public void ChangeAttackedStatus()
        {
            dodongo.State = new MovingLeftDodongoState(dodongo);
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
