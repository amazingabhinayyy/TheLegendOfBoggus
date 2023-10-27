using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Stalfos;
using System;

namespace Sprint2_Attempt3.Enemy.Stalfos
{
    internal class Stalfos : EnemyC
    {
        public Stalfos(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override void Generate() {
            State = new MovingLeftStalfosState(this);
        }
        public override void Stun()
        {
            State = new StunnedStalfosState(this);
        }
        public override void MoveUp()
        {
            State = new MovingUpStalfosState(this);
        }
        public override void MoveDown()
        {
            State = new MovingDownStalfosState(this);
        }
        public override void MoveLeft()
        {
            State = new MovingLeftStalfosState(this);
        }
        public override void MoveRight()
        {
            State = new MovingRightStalfosState(this);
        }
    }
}
