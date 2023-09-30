
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Block
{
    internal class BlockSprite
    {
        private Texture2D texture;
        public BlockSprite(Texture2D texture) { 
            this.texture = texture;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position, Rectangle sourceRectangle) {
            spriteBatch.Draw(
                texture,
                Position,
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
