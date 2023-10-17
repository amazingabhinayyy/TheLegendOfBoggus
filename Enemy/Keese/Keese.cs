using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy;
using System;

namespace Sprint2_Attempt3.Enemy.Keese
{
    internal class Keese : EnemySecondary
    {
        public Keese(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override void Generate()
        {
            State = new MovingLeftKeeseState(this);
        }
        public override Rectangle GetHitBox()
        {
            return new Rectangle(X, Y, Globals.KeeseSprite2.Width, Globals.KeeseSprite2.Height);
        }
    }
}
