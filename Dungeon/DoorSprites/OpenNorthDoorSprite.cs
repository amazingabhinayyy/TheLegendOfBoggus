﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Dungeon.DoorSprites
{
    internal class OpenNorthDoorSprite : IDoorSprite
    {
        private Texture2D texture;
        public OpenNorthDoorSprite(Texture2D texture) { 
            this.texture = texture;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                texture,
                Globals.NorthDoorPosition,
                Globals.OpenNorthDoor,
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
