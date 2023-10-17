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

        public override Rectangle GetHitBox()
        {
            return new Rectangle(X,Y,0,0);
        }
    }
}
