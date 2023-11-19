using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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
        public ISpikeTrapState state { get; set; }
        public SpikeTrap(int x, int y)
        {
            this.X = x;
            this.Y = y;
            spawnPoint = new Vector2(x, y);
            state = new IdleState(this);
        }
        public override void Update() {
            state.Update();
            
            if(Y < 275)
            {
                Y = (int)spawnPoint.Y;
                BecomeIdle();
                start = true;
                
            }
            
        }
        public override void Generate() {
            state = new IdleState(this);
        }
        public override void Stun()
        {
            //Isn't affected
        }
        public void BecomeIdle()
        {
            state.BecomeIdle();
        }
        public override void MoveUp()
        {
            state.MoveUp();
            /*
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
            */
        }
        public override void MoveDown()
        {
            state.MoveDown();
            /*
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
            */
        }
        public override void MoveLeft()
        {
            state.MoveLeft();
            /*
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
            */
        }
        public override void MoveRight()
        {
            state.MoveRight();
            /*
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
            */
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            state.Draw(spriteBatch);
        }
    }
}
/*Enemy,SpikeTrap,650,89
Enemy,SpikeTrap,100,347
Enemy,SpikeTrap,650,347
*/
