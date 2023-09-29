using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class MovingRightDodongoState : IEnemyState
    {
        private Dodongo dodongo;
        private IEnemySprite sprite;
        public MovingRightDodongoState(Dodongo dodongo)
        {
            this.dodongo = dodongo;
            sprite = EnemySpriteFactory.Instance.CreateMovingRightDodongoSprite();
        }
        public void ChangeDirection()
        {
            dodongo.State = new MovingDownDodongoState(dodongo);
        }
        public void ChangeAttackedStatus()
        {
            dodongo.State = new MovingRightAttackedDodongoState(dodongo);
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
