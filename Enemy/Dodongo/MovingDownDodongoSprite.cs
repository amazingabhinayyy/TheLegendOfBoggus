﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class MovingDownDodongoSprite : IEnemySprite
    {
        private Texture2D texture;
        private Rectangle sourceRectangle;
        private SpriteEffects spriteEffect;
        private int currentFrame;
        private int x;
        private int y;
        public MovingDownDodongoSprite(Texture2D texture)
        {
            this.texture = texture;
            sourceRectangle = Globals.DodongoDown;
            spriteEffect = SpriteEffects.None;
            currentFrame = 0;
            x = 200;
            y = 200;
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame < 30)
            {
                if (currentFrame < 15)
                {
                    spriteEffect = SpriteEffects.None;

                }
                else
                {
                    spriteEffect = SpriteEffects.FlipHorizontally;

                }
                y += 1;
            }
            else
            {
                currentFrame = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                texture,
                new Vector2(x, y),
                sourceRectangle,
                Color.White,
                0f,
                new Vector2(0, 0),
                Globals.scale,
                spriteEffect,
                0f
            );
        }
    }
}
