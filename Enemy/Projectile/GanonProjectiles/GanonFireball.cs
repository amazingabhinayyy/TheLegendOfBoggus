using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Net.Http;

namespace Sprint2_Attempt3.Enemy.Projectile.GanonProjectiles
{
    internal class GanonFireball : IEnemyProjectile
    {
        private IEnemyProjectileState state;
        private float ganonScale = 0.34f;
        public float GanonScale { get { return ganonScale; } }
        private static Rectangle GanonFireball1 { get { return new Rectangle(16, 194, 23, 27); } }
        private static Rectangle GanonFireball2 { get { return new Rectangle(44, 194, 23, 27); } }
        private static Rectangle GanonFireball3 { get { return new Rectangle(72, 194, 23, 27); } }
        private static Rectangle GanonFireball4 { get { return new Rectangle(528, 549,23, 27); } }

        public static Rectangle[] GanonFireballs { get; } = { GanonFireball1, GanonFireball2, GanonFireball3, GanonFireball4};
        public int fireBallWidth { get; } = 23;
        public int fireBallHeight { get; } = 27;
        public int fireballSpeed { get; } = 7;
        public int fireballSpriteSwitchSpeed { get; } = 40;
 
        private Vector2 position2;
        public Vector2 Position2 { get { return position2; } set { position2 = value; } }
        private Vector2 linkPosition;
        public Vector2 LinkPosition { get { return linkPosition; } set { position2 = linkPosition; } }

        private GameTime gameTime;
        public GameTime GameTime { get { return gameTime; } }

        public IEnemyProjectileState State
        {
            get { return state; }
            set { state = value; }
        }
        public void GenerateMoving()
        {
            state = new GanonFireballMovingState(this);
        }
        public void GenerateIdle()
        {
            state = new GanonFireballIdleState(this);
        }

        public void Disappear()
        {
            state = new GanonFireballDisappearState(this);
        }

        public GanonFireball(Vector2 fireballPosition, Vector2 linkPosition, GameTime gameTime)
        {
            position2 = fireballPosition;
            this.linkPosition = linkPosition;
            this.gameTime = gameTime;
            GenerateMoving();
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
            return new Rectangle((int)Position2.X, (int)Position2.Y, fireBallWidth * (int)(Globals.scale*ganonScale), fireBallHeight * (int)(Globals.scale* ganonScale));
        }

    }
}
