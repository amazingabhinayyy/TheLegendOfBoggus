using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class Dodongo : IEnemy
    {
        private IEnemyState state;
        private int count;
        private int positionX;
        private int positionY;

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
        public IEnemyState State
        {
            get { return state; }
            set { state = value; }
        }
        public void Generate() { 
            state = new MovingLeftDodongoState(this);
        }
        public Dodongo(int x, int y)
        {
            count = 0;

            this.positionX = x;
            this.positionY = y;
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
            state.ChangeAttackedStatus();
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
        public Rectangle GetHitBox()
        {
            //To-Do fill in what hit box should be instead of 0s
            return new Rectangle(0, 0, 0, 0);
        }
    }
}
