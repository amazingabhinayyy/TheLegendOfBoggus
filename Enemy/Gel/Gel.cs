using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Gel
{
    internal class Gel : IEnemy
    {
        private IEnemyState state;
        private int count;
        public IEnemyState State
        {
            get { return state; }
            set { state = value; }
        }

        public Gel()
        {
            count = 0;
        }
        public void Generate() {
            state = new MovingLeftGelState(this);
        }
        public void Spawn() { 
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
