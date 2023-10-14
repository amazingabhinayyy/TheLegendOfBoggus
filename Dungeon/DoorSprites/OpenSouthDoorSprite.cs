using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Dungeon.DoorSprites
{
    internal class OpenSouthDoorSprite : IDoorSprite
    {
        private Texture2D texture;
        public OpenSouthDoorSprite(Texture2D texture) { 
            this.texture = texture;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                texture,
                Globals.SouthDoorPosition,
                Globals.OpenSouthDoor,
                Color.White,
                0f,
                new Vector2(0, 0),
                SpriteEffects.None,
                0f
            );
        }
    }
}
