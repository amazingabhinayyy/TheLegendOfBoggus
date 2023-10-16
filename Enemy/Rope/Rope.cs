using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Rope
{
    internal class Rope : IEnemy
    {
        private IEnemyState state;
        private int count;
        public IEnemyState State
        {
            get { return state; }
            set { state = value; }
        }
        private int positionX;
        private int positionY;

        public Rectangle GetHitBox()
        {
            return new Rectangle(0, 0, 0, 0);
        }

        public int X
        {
            get { return positionX; }
            set { positionX = value; }
        }

        public int Y
        {
            get { return positionY; }
            set { positionY = value; }
        }

        public Rope(int x, int y)
        {
            count = 0;

            this.positionX = x;
            this.positionY = y;
        }
        public void Generate() {
            state = new MovingLeftRopeState(this);
        }
        public void Spawn()
        {
            state = new SpawnAnimationState(this);
        }
        public void Kill()
        {
            state = new DeathAnimationState(this);
        }
        public void ChangeDirection()
        {
            state.ChangeDirection();
        }
        public void ChangeAttackedStatus()
        {
            state = new DeathAnimationState(this);
        }
        public void Update()
        {
            count++;
            if (count % 100 == 0)
            {
                state.ChangeDirection();
            }
            state.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            state.Draw(spriteBatch);
        }
    }
}
