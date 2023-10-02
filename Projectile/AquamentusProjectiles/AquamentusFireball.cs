using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Projectile.AquamentusProjectiles
{
    internal class AquamentusFireball : IEnemyProjectile
    {
        private float timeSinceLastUpdate;
        private IEnemyProjectileState state;
        private Vector2 position2;
        private int count;

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
            state = new AquamentusFireballLeftState(this);
            initialX = (int)position2.X;
            goLeft = true;

        }
        public void GenerateRight()
        {
            state = new AquamentusFireballRightState(this);
            initialX = (int)position2.X;
            goRight = true;

        }
        public void GenerateUp()
        {
            state = new AquamentusFireballUpState(this);
            initialY = (int)position2.Y;
            goUp = true;

        }
        public void GenerateDown()
        {
            state = new AquamentusFireballDownState(this);
            initialY = (int)position2.Y;
            goDown = true;

        }
        public AquamentusFireball(Vector2 fireballPosition)
        {
            position2 = fireballPosition;


        }

        public void Update(/*GameTime gameTime*/)
        {
            /*
            timeSinceLastUpdate += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (timeSinceLastUpdate<0.5f)
            {
                state.Update();
                timeSinceLastUpdate = 0;
            }*/
            //
            
            state.Update();


        }
        public void Draw(SpriteBatch spriteBatch)
        {
            state.Draw(spriteBatch);
        }

    }
}
