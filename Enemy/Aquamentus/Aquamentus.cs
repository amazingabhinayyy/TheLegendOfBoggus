using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Projectile;
using System;

namespace Sprint2_Attempt3.Enemy.Aquamentus
{
    internal class Aquamentus : IEnemy
    {
        private IEnemyState state;
        public IEnemyState State
        {
            get { return state; }
            set { state = value; }
        }

        private int count;
       
        private IEnemyProjectile fireball;
        public IEnemyProjectile Fireball
        {
            get { return fireball; }
            set { fireball = value; }
        }

        private Vector2 fireballPosition;
        public Vector2 FireballPosition
        {
            get { return fireballPosition; }
            set { fireballPosition = value;}
        }

        /*can I make this private*/
        public enum ProjectileDirection
        {
            Left, Top, Right, Bottom
        }
        private ProjectileDirection direction;
        public ProjectileDirection Direction
        {
            get { return direction; }
            set { direction = value; }
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

        public Aquamentus(int x, int y)
        {
            count = 0;

            this.positionX = x;
            this.positionY = y;
            fireballPosition = new Vector2(positionX, positionY);
            fireball = new AquamentusFireball(fireballPosition);
            direction = ProjectileDirection.Left;   
            
        }
        public void Generate() {
            state = new MovingLeftAquamentusState(this);
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
            /*change*/
            state.ChangeAttackedStatus();
        }
       


        public void Update()
        {
            count++;
            if (count % 100 == 0/*||end*/)
            {
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
