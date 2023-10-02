using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Projectile;
using System;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class Goriya : IEnemy
    {
        private IEnemyState state;
        private int count;
        private int idleX;
        public static bool end;
        public bool End
        {
            get { return end; }
            set { end = value; }
        }
        public int IdleX
        {
            get { return idleX; }
            set { idleX = value; }
        }

        private IEnemyProjectile boomerang;
        private Vector2 boomerangPosition;
        public Vector2 BoomerangPosition
        {
            get { return boomerangPosition; }
            set { boomerangPosition = value;}
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
            end = false;
            boomerangPosition = new Vector2(positionX, positionY);
            boomerang = new GoriyaBoomerang(boomerangPosition);
            direction = ProjectileDirection.Left;   
            
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
        /*
        public void AttackWithBoomerang()
        {
            //Need to change so can go with different states 
            boomerangPosition = new Vector2(X, Y);
            boomerang = new GoriyaBoomerang(boomerangPosition);
            state = new AttackWithBoomerangState(this);

        }*/


        public void Update()
        {
            count++;
            if (count % 100 == 0||end)
            {
                //((GoriyaBoomerang)boomerang).Finished = false;
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
