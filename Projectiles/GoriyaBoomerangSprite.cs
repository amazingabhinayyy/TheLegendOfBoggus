using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class GoriyaBoomerangSprite : IEnemySprite
    {
        private Texture2D texture;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private int x;
        private int y;
        public GoriyaBoomerangSprite(Texture2D texture)
        {
            this.texture = texture;
            sourceRectangle = Globals.GoriyaBlueRight;
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
                    sourceRectangle = Globals.GoriyaBlueRight;

                }
                else
                {
                    sourceRectangle = Globals.GoriyaBlueRight2;

                }
              
            }
            else
            {
                currentFrame = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch, int x, int y, Rectangle sourceRectangle)
        {
            spriteBatch.Draw(
                texture,
                new Vector2(x, y),
                sourceRectangle,
                Color.White,
                0f,
                new Vector2(0, 0),
                Globals.scale,
                SpriteEffects.FlipHorizontally,
                0f
            );
        }
    }
}
