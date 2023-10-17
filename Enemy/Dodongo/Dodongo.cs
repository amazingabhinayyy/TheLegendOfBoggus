using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class Dodongo : EnemySecondary
    {
        public Dodongo(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override void Generate()
        {
            State = new MovingLeftDodongoState(this);
        }
        public override Rectangle GetHitBox()
        {
            return new Rectangle(X, Y, Globals.DodongoDown.Width, Globals.DodongoDown.Height);
        }
    }
}
