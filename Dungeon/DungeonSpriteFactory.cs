using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Dungeon.Doors.DoorSprites;
using Sprint2_Attempt3.Dungeon.Rooms;

namespace Sprint2_Attempt3.Dungeon
{
    internal class DungeonSpriteFactory
    {
        private static Texture2D DungeonTexture;
        private static Texture2D DoorTexture;
        private static DungeonSpriteFactory instance = new DungeonSpriteFactory();
        public static DungeonSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }
        public DungeonSpriteFactory()
        {

        }

        public void LoadAllTextures(ContentManager content)
        {
            DungeonTexture = content.Load<Texture2D>("Dungeon_Doors");
        }

        public DungeonRoomSprite CreateDungeonRoomSprite()
        {
            return new DungeonRoomSprite(DungeonTexture);
        }

        public IDoorSprite CreateNorthDoorSprite()
        {
            return new NorthDoorSprite(DungeonTexture);
        }
        public IDoorSprite CreateSouthDoorSprite()
        {
            return new SouthDoorSprite(DungeonTexture);
        }
        public IDoorSprite CreateEastDoorSprite()
        {
            return new EastDoorSprite(DungeonTexture);
        }
        public IDoorSprite CreateWestDoorSprite()
        {
            return new WestDoorSprite(DungeonTexture);
        }
    }
}