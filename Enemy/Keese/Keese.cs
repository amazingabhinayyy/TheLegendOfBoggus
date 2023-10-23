using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Collision;
using System;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Keese
{
    internal class Keese : EnemySecondary
    {
        public Keese(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override void Generate()
        {
            State = new MovingLeftKeeseState(this);
        }
        public override void MoveUp()
        {
            State = new MovingUpKeeseState(this);
        }
        public override void MoveDown()
        {
            State = new MovingDownKeeseState(this);
        }
        public override void MoveLeft()
        {
            State = new MovingLeftKeeseState(this);
        }
        public override void MoveRight()
        {
            State = new MovingRightKeeseState(this);
        }
    }
}
