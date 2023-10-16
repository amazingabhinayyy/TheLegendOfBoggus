
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Enemy
{
    internal class EnemyDecorator : IEnemy
    {
        public EnemyDecorator(IEnemy enemy)
        { 
            
        }
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
        public Rectangle GetHitBox()
        {
            //To-Do fill in what hit box should be instead of 0s
            return new Rectangle(0, 0, 0, 0);
        }
    }
}
