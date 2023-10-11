﻿using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.Stalfos
{
    internal class Stalfos : IEnemy
    {
        private IEnemyState state;
        private int count;
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

        public Stalfos(int x, int y)
        {
            count = 0;

            this.positionX = x;
            this.positionY = y;
        }
        public void Generate() {
            state = new MovingLeftStalfosState(this);
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
            if (count % 100 == 0||Globals.changeDirection)
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