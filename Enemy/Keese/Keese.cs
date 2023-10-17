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
        private int positionX;
        private int positionY;
        private int currentFrame;

        public int X
        {
            get { return positionX; }
            set { positionX = value; }
        }

        public int Y
        {
            get { return positionY; }
            set { positionY = value; }
        }
        public IEnemyState State
        {
            get { return state; }
            set { state = value; }
        }
        public void Generate() { 
            state = new MovingLeftKeeseState(this);
        }
        public Keese(int x, int y)
        {
            count = 0;
            currentFrame = 0;
            this.positionX = x;
            this.positionY = y;
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
                return new Rectangle(positionX, positionY, Globals.KeeseSprite1.Width * 2, Globals.KeeseSprite1.Height *2);
            }
            else
            {
                return new Rectangle(positionX, positionY, Globals.KeeseSprite2.Width * 2, Globals.KeeseSprite2.Height * 2);
            }
        }
    }
}
