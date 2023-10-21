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
            //To-Do fill in what hit box should be instead of 0s
            return new Rectangle(0, 0, 0, 0);
            //return new Rectangle((int)Position.X, (int)Position.Y, 15 * 3, 15 * 3);
        }
    }
}
