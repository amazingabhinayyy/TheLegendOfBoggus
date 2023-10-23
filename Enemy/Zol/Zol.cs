using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Zol
{
    internal class Zol : EnemySecondary
    {
        public Zol(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override void Generate() {
            State = new MovingLeftZolState(this);
        }
        public override void MoveUp() {
            State = new MovingUpZolState(this);
        }
        public override void MoveDown() {
            State = new MovingDownZolState(this);
        }
        public override void MoveLeft() {
            State = new MovingLeftZolState(this);
        }
        public override void MoveRight() {
            State = new MovingRightZolState(this);
        }
    }
}
