using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Dungeon.Doors.DoorSprites
{
    internal class NorthDoorSprite : IDoorSprite
    {
        private Texture2D texture;
        public NorthDoorSprite(Texture2D texture)
        {
            this.texture = texture;
        }
        public void Draw(SpriteBatch spriteBatch, Rectangle sourceRectangle, Color color)
        {
            spriteBatch.Draw(
                texture,
                Globals.NorthDoorPosition,
                sourceRectangle,
                color,
                0f,
                new Vector2(0, 0),
                SpriteEffects.None,
                0f
            );
        }
    }
}
