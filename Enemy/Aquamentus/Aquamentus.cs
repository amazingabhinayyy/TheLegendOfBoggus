using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Items;
using System;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles;

namespace Sprint2_Attempt3.Enemy.Aquamentus
{
    internal class Aquamentus : EnemySecondary
    {
        public static bool end;
        public bool End { get; set; }
        public IEnemyProjectile Fireball { get; set; }
        public Vector2 FireballPosition { get; set; }
        public ProjectileDirection Direction { get; set; }

        /*can I make this private*/
        public enum ProjectileDirection
        {
            Left, Top, Right, Bottom
        }
        public Aquamentus(int x, int y)
        {
            end = false;
            this.X = x;
            this.Y = y;
            FireballPosition = new Vector2(X, Y);
            Fireball = new AquamentusFireball(FireballPosition);
            Direction = ProjectileDirection.Left;      
        }

        public override void Generate() {
            State = new MovingLeftAquamentusState(this);
        }

        public override void Update()
        {
            State.Update();
            if (((AquamentusFireball)Fireball).Fire)
            {
                Fireball.Update();
            }
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            State.Draw(spriteBatch);
            if (((AquamentusFireball)Fireball).Fire)
            {
            Fireball.Draw(spriteBatch);
            }
        }
    }
}
