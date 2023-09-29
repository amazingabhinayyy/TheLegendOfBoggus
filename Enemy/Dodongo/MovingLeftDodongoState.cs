using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class MovingLeftDodongoState : IEnemyState
    {
        private Dodongo dodongo;
        private IEnemySprite sprite;
        public MovingLeftDodongoState(Dodongo dodongo)
        {
            this.dodongo = dodongo;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftDodongoSprite();
        }
        public void ChangeDirection()
        {
            dodongo.State = new MovingUpDodongoState(dodongo);
        }
        public void ChangeAttackedStatus()
        {
            dodongo.State = new MovingLeftAttackedDodongoState(dodongo);
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
