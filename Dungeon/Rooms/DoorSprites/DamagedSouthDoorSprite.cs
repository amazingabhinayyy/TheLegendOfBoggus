using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Dungeon.Rooms;

namespace Sprint2_Attempt3.Dungeon.Rooms.DoorSprites
{
    internal class DamagedSouthDoorSprite : IDoorSprite
    {
        private Texture2D texture;
        public DamagedSouthDoorSprite(Texture2D texture)
        {
            this.texture = texture;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                texture,
                Globals.SouthDoorPosition,
                Globals.DamagedSouthDoor,
                Color.White,
                0f,
                new Vector2(0, 0),
                SpriteEffects.None,
                0f
            );
        }
    }
}
