using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.SpikeTrap;
using Sprint2_Attempt3.Player.LinkStates;

namespace Sprint2_Attempt3.Enemy.SpikeTrap
{
    internal class SpikeTrap : EnemyX
    {
        public static Rectangle SpikeTrapSprite { get; } = new Rectangle(1, 11, 16, 16);
        protected Vector2 spawnPoint;
        protected bool changeHorizontal;
        protected bool changeVertical;
        protected bool changeLeft;
        protected bool changeRight;
        protected bool changeUp;
        protected bool changeDown;
        protected bool start;
        public SpikeTrap(int x, int y)
        {
            this.X = x;
            this.Y = y;
            spawnPoint = new Vector2(x, y);
            State = new IdleState(this);
        }
        public override void Update() {
            State.Update();
            if(this.X == spawnPoint.X && this.Y == spawnPoint.Y)
            {
                BecomeIdle();
                start = true;
                
            }
        }
        public override void Generate() {
            State = new MovingUpSpikeTrapState(this);
        }
        public override void Stun()
        {
            //Isn't affected
        }
        public void BecomeIdle()
        {
            State = new IdleState(this);
        }
        public override void MoveUp()
        {
            if (start)
            {
                State = new MovingUpSpikeTrapState(this);
                changeVertical = true;
                start = false;
                changeHorizontal = false;
                changeDown = true;
            } else if (changeVertical && changeUp)
            {
                State = new MovingUpSpikeTrapState(this);
                changeVertical = false;
                changeUp= false;
            }
        }
        public override void MoveDown()
        {
            if (start)
            {
                State = new MovingDownSpikeTrapState(this);
                start = false;
                changeVertical = true;
                changeHorizontal = false;
                changeUp = true;
            }
            else if (changeVertical && changeDown)
            {
                State = new MovingDownSpikeTrapState(this);
                changeVertical = false;
                changeUp = false;
            }
        }
        public override void MoveLeft()
        {
            if (start)
            {
                State = new MovingLeftSpikeTrapState(this);
                changeHorizontal = true;
                changeVertical = false;
                start = false;
                changeRight= true;
            }
            else if (changeHorizontal && changeLeft)
            {
                State = new MovingLeftSpikeTrapState(this);
                changeVertical = false;
                changeLeft= false;
            }

        }
        public override void MoveRight()
        {
            if (start)
            {
                State = new MovingRightSpikeTrapState(this);
                changeHorizontal = true;
                changeVertical = false;
                start = false;
                changeLeft = true;
            }
            else if (changeHorizontal&& changeRight)
            {
                State = new MovingRightSpikeTrapState(this);
                changeVertical = true;
                changeRight = false;
            }
        }
    }
}
/*Enemy,SpikeTrap,650,89
Enemy,SpikeTrap,100,347
Enemy,SpikeTrap,650,347
*/
