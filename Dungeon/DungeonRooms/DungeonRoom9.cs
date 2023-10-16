using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Dungeon.DungeonRooms
{
    internal class DungeonRoom9 : DungeonSecondary
    {
        DungeonRoomSprite sprite;

        public DungeonRoom9()
        {
            sprite = DungeonSpriteFactory.Instance.CreateDungeonRoomSprite();
            southDoor = DungeonSpriteFactory.Instance.CreateClosedSouthDoorSprite();
            eastDoor = DungeonSpriteFactory.Instance.CreateOpenEastDoorSprite();
            westDoor = DungeonSpriteFactory.Instance.CreateDiamondLockedWestDoorSprite();
            NorthDoorWalkable = false;
            SouthDoorWalkable = false;
            EastDoorWalkable = true;
            WestDoorWalkable = false;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Globals.Dungeon9);
            southDoor.Draw(spriteBatch);
            eastDoor.Draw(spriteBatch);
        }
    }
}
