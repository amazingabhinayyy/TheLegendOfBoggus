using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Hand;
using System;

namespace Sprint2_Attempt3.Enemy.Hand
{
    internal class Hand : EnemyC
    {
        public Hand(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.health = 1.5f;
        }
        public static Rectangle[] Hands { get; } = new Rectangle[] { new Rectangle(50, 52, 17, 16), new Rectangle(68, 52, 16, 16), new Rectangle(50, 18, 17, 16), new Rectangle(68, 1, 16, 16), new Rectangle(50, 35, 17, 16) };
        public override void Generate() {
            State = new MovingLeftHandState(this);
        }
        public override void Stun()
        {
            State = new StunnedHandState(this);
        }
        public override void MoveUp()
        {
            State = new MovingUpHandState(this);
        }
        public override void MoveDown()
        {
            State = new MovingDownHandState(this);
        }
        public override void MoveLeft()
        {
            State = new MovingLeftHandState(this);
        }
        public override void MoveRight()
        {
            State = new MovingRightHandState(this);
        }
    }
}
