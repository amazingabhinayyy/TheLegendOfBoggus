using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy;

namespace Sprint2_Attempt3
{
    internal class GoriyaBoomerang : IEnemyProjectile
    {
        private float timeSinceLastUpdate;
        private IEnemyProjectileState state;
        private int count;

        public IEnemyProjectileState State
        {
            get { return state; }
            set { state = value; }
        }
        public void Generate() { 
            
        }
        public GoriyaBoomerang()
        {
            count = 0;
        }
       
        public void Update(GameTime gameTime)
        {
            timeSinceLastUpdate += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (timeSinceLastUpdate<0.5f)
            {
                state.Update();
            }
        }
        public void Draw(SpriteBatch spriteBatch,int x, int y)
        {
            state.Draw(spriteBatch, x, y);
        }
    }
}
