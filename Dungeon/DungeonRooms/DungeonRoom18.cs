using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Dungeon.DungeonRooms
{
    internal class DungeonRoom18 : DungeonSecondary
    {
        DungeonRoomSprite sprite;

        public DungeonRoom18()
        {
            sprite = DungeonSpriteFactory.Instance.CreateDungeonRoomSprite();
            southDoor = DungeonSpriteFactory.Instance.CreateClosedSouthDoorSprite();
            westDoor = DungeonSpriteFactory.Instance.CreateClosedWestDoorSprite();
            NorthDoorWalkable = false;
            SouthDoorWalkable = false;
            EastDoorWalkable = false;
            WestDoorWalkable = false;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Globals.Dungeon18);
            southDoor.Draw(spriteBatch);
            westDoor.Draw(spriteBatch);
        }
    }
}
