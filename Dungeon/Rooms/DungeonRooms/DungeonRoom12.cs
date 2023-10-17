using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Dungeon.Rooms;

namespace Sprint2_Attempt3.Dungeon.Rooms.DungeonRooms
{
    internal class DungeonRoom12 : DungeonSecondary
    {
        DungeonRoomSprite sprite;

        public DungeonRoom12()
        {
            sprite = DungeonSpriteFactory.Instance.CreateDungeonRoomSprite();
            northDoor = DungeonSpriteFactory.Instance.CreateClosedNorthDoorSprite();
            westDoor = DungeonSpriteFactory.Instance.CreateOpenWestDoorSprite();
            NorthDoorWalkable = false;
            SouthDoorWalkable = false;
            EastDoorWalkable = false;
            WestDoorWalkable = true;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Globals.Dungeon12);
            northDoor.Draw(spriteBatch);
            westDoor.Draw(spriteBatch);
        }
    }
}
