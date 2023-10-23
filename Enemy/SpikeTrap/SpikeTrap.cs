using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.SpikeTrap;

namespace Sprint2_Attempt3.Enemy.SpikeTrap
{
    internal class SpikeTrap : EnemySecondary
    {
        public SpikeTrap(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override void Update() {
            State.Update();
        }
        public override void Generate() {
            State = new MovingUpSpikeTrapState(this);
        }
        public override void MoveUp()
        {
            State = new MovingUpSpikeTrapState(this);
        }
        public override void MoveDown()
        {
            State = new MovingDownSpikeTrapState(this);
        }
        public override void MoveLeft()
        {
            State = new MovingLeftSpikeTrapState(this);
        }
        public override void MoveRight()
        {
            State = new MovingRightSpikeTrapState(this);
        }
    }
}
