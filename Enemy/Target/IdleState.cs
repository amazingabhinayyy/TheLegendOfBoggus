using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;
using System;

namespace Sprint2_Attempt3.Enemy.Target
{
    internal class IdleState : ITargetState
    {
        private Target target;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        public IdleState(Target target)
        {
            this.target = target;
            sprite = EnemySpriteFactory.Instance.CreateTargetSprite();
            sourceRectangle = Target.TargetSprite;
            target.Position = new Rectangle(target.X, target.Y, 45, 45);
        }
        public void ChangeDirection()
        {
        }
        public void BecomeIdle() { }
        public void MoveLeft()
        {
            target.state = new MovingLeftTargetState(target);
        }
        public void MoveRight()
        {
            target.state = new MovingRightTargetState(target);
        }
        public void MoveUp()
        {
            target.state = new MovingUpTargetState(target);
        }
        public void MoveDown()
        {
            target.state = new MovingDownTargetState(target);
        }
        public void ChangeAttackedStatus() {

        }
        public void Update()
        {
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, target.X, target.Y, sourceRectangle);
        }
    }
}
