using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Enemy.Projectile.GoriyaProjectiles;
using Sprint2_Attempt3.Enemy.Goriya;
using Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles;
using System;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class Goriya : EnemyB
    {
        public int IdleX { get; set; }
        public Vector2 BoomerangPosition { get; set; }
        public ProjectileDirection Direction { get; set; }
        public IEnemyProjectile Boomerang { get; set; }

        /*can I make this private*/
        public enum ProjectileDirection
        {
            Left, Top, Right, Bottom
        }
        private int distance;
        private Random random;

        public Goriya(int x, int y)
        {

            this.X = x;
            this.Y = y;
            BoomerangPosition = new Vector2(X, Y);
            Boomerang = new GoriyaBoomerang(BoomerangPosition);
            Direction = ProjectileDirection.Left;
            random = new Random();
            distance = random.Next(0, 70);
        }
        public override void Generate() {
            State = new MovingLeftGoriyaState(this);
        }
        public override void Stun()
        {
            State = new StunnedGoriyaState(this);
        }
        public override void Update()
        {
            
           
            if (((GoriyaBoomerang)Boomerang).Throwing)
            {
                Boomerang.Update();
            }
            count++;
            if (count >= distance && (!((GoriyaBoomerang)Boomerang).Throwing))
            {
                State.ChangeDirection();
                distance = random.Next(0, 70);
                count = 0;

            }
            State.Update();
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            State.Draw(spriteBatch);
            if (((GoriyaBoomerang)Boomerang).Throwing)
            {
                Boomerang.Draw(spriteBatch);
            }
        }
        public override void MoveUp()
        {
            State = new MovingUpGoriyaState(this);
        }
        public override void MoveDown()
        {
            State = new MovingDownGoriyaState(this);
        }
        public override void MoveLeft()
        {
            State = new MovingLeftGoriyaState(this);
        }
        public override void MoveRight()
        {
            State = new MovingRightGoriyaState(this);
        }
        public override void Kill()
        {
            base.Kill();
            CollisionDetector.GameObjectList.Remove(Boomerang);
        }
    }
}
