﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class DungeonRoom : IDungeonRoom
    {
        private DungeonRoomSprite sprite;

        public DungeonRoom() { 
            sprite = DungeonSpriteFactory.Instance.CreateDungeonRoomSprite();
    }

        public void Draw(SpriteBatch spriteBatch, Color color) {
            sprite.Draw(spriteBatch, Globals.DungeonStandard, color);
        }
        public void DrawCurrentRoom(SpriteBatch spriteBatch, Vector2 change)
        {
            sprite.DrawCurrentRoom(spriteBatch, Globals.DungeonStandard, change);
        }

        public void DrawNextRoom(SpriteBatch spriteBatch, Vector2 change)
        {
            sprite.DrawNextRoom(spriteBatch, Globals.DungeonStandard, change);
        }
    }
}
