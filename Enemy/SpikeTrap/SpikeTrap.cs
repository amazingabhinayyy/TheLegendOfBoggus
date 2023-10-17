using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.SpikeTrap
{
    internal class SpikeTrap : IEnemy
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
        public SpikeTrap(int x, int y)
        {
            count = 0;

            this.positionX = x;
            this.positionY = y;
        }
        public void Generate() {
            state = new MovingLeftSpikeTrapState(this);
        }
        public void Spawn()
        {
            state = new SpawnAnimationState(this);
        }
        public void Kill()
        {
        }
        public void ChangeDirection()
        {
            state.ChangeDirection();
        }
        public void ChangeAttackedStatus()
        {

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
            return new Rectangle(0, 0, 0, 0);
        }
    }
}
