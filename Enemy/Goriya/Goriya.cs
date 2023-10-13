using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Enemy.Projectile.GoriyaProjectiles;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class Goriya : IEnemy
    {
        private IEnemyState state;
       
        private int idleX;
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

            this.positionX = x;
            this.positionY = y;
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
     


        public void Update()
        {
            
            state.Update();
            if (((GoriyaBoomerang)boomerang).Throwing)
            {
                boomerang.Update();
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            state.Draw(spriteBatch);
            if (((GoriyaBoomerang)boomerang).Throwing)
            {
                boomerang.Draw(spriteBatch);
            }
        }
    }
}
