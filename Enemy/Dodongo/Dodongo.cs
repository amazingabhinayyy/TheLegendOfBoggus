using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Dodongo;

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
        public override void Stun()
        {
            State = new StunnedDodongoState(this);
        }
        public override void MoveUp()
        {
            State = new MovingUpDodongoState(this);
        }
        public override void MoveDown()
        {
            State = new MovingDownDodongoState(this);
        }
        public override void MoveLeft()
        {
            State = new MovingLeftDodongoState(this);
        }
        public override void MoveRight()
        {
            State = new MovingRightDodongoState(this);
        }
    }
}
