using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Dungeon.Rooms;

namespace Sprint2_Attempt3.Dungeon.Rooms.DungeonRooms
{
    internal class DungeonRoom13 : DungeonSecondary
    {
        DungeonRoomSprite sprite;

        public DungeonRoom13()
        {
            sprite = DungeonSpriteFactory.Instance.CreateDungeonRoomSprite();
            northDoor = DungeonSpriteFactory.Instance.CreateClosedNorthDoorSprite();
            southDoor = DungeonSpriteFactory.Instance.CreateOpenSouthDoorSprite();
            NorthDoorWalkable = false;
            SouthDoorWalkable = true;
            EastDoorWalkable = false;
            WestDoorWalkable = false;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Globals.Dungeon13);
            northDoor.Draw(spriteBatch);
            southDoor.Draw(spriteBatch);
        }
    }
}
