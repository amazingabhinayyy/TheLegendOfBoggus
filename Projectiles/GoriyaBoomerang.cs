using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Projectiles;
using Sprint2_Attempt3.Projectile;

namespace Sprint2_Attempt3
{
    internal class GoriyaBoomerang : IEnemyProjectile
    {
        private float timeSinceLastUpdate;
        private IEnemyProjectileState state;
        private Vector2 position;
        public Vector2 Position { get { return position; } set { position = value; } }
        public IEnemyProjectileState State
        {
            get { return state; }
            set { state = value; }
        }
        public void Generate() {
            //change
            state = new MovingLeftBoomerangState(this);
        }
        public GoriyaBoomerang(int x, int y)
        {
             position = new Vector2(x, y);
        }
       
        public void Update(/*GameTime gameTime*/)
        {
            timeSinceLastUpdate += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (timeSinceLastUpdate<0.5f)
            {
                state.Update();
                timeSinceLastUpdate = 0;
            }
        }
        public void Draw(SpriteBatch spriteBatch,int x, int y)
        {
            state.Draw(spriteBatch, x, y);
        }

    }
}
