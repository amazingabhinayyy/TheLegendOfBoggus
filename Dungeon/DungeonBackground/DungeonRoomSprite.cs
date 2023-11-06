using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    internal class DungeonRoomSprite
    {
        Texture2D texture;
        public DungeonRoomSprite(Texture2D texture)
        {
            this.texture = texture;
        }
        public void Draw(SpriteBatch spriteBatch, Rectangle sourceRectangle)
        {
            spriteBatch.Draw(
                texture,
                new Rectangle(0, 175, Globals.ScreenWidth, 550),
                sourceRectangle,
                Color.White,
                0f,
                new Vector2(0, 0),
                SpriteEffects.None,
                0f
            );
        }
        public void Draw(SpriteBatch spriteBatch, Rectangle sourceRectangle,Vector2 change)
        {
            Rectangle newSourceRectangle = new Rectangle(sourceRectangle.X, sourceRectangle.Y, sourceRectangle.Width- (int)change.X, sourceRectangle.Height - (int)change.Y);
            spriteBatch.Draw(
                texture,
                new Rectangle(0+(int)change.X, 175 + (int)change.Y, Globals.ScreenWidth + (int)change.X, 550 + (int)change.Y),
                newSourceRectangle,
                Color.White,
                0f,
                new Vector2(0, 0),
                SpriteEffects.None,
                0f
            );
        }
    }
}
