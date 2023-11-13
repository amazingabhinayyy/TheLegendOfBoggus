using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Dungeon.Doors.DoorSprites
{
    internal class StairEntranceSprite : IDoorSprite
    {
        private Texture2D texture;
        public StairEntranceSprite(Texture2D texture)
        {
            this.texture = texture;
        }
        public void Draw(SpriteBatch spriteBatch, Rectangle sourceRectangle, Color color)
        {
            spriteBatch.Draw(
                texture,
                Globals.FloorGrid[43],
                new Rectangle(51, 17, 16, 16),
                color,
                0f,
                new Vector2(0, 0),
                SpriteEffects.None,
                0f
            );
        }
    }
}
