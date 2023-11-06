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

        public void DrawCurrentRoom(SpriteBatch spriteBatch, Rectangle sourceRectangle, Vector2 change)
        {
            //Rectangle newSourceRectangle = new Rectangle(sourceRectangle.X, sourceRectangle.Y, sourceRectangle.Width - (int)change.X, sourceRectangle.Height - (int)change.Y);
            Rectangle newSourceRectangle = new Rectangle(sourceRectangle.X, sourceRectangle.Y, sourceRectangle.Width - (int)change.X, sourceRectangle.Height - (int)change.Y);
            Rectangle destinationRectangle = new Rectangle(0 + (int)(change.X * 3.125), 175 + (int)(change.Y * 3.125), Globals.ScreenWidth - (int)(3.125 * change.X), 550 - (int)(3.125 * change.Y));

            //System.Diagnostics.Debug.WriteLine("x:" + (int)change.X);
            //System.Diagnostics.Debug.WriteLine("width:" + (Globals.ScreenWidth - (int)change.X));
            spriteBatch.Draw(
                texture,
               destinationRectangle,
                newSourceRectangle,
                Color.White,
                0f,
                new Vector2(0, 0),
                SpriteEffects.None,
                0f
            ); 
        }

        public void DrawNextRoom(SpriteBatch spriteBatch, Rectangle sourceRectangle, Vector2 change)
        {
            Rectangle newSourceRectangle = new Rectangle();
            Rectangle newDestinationRectangle = new Rectangle();
            if (change.Y == 0)
            {
                newSourceRectangle = new Rectangle(sourceRectangle.X + sourceRectangle.Width - (int)change.X, sourceRectangle.Y, (int)change.X, sourceRectangle.Height);
                newDestinationRectangle = new Rectangle(0, 175, (int)(change.X * 3.125), 550);
            }
            else
            {
                //System.Diagnostics.Debug.WriteLine("X");
                newSourceRectangle = new Rectangle(sourceRectangle.X, sourceRectangle.Y + sourceRectangle.Height - (int)change.Y, sourceRectangle.Width, (int)change.Y);
                newDestinationRectangle = new Rectangle(0, 175, (int)(255*3.125), (int)(change.Y * 3.125));
                System.Diagnostics.Debug.WriteLine("Y:" + (sourceRectangle.Y + sourceRectangle.Height - (int)change.Y));
                System.Diagnostics.Debug.WriteLine("height:" + ((int)(change.Y * 3.125)));

            }
            spriteBatch.Draw(
                texture,
                newDestinationRectangle,
                newSourceRectangle,
                Color.White,
                0f,
                new Vector2(0, 0),
                SpriteEffects.None,
                0f
            );;
        }
    }
}
