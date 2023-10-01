using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Projectiles;
using System;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class Goriya : IEnemy
    {
        private IEnemyState state;
        private int count;
        private bool changeDirection;
        private IEnemyProjectile boomerang;

        /*Might Not Need*/
        public IEnemyProjectile Boomerang
        {
            get { return boomerang; }
            set { boomerang = value; }
        }


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

        public Goriya(int x, int y)
        {
            count = 0;

            this.positionX = x;
            this.positionY = y;
            changeDirection = false;
            boomerang = new GoriyaBoomerang(positionX, positionY);
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
       
       
        public void Update()
        {
            count++;
            if (count % 100 == 0)
            {
                boomerang.Update();
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
