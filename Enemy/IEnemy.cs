using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Enemy
{
    public interface IEnemy : IGameObject
    {
        public Rectangle Position { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Generate();
        public void Spawn();
        public void ChangeDirection();
        public void ChangeAttackedStatus();
        public void Kill();
        public void Update();
        public void Draw(SpriteBatch spriteBatch);
    }
}
