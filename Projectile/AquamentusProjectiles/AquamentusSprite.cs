﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Projectile.AquamentusProjectiles
{
    internal class AquamentusFireballSprite : IEnemyProjectileSprite
    {
        private Texture2D texture;



        public AquamentusFireballSprite(Texture2D texture)
        {
            this.texture = texture;


        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch, int x, int y, Rectangle sourceRectangle, SpriteEffects effect, Vector2 origin)
        {
            spriteBatch.Draw(
                texture,
                new Vector2(x, y),
                sourceRectangle,
                Color.White,
                0f,
                new Vector2(0, 0),
                Globals.scale,
                effect,
                0f
            );
        }


    }
}
