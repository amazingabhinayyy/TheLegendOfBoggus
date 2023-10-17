using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class MovingDownAttackedDodongoState : IEnemyState
    {
        private Dodongo dodongo;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        public MovingDownAttackedDodongoState(Dodongo dodongo)
        {
            this.dodongo = dodongo;
            sprite = EnemySpriteFactory.Instance.CreateDodongoSprite();
            sourceRectangle = Globals.DodongoDownAttacked;
            dodongo.Position = new Rectangle(dodongo.X, dodongo.Y, sourceRectangle.Width, sourceRectangle.Height);
        }
        public void ChangeDirection()
        {
        }
        public void ChangeAttackedStatus() {
            dodongo.State = new MovingDownDodongoState(dodongo);
        }
        public void Update()
        {
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, dodongo.X, dodongo.Y, sourceRectangle);
        }
    }
}
