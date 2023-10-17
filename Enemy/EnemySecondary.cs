using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Enemy
{
    public abstract class EnemySecondary : IEnemy
    {
        protected int count;
        protected int currentFrame;
        private int distance;
        private Random random;
        public int X { get; set; }
        public int Y { get; set; }
        public IEnemyState State { get; set; }

        public abstract void Generate();
        public EnemySecondary()
        {
            random = new Random();
            distance = random.Next(50, 200);
            count = 0;
            currentFrame = 0;
        }
        public void Spawn()
        {
            State = new SpawnAnimationState(this);
        }
        public void Kill()
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
                distance = random.Next(50, 200);
                count = 0;
                
            }
            State.Update();
        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            State.Draw(spriteBatch);
        }
        public abstract Rectangle GetHitBox();
    }
}
