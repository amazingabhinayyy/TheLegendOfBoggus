using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Dungeon.DungeonRooms
{
    internal class DungeonRoom15 : DungeonSecondary
    {
        DungeonRoomSprite sprite;

        public DungeonRoom15()
        {
            sprite = DungeonSpriteFactory.Instance.CreateDungeonRoomSprite();
            westDoor = DungeonSpriteFactory.Instance.CreateOpenWestDoorSprite();
            NorthDoorWalkable = false;
            SouthDoorWalkable = false;
            EastDoorWalkable = false;
            WestDoorWalkable = true;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Globals.Dungeon15);
            westDoor.Draw(spriteBatch);
        }
    }
}
