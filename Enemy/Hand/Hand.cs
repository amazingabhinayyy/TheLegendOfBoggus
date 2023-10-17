using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.Hand
{
    internal class Hand : EnemySecondary
    {
        public Hand(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override void Generate() {
            State = new MovingLeftHandState(this);
        }
        public Rectangle GetHitBox()
        {
            return new Rectangle(0, 0, 0, 0);
        }
    }
}
