using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class MovingDownAttackedDodongoState : IEnemyState
    {
        private Dodongo dodongo;
        private IEnemySprite sprite;
        public MovingDownAttackedDodongoState(Dodongo dodongo)
        {
            this.dodongo = dodongo;

            sprite = EnemySpriteFactory.Instance.CreateMovingDownAttackedDodongoSprite();

        }
        public void ChangeDirection()
        {
        }
        public void ChangeAttackedStatus() {
            dodongo.State = new MovingDownDodongoState(dodongo);
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
