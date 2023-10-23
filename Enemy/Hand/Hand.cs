﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Hand;
using System;

namespace Sprint2_Attempt3.Enemy.Hand
{
    internal class Hand : EnemySecondary
    {
        public Hand(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override void Generate() {
            State = new MovingLeftHandState(this);
        }
        public override void MoveUp()
        {
            State = new MovingUpHandState(this);
        }
        public override void MoveDown()
        {
            State = new MovingDownHandState(this);
        }
        public override void MoveLeft()
        {
            State = new MovingLeftHandState(this);
        }
        public override void MoveRight()
        {
            State = new MovingRightHandState(this);
        }
    }
}
