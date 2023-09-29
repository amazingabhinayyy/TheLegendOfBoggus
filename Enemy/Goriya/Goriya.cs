using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class Goriya : IEnemy
    {
        private IEnemyState state;
        private int count;
        private bool changeDirection;
        public IEnemyState State
        {
            get { return state; }
            set { state = value; }
        }

        public Goriya()
        {
            count = 0;
            changeDirection = false;
        }
        public void Generate() {
            state = new MovingLeftGoriyaState(this);
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

        public void Shoot()
        {
            state = new ShootingStillLeftGoriyaState(this);
        }
       
        public void Update()
        {
            count++;
            if (count % 100 == 0||Globals.changeDirection)
            {
                Shoot();
                ChangeDirection();
                
            }
            state.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            state.Draw(spriteBatch);
        }
    }
}
