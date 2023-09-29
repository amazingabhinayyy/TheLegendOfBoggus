using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class MovingRightAttackedDodongoState : IEnemyState
    {
        private Dodongo dodongo;
        private IEnemySprite sprite;
        public MovingRightAttackedDodongoState(Dodongo dodongo)
        {
            this.dodongo = dodongo;

            sprite = EnemySpriteFactory.Instance.CreateMovingRightAttackedDodongoSprite();

        }
        public void ChangeDirection()
        {
        }
        public void ChangeAttackedStatus()
        {
            dodongo.State = new MovingRightDodongoState(dodongo);
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
