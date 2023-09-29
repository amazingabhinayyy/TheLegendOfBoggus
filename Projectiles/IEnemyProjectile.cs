using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Enemy
{
    public interface IEnemyProjectile
    {
        public void Generate();
        public void Update(GameTime gametime);
        public void Draw(SpriteBatch spriteBatch, int x, int y);
    }
}
