using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class MovingUpAttackedDodongoState : IEnemyState
    {
        private Dodongo dodongo;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        public MovingUpAttackedDodongoState(Dodongo dodongo)
        {
            this.dodongo = dodongo;
            sprite = EnemySpriteFactory.Instance.CreateDodongoSprite();
            sourceRectangle = Globals.DodongoUpAttacked;
            dodongo.Position = new Rectangle(dodongo.X, dodongo.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));

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
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, dodongo.X, dodongo.Y, sourceRectangle);
        }
    }
}
