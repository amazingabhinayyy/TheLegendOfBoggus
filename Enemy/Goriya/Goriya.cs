using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Enemy.Projectile.GoriyaProjectiles;
using Sprint2_Attempt3.Enemy.Goriya;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class Goriya : EnemySecondary
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

        public Goriya(int x, int y)
        {

            this.X = x;
            this.Y = y;
            BoomerangPosition = new Vector2(X, Y);
            Boomerang = new GoriyaBoomerang(BoomerangPosition);
            Direction = ProjectileDirection.Left;   
            
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
            
            State.Update();
            if (((GoriyaBoomerang)Boomerang).Throwing)
            {
                Boomerang.Update();
            }
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
    }
}
