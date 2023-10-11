using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Dungeon.DungeonRooms
{
    internal class DungeonRoom4 : DungeonSecondary
    {
        DungeonRoomSprite sprite;

        public DungeonRoom4()
        {
            sprite = DungeonSpriteFactory.Instance.CreateDungeonRoomSprite();
            northDoor = DungeonSpriteFactory.Instance.CreateOpenNorthDoorSprite();
            southDoor = DungeonSpriteFactory.Instance.CreateOpenSouthDoorSprite();
            NorthDoorWalkable = true;
            SouthDoorWalkable = true;
            EastDoorWalkable = false;
            WestDoorWalkable = false;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Globals.Dungeon4);
            northDoor.Draw(spriteBatch);
            southDoor.Draw(spriteBatch);
        }
    }
}
