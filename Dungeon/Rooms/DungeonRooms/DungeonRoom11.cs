using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Dungeon.Rooms;

namespace Sprint2_Attempt3.Dungeon.Rooms.DungeonRooms
{
    internal class DungeonRoom11 : DungeonSecondary
    {
        DungeonRoomSprite sprite;

        public DungeonRoom11()
        {
            sprite = DungeonSpriteFactory.Instance.CreateDungeonRoomSprite();
            southDoor = DungeonSpriteFactory.Instance.CreateOpenSouthDoorSprite();
            eastDoor = DungeonSpriteFactory.Instance.CreateOpenEastDoorSprite();
            westDoor = DungeonSpriteFactory.Instance.CreateClosedWestDoorSprite();
            NorthDoorWalkable = false;
            SouthDoorWalkable = true;
            EastDoorWalkable = true;
            WestDoorWalkable = false;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Globals.Dungeon11);
            southDoor.Draw(spriteBatch);
            eastDoor.Draw(spriteBatch);
            westDoor.Draw(spriteBatch);
        }
    }
}
