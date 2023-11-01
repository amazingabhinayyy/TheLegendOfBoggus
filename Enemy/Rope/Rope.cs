using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;

namespace Sprint2_Attempt3.Enemy.Rope
{
    internal class Rope : EnemyC
    {
        public Rope(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override void Generate() {
            State = new MovingLeftRopeState(this);
        }
        public override void Stun()
        {
            State = new StunnedRopeState(this);
        }
        public override void MoveUp()
        {
            State = new MovingUpRopeState(this);
        }
        public override void MoveDown()
        {
            State = new MovingDownRopeState(this);
        }
        public override void MoveLeft()
        {
            State = new MovingLeftRopeState(this);
        }
        public override void MoveRight()
        {
            State = new MovingRightRopeState(this);
        }
    }
}
