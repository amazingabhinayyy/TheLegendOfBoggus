using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Enemy.SpikeTrap
{
    internal class SpikeTrap : EnemySecondary
    {
        public SpikeTrap(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override void Update() { }
        public override void Generate() {
            State = new MovingLeftSpikeTrapState(this);
        }
        public override Rectangle GetHitBox()
        {
            return new Rectangle (X,Y,0,0);
        }
    }
}
