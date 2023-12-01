using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.SpikeTrap;
using Sprint2_Attempt3.Player.LinkStates;

namespace Sprint2_Attempt3.Enemy.Target
{
    internal class Target : EnemyX
    {
        public static Rectangle TargetSprite { get; } = new Rectangle(93, 76, 173, 159);
        protected Vector2 spawnPoint;
        public ITargetState state { get; set; }
        public Target(int x, int y, bool direction)
        {
            this.X = x;
            this.Y = y;
            this.health = 0.5f;
            spawnPoint = new Vector2(x, y);
            if (direction)
            {
                state = new MovingRightTargetState(this);
            }
            else
            {
                state = new MovingLeftTargetState(this);
            }
        }
        public override void Update() {
            state.Update();            
        }
        public override void Generate() {
            state = new IdleState(this);
        }
        public override void MoveUp()
        {
            //may use this
        }
        public override void MoveDown()
        {
            //may use this
        }
        public override void Stun()
        {
            //will never use this
        }
        public override void MoveLeft()
        {
            state.MoveLeft();
        }
        public override void MoveRight()
        {
            state.MoveRight();
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            state.Draw(spriteBatch);
        }
    }
}

