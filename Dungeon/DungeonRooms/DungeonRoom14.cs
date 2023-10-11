using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Dungeon.DungeonRooms
{
    internal class DungeonRoom14 : DungeonSecondary
    {
        DungeonRoomSprite sprite;

        public DungeonRoom14()
        {
            sprite = DungeonSpriteFactory.Instance.CreateDungeonRoomSprite();
            southDoor = DungeonSpriteFactory.Instance.CreateOpenSouthDoorSprite();
            eastDoor = DungeonSpriteFactory.Instance.CreateOpenEastDoorSprite();
            NorthDoorWalkable = false;
            SouthDoorWalkable = true;
            EastDoorWalkable = true;
            WestDoorWalkable = false;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Globals.Dungeon14);
            southDoor.Draw(spriteBatch);
            eastDoor.Draw(spriteBatch);
        }
    }
}
