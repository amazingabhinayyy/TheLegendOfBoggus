using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Enemy.Projectile.GoriyaProjectiles
{
    internal class GoriyaBoomerang : IEnemyProjectile
    {
        private float timeSinceLastUpdate;
        private IEnemyProjectileState state;
        private Vector2 position2;
        private int count;
        private bool throwing;
        public bool Throwing { get { return throwing; } set { throwing = value; } }
        private bool goLeft;
        public bool GoLeft
        {
            get { return goLeft; }
            set { goLeft = value; }
        }
        private bool goUp;
        public bool GoUp
        {
            get { return goUp; }
            set { goUp = value; }
        }
        private bool goRight;
        public bool GoRight
        {
            get { return goRight; }
            set { goRight = value; }
        }
        private bool goDown;
        public bool GoDown
        {
            get { return goDown; }
            set { goDown = value; }
        }

        private int initialX;
        public int InitialX
        {
            get { return initialX; }
            set { initialX = value; }
        }

        private int initialY;
        public int InitialY
        {
            get { return initialY; }
            set { initialY = value; }
        }

        public Vector2 Position2 { get { return position2; } set { position2 = value; } }
        public IEnemyProjectileState State
        {
            get { return state; }
            set { state = value; }
        }
        public void GenerateLeft()
        {
            state = new GoriyaBoomerangLeftState(this);
            initialX = (int)position2.X;
            goLeft = true;
        }
        public void GenerateRight()
        {
            state = new GoriyaBoomerangRightState(this);
            initialX = (int)position2.X;
            goRight = true;

        }
        public void GenerateUp()
        {
            state = new GoriyaBoomerangUpState(this);
            initialY = (int)position2.Y;
            goUp = true;
        }
        public void GenerateDown()
        {
            state = new GoriyaBoomerangDownState(this);
            initialY = (int)position2.Y;
            goDown = true;
        }
        public void ReverseBoomerang()
        {
            goUp = false;
            goDown = false;
            goRight = false;
            goLeft = false;
        }
        public GoriyaBoomerang(Vector2 boomerangPosition)
        {
            position2 = boomerangPosition;
        }

        public void Update()
        {
            state.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            state.Draw(spriteBatch);
        }
        public Rectangle GetHitBox() {
            return new Rectangle((int)position2.X, (int)position2.Y, Globals.GoriyaBoomerang1.Width * (int)Globals.scale, Globals.GoriyaBoomerang1.Height * (int)Globals.scale);
        }

    }
}
