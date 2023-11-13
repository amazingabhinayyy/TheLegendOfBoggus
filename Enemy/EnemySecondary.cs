﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Sounds;

namespace Sprint2_Attempt3.Enemy
{
    public abstract class EnemySecondary : IEnemy
    {
        protected int count;
        protected int currentFrame;
        public int AnimateRate { get; } = 15;
        public int DamageAnimateRate { get; } = 15;
        private int distance;
        private Random random;
        protected float health;
        public bool exists { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public IEnemyState State { get; set; }
        public Rectangle Position { get; set; }
        private int invinciblityTimer;

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
            invinciblityTimer = 0;
        }
        public void Spawn()
        {
            State = new SpawnAnimationState(this);
        }
        public virtual void Kill()
        {
            State = new DeathAnimationState(this);
        }

        public virtual void GetDamaged(float damage)
        {
            this.ChangeAttackedStatus();
            health -= damage;
            

            if (health <= 0)
            {
                Kill();
            }
            else
            {
                SoundFactory.PlaySound(SoundFactory.Instance.enemyHit);
            }
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
