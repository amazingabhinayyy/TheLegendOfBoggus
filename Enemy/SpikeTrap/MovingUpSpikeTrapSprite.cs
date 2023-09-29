using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Enemy.SpikeTrap
{
    internal class MovingUpSpikeTrapSprite : IEnemySprite
    {
        private Texture2D texture;
        private Rectangle sourceRectangle;
        private int x;
        private int y;
        public MovingUpSpikeTrapSprite(Texture2D texture)
        {
            this.texture = texture;
            sourceRectangle = Globals.SpikeTrapSprite;
            x = 200;
            y = 200;
        }

        public void Update()
        {
            y -= 1;
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
                SpriteEffects.None,
                0f
            );
        }
    }
}
