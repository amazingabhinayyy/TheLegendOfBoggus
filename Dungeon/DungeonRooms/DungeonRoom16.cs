using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Dungeon.DungeonRooms
{
    internal class DungeonRoom16 : DungeonSecondary
    {
        DungeonRoomSprite sprite;

        public DungeonRoom16()
        {
            sprite = DungeonSpriteFactory.Instance.CreateDungeonRoomSprite();
            NorthDoorWalkable = false;
            SouthDoorWalkable = false;
            EastDoorWalkable = false;
            WestDoorWalkable = false;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Globals.Dungeon16);
        }
    }
}
