using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;
using Sprint2_Attempt3.Collision;

namespace Sprint2_Attempt3.Enemy
{
    public abstract class EnemySecondary : IEnemy
    {
        protected int count;
        protected int currentFrame;
        private int distance;
        private Random random;
        public bool exists { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public IEnemyState State { get; set; }
        public Rectangle Position { get; set; }

        public abstract void Generate();
        public abstract void Stun();
        public abstract void DropItem();
        public EnemySecondary()
        {
            random = new Random();
            distance = random.Next(50, 200);
            count = 0;
            currentFrame = 0;
            exists = true;
        }
        public void Spawn()
        {
            State = new SpawnAnimationState(this);
        }
        public virtual void Kill()
        {
            State = new DeathAnimationState(this);
        }
        public void ChangeDirection()
        {
            State.ChangeDirection();
        }
        public void ChangeAttackedStatus()
        {
            State.ChangeAttackedStatus();
        }
        public virtual void Update()
        {
            count++;
            if (count == distance)
            {
                State.ChangeDirection();
                distance = random.Next(100, 400);
                count = 0;
                
            }
            State.Update();
        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if (exists)
            {
                State.Draw(spriteBatch);
            }
        }
        public Rectangle GetHitBox() {
            return Position;
        }

        public abstract void MoveUp();
        public abstract void MoveDown();
        public abstract void MoveLeft();
        public abstract void MoveRight();
    }
}
