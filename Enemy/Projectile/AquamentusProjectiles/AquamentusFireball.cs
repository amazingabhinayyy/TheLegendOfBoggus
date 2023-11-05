using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Net.Http;
using Sprint2_Attempt3.Collision;

namespace Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles
{
    internal class AquamentusFireball : IEnemyProjectile
    {
        private IEnemyProjectileState state;
        private Vector2 position2;
        public Vector2 Position2 { get { return position2; } set { position2 = value; } }
        private int count;
        private bool fire;
        public bool Fire { get { return fire; } set { fire = value; } }
        private int HitBoxWidth = 9;
        private int HitBoxHeight = 11;

        public IEnemyProjectileState State
        {
            get { return state; }
            set { state = value; }
        }
        public void GenerateLeft()
        {
            state = new AquamentusFireballLeftState(this);
        }
        public void GenerateRight()
        {
            state = new AquamentusFireballRightState(this);
        }
        public void GenerateTopRight()
        {
            state = new AquamentusFireballTopRightState(this);
        }
        public void GenerateBottomRight()
        {
            state = new AquamentusFireballBottomRightState(this);
        }
        public void GenerateTopLeft()
        {
            state = new AquamentusFireballTopLeftState(this);
        }
        public void GenerateBottomLeft()
        {
            state = new AquamentusFireballBottomLeftState(this);
        }

        public AquamentusFireball(Vector2 fireballPosition)
        {
            position2 = fireballPosition;
            fire = false;
        }
        public void Collided()
        {
            CollisionDetector.GameObjectList.Remove(this);
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
            return new Rectangle((int)Position2.X, (int)Position2.Y, Globals.AquamentusFireball1.Width * (int)Globals.scale, Globals.AquamentusFireball1.Height * (int)Globals.scale);
        }
    }
}
