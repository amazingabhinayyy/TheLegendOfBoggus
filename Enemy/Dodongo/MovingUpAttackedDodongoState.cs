using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class MovingUpAttackedDodongoState : IEnemyState
    {
        private Dodongo dodongo;
        private IEnemySprite sprite;
        public MovingUpAttackedDodongoState(Dodongo dodongo)
        {
            this.dodongo = dodongo;

            sprite = EnemySpriteFactory.Instance.CreateMovingUpAttackedDodongoSprite();

        }
        public void ChangeDirection()
        {
        }
        public void ChangeAttackedStatus()
        {
            dodongo.State = new MovingUpDodongoState(dodongo);
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
