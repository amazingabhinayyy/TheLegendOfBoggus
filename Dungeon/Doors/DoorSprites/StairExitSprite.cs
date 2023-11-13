using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Dungeon.Doors.DoorSprites
{
    internal class StairExitSprite : IDoorSprite
    {
        private Texture2D texture;
        public StairExitSprite(Texture2D texture)
        {
            this.texture = texture;
        }
        public void Draw(SpriteBatch spriteBatch, Rectangle sourceRectangle, Color color)
        {
            spriteBatch.Draw(
                texture,
                Globals.StairExitPosition,
                sourceRectangle,
                color,
                0f,
                new Vector2(0, 0),
                SpriteEffects.None,
                0f
            );
        }
        public void Draw(SpriteBatch spriteBatch, Rectangle sourceRectangle, Vector2 change)
        {
            Rectangle newSourceRectangle = new Rectangle(sourceRectangle.X, sourceRectangle.Y, sourceRectangle.Width, sourceRectangle.Height);
            Rectangle destinationRectangle = new Rectangle(Globals.EastDoorPosition.X + (int)(change.X * 3.125), Globals.EastDoorPosition.Y + (int)(change.Y * 3.125), 100, 94);
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
        }

        public void Draw(SpriteBatch spriteBatch, Rectangle sourceRectangle, Vector2 change, Vector2 initialPos)
        {
            Rectangle newSourceRectangle = new Rectangle(sourceRectangle.X, sourceRectangle.Y, sourceRectangle.Width, sourceRectangle.Height);
            Rectangle destinationRectangle = new Rectangle((int)(Globals.EastDoorPosition.X + change.X * 3.125 + initialPos.X), (int)(Globals.EastDoorPosition.Y + change.Y * 3.125 + initialPos.Y), 100, 94);
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
