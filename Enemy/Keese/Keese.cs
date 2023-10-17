using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Collision;

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
        private int currentFrame;

        public void Generate() { 
            state = new MovingLeftKeeseState(this);
        }
        public Keese(int x, int y)
        {
            count = 0;
            X = x;
            Y = y;
            currentFrame = 0;
        }
        public void Spawn()
        {
            state = new SpawnAnimationState(this);
            CollisionDetector.GameObjectList.Add(this);

        }
        public void Kill()
        {
            state = new DeathAnimationState(this);
            CollisionDetector.GameObjectList.Remove(this);
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

            if (currentFrame < 30)
                currentFrame++;
            else
                currentFrame = 0;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            state.Draw(spriteBatch);
        }
        public Rectangle GetHitBox()
        {
            if (currentFrame < 15)
            {
                return new Rectangle(this.X, this.Y, Globals.KeeseSprite1.Width * 2, Globals.KeeseSprite1.Height *2);
            }
            else
            {
                return new Rectangle(this.X, this.Y, Globals.KeeseSprite2.Width * 2, Globals.KeeseSprite2.Height * 2);
            }
        }
    }
}
