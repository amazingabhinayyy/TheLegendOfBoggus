using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Dungeon.DungeonRooms
{
    internal class DungeonRoom10 : DungeonSecondary
    {
        DungeonRoomSprite sprite;

        public DungeonRoom10()
        {
            sprite = DungeonSpriteFactory.Instance.CreateDungeonRoomSprite();
            northDoor = DungeonSpriteFactory.Instance.CreateOpenNorthDoorSprite();
            southDoor = DungeonSpriteFactory.Instance.CreateOpenSouthDoorSprite();
            eastDoor = DungeonSpriteFactory.Instance.CreateOpenEastDoorSprite();
            westDoor = DungeonSpriteFactory.Instance.CreateOpenWestDoorSprite();
            NorthDoorWalkable = true;
            SouthDoorWalkable = true;
            EastDoorWalkable = true;
            WestDoorWalkable = true;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Globals.Dungeon10);
            northDoor.Draw(spriteBatch);
            southDoor.Draw(spriteBatch);
            eastDoor.Draw(spriteBatch);
            westDoor.Draw(spriteBatch);
        }
    }
}
