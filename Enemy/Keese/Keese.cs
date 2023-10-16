using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy;

namespace Sprint2_Attempt3.Enemy.Keese
{
    internal class Keese : IEnemy
    {
        private IEnemyState state;
        private int count;
        public int X { get; set; }
        public int Y { get; set; }
        public Rectangle Position => new Rectangle(this.X, this.Y, Globals.KeeseSprite2.Width, Globals.KeeseSprite2.Height);
        public IEnemyState State { get; set; }

        public void Generate() { 
            state = new MovingLeftKeeseState(this);
        }
        public Keese(int x, int y)
        {
            count = 0;
            X = x;
            Y = y;
        }
        public void Spawn()
        {
            state = new SpawnAnimationState(this);
        }
        public void Kill()
        {
            state = new DeathAnimationState(this);
        }
        public void ChangeDirection()
        {
            state.ChangeDirection();
        }
        public void ChangeAttackedStatus()
        {
            state.ChangeAttackedStatus();
        }
        public void Update()
        {
            count++;
            if (count % 100 == 0)
            {
                state.ChangeDirection();
            }
            state.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            state.Draw(spriteBatch);
        }
        public Rectangle GetHitBox()
        {
            if (currentFrame < 15)
            {
                return new Rectangle(positionX, positionY, Globals.KeeseSprite1.Width, Globals.KeeseSprite1.Height);
            }
            else
            {
                return new Rectangle(positionX, positionY, Globals.KeeseSprite2.Width, Globals.KeeseSprite2.Height);
            }
        }
    }
}
