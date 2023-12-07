using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Enemy.Ganon
{
    internal class VisibleGanonSprite : IEnemySprite
    {
        private Texture2D texture;

        private float ganonScale = 0.34f;
        public VisibleGanonSprite(Texture2D texture)
        {
            this.texture = texture;
        }

        public void Update()
        {
            
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
                Globals.scale*ganonScale,
                SpriteEffects.None,
                0.1f
            );
        }
    }
}
