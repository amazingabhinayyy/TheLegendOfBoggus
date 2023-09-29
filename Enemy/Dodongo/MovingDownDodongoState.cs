using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class MovingDownDodongoState : IEnemyState
    {
        private Dodongo dodongo;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;

        public MovingDownDodongoState(Dodongo dodongo)
        {
            this.dodongo = dodongo;
            sprite = EnemySpriteFactory.Instance.CreateMovingVerticallyDodongoSprite();
            sourceRectangle = Globals.DodongoDown;
        }
        public void ChangeDirection()
        {
            dodongo.State = new MovingLeftDodongoState(dodongo);
        }
        public void ChangeAttackedStatus() {
            dodongo.State = new MovingDownAttackedDodongoState(dodongo);
        }
        public void Update()
        {
            dodongo.Y += 1;
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, dodongo.X, dodongo.Y, sourceRectangle);
        }
    }
}
