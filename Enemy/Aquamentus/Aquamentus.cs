using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Items;
using System;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles;

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
        public static bool end;
        public bool End
        {
            get { return end; }
            set { end = value; }
        }
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
            end = false;
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
            state.ChangeAttackedStatus();
        }
       


        public void Update()
        {
            state.Update();
            if (((AquamentusFireball)fireball).Fire)
            {
                fireball.Update();
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            state.Draw(spriteBatch);
            if (((AquamentusFireball)fireball).Fire)
            {
            fireball.Draw(spriteBatch);
            }
        }
        public Rectangle GetHitBox()
        {
            return new Rectangle(positionX, positionY, Globals.AquamentusGreenLeft.Width, Globals.AquamentusGreenLeft.Height);
        }
    }
}
