﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Gel
{
    internal class Gel : EnemySecondary
    {
        public Gel(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override void Generate() {
            State = new MovingLeftGelState(this);
        }
        public Rectangle GetHitBox()
        {
            //To-Do fill in what hit box should be instead of 0s
            return new Rectangle(0, 0, 0, 0);
        }
    }
}
