using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Enemy.Projectile
{
    public interface IEnemyProjectile
    {
        public Vector2 Position { get { return Position; } set { Position = value; } }
        //public void Generate();
        public void Update(/*GameTime gametime*/);
        public void Draw(SpriteBatch spriteBatch);
    }
}
