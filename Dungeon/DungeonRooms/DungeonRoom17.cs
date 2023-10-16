﻿using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Dungeon.DungeonRooms
{
    internal class DungeonRoom17 : DungeonSecondary
    {
        DungeonRoomSprite sprite;

        public DungeonRoom17()
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
            sprite.Draw(spriteBatch, Globals.Dungeon17);
            eastDoor.Draw(spriteBatch);
        }
    }
}