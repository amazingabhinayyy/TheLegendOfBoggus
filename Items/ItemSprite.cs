using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Items;

namespace Sprint2_Attempt3.Item
{
    internal class ItemSprite : IItemSprite
    {
        private Texture2D texture;
        public ItemSprite(Texture2D texture)
        {
            this.texture = texture;
        }
        public void Draw(SpriteBatch spriteBatch, Rectangle position, Rectangle sourceRectangle) { 
            spriteBatch.Draw(
                    texture,
                    position,
                    sourceRectangle,
                    Color.White,
                    0f,
                    new Vector2(0, 0),
                    SpriteEffects.None,
                    0f
                );
        }
    }
}
