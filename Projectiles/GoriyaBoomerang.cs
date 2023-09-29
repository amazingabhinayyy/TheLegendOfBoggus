using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy;

namespace Sprint2_Attempt3
{
    internal class GoriyaBoomerang : IEnemyProjectile
    {
        priate float timeSinceLastUpdate;
        private IEnemyProjectile state;


        public IEnemyProjectileState State
        {
            get { return state; }
            set { state = value; }
        }
        public void Generate() { 
            state = new MovingLeftKeeseState(this);
        }
        public GoriyaBoomerang()
        {
            count = 0;
        }
       
        public void Update(GameTime gametime)
        {
            timeSinceLastUpdate += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (timeSinceLastUpdate<0.5f)
            {
                state.Update();
            }
        }
        public void Draw(SpriteBatch spriteBatch,int x, int y)
        {
            state.Draw(spriteBatch);
        }
    }
}
