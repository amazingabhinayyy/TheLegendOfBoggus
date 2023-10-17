﻿using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Dungeon.Rooms;

namespace Sprint2_Attempt3.Dungeon.Rooms.DungeonRooms
{
    internal class DungeonRoom8 : DungeonSecondary
    {
        DungeonRoomSprite sprite;

        public DungeonRoom8()
        {
            sprite = DungeonSpriteFactory.Instance.CreateDungeonRoomSprite();
            eastDoor = DungeonSpriteFactory.Instance.CreateOpenEastDoorSprite();
            NorthDoorWalkable = false;
            SouthDoorWalkable = false;
            EastDoorWalkable = true;
            WestDoorWalkable = false;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Globals.Dungeon8);
            eastDoor.Draw(spriteBatch);
        }
    }
}