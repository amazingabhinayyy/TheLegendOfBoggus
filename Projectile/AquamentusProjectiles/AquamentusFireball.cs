﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Projectile.AquamentusProjectiles
{
    internal class AquamentusFireball : IEnemyProjectile
    {
        private float timeSinceLastUpdate;
        private IEnemyProjectileState state;
        private Vector2 position2;
        public Vector2 Position2 { get { return position2; } set { position2 = value; } }
        private int count;
        private bool fire;
        public bool Fire { get { return fire; } set { fire = value; } }



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
     
        public AquamentusFireball(Vector2 fireballPosition)
        {
            position2 = fireballPosition;
            fire = false;

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
