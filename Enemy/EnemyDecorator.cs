

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Enemy
{
    internal class EnemyDecorator : IEnemy
    {
        public EnemyDecorator(IEnemy enemy)
        { 
            
        }

        public Rectangle GetHitBox()
        {
            return new Rectangle(0, 0, 0, 0);
        }
        public int X { get; set; }
        public int Y { get; set; }

        void IEnemy.ChangeAttackedStatus()
        {
            
        }

        void IEnemy.ChangeDirection()
        {
            
        }

        void IEnemy.Draw(SpriteBatch spriteBatch)
        {
            
        }

        void IEnemy.Generate()
        {
            
        }

        void IEnemy.Kill()
        {
            
        }

        void IEnemy.Spawn()
        {
            
        }

        void IEnemy.Update()
        {
            
        }
    }
}
