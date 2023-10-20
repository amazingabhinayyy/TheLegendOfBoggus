using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Gel
{
    internal class Gel : EnemySecondary
    {
        //public new int X { get; set; }
        //public new int Y { get; set; }
        public Gel(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override void Generate() {
            State = new MovingLeftGelState(this);
        }
        public override Rectangle GetHitBox()
        {
            //System.Diagnostics.Debug.WriteLine("hitbox");
            //System.Diagnostics.Debug.WriteLine(Position.Y);
            //return new Rectangle(0, 0, 0, 0);
            //int x = State.enemy.X;
            return new Rectangle((int)Position.X, (int)Position.Y, 15 * 3, 15 * 3);
        }
    }
}
