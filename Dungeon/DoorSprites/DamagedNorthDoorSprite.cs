﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Dungeon.DoorSprites
{
    internal class DamagedNorthDoorSprite : IDoorSprite
    {
        private Texture2D texture;
        public DamagedNorthDoorSprite(Texture2D texture) { 
            this.texture = texture;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                texture,
                Globals.NorthDoorPosition,
                Globals.DamagedNorthDoor,
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
