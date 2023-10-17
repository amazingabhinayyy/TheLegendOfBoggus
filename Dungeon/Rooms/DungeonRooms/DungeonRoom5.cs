using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Dungeon.Rooms;

namespace Sprint2_Attempt3.Dungeon.Rooms.DungeonRooms
{
    internal class DungeonRoom5 : DungeonSecondary
    {
        DungeonRoomSprite sprite;

        public DungeonRoom5()
        {
            sprite = DungeonSpriteFactory.Instance.CreateDungeonRoomSprite();
            northDoor = DungeonSpriteFactory.Instance.CreateClosedNorthDoorSprite();
            eastDoor = DungeonSpriteFactory.Instance.CreateDiamondLockedEastDoorSprite();
            NorthDoorWalkable = false;
            SouthDoorWalkable = false;
            EastDoorWalkable = false;
            WestDoorWalkable = false;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Globals.Dungeon5);
            northDoor.Draw(spriteBatch);
            eastDoor.Draw(spriteBatch);
        }
    }
}
