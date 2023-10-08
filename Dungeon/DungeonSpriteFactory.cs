using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Dungeon.DoorSprites;
using Sprint2_Attempt3.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            DungeonTexture = content.Load<Texture2D>("DungeonSprites");
            DoorTexture = content.Load<Texture2D>("DoorSprites");
        }

        public DungeonSprite CreateDungeonSprite() {
            return new DungeonSprite(DungeonTexture);
        }
       
        public IDoorSprite CreateOpenNorthDoorSprite() {
            return new OpenNorthDoorSprite(DoorTexture);
        }
        public IDoorSprite CreateOpenSouthDoorSprite()
        {
            return new OpenSouthDoorSprite(DoorTexture);
        }
        public IDoorSprite CreateOpenEastDoorSprite()
        {
            return new OpenEastDoorSprite(DoorTexture);
        }
        public IDoorSprite CreateOpenWestDoorSprite()
        {
            return new OpenWestDoorSprite(DoorTexture);
        }
        public IDoorSprite CreateClosedNorthDoorSprite()
        {
            return new ClosedNorthDoorSprite(DoorTexture);
        }
        public IDoorSprite CreateClosedSouthDoorSprite()
        {
            return new ClosedSouthDoorSprite(DoorTexture);
        }
        public IDoorSprite CreateClosedEastDoorSprite()
        {
            return new ClosedEastDoorSprite(DoorTexture);
        }
        public IDoorSprite CreateClosedWestDoorSprite()
        {
            return new ClosedWestDoorSprite(DoorTexture);
        }
        public IDoorSprite CreateDiamondLockedNorthDoorSprite()
        {
            return new DiamondLockedNorthDoorSprite(DoorTexture);
        }
        public IDoorSprite CreateDiamondLockedSouthDoorSprite()
        {
            return new DiamondLockedSouthDoorSprite(DoorTexture);
        }
        public IDoorSprite CreateDiamondLockedEastDoorSprite()
        {
            return new DiamondLockedEastDoorSprite(DoorTexture);
        }
        public IDoorSprite CreateDiamondLockedWestDoorSprite()
        {
            return new DiamondLockedWestDoorSprite(DoorTexture);
        }
        public IDoorSprite CreateDamagedNorthDoorSprite()
        {
            return new DamagedNorthDoorSprite(DoorTexture);
        }
        public IDoorSprite CreateDamagedSouthDoorSprite()
        {
            return new DamagedSouthDoorSprite(DoorTexture);
        }
        public IDoorSprite CreateDamagedEastDoorSprite()
        {
            return new DamagedEastDoorSprite(DoorTexture);
        }
        public IDoorSprite CreateDamagedWestDoorSprite()
        {
            return new DamagedWestDoorSprite(DoorTexture);
        }

    }
}
