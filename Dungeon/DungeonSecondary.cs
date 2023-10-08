using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon
{
    public abstract class DungeonSecondary : IDungeon
    {
        protected IDoorSprite northDoor;
        protected IDoorSprite southDoor;
        protected IDoorSprite eastDoor;
        protected IDoorSprite westDoor;
        protected DungeonSecondary() { }

        public abstract void Draw(SpriteBatch spriteBatch);

        public void OpenNorthDoor()
        {
            northDoor = DungeonSpriteFactory.Instance.CreateOpenNorthDoorSprite();
        }

        public void OpenSouthDoor()
        {
            southDoor = DungeonSpriteFactory.Instance.CreateOpenSouthDoorSprite();
        }

        public void OpenEastDoor()
        {
            eastDoor = DungeonSpriteFactory.Instance.CreateOpenEastDoorSprite();
        }

        public void OpenWestDoor()
        {
            westDoor = DungeonSpriteFactory.Instance.CreateOpenWestDoorSprite();
        }

        public void CloseNorthDoor()
        {
            northDoor = DungeonSpriteFactory.Instance.CreateClosedNorthDoorSprite();
        }

        public void CloseSouthDoor()
        {
            southDoor = DungeonSpriteFactory.Instance.CreateClosedSouthDoorSprite();
        }

        public void CloseEastDoor()
        {
            eastDoor = DungeonSpriteFactory.Instance.CreateClosedEastDoorSprite();
        }

        public void CloseWestDoor()
        {
            westDoor = DungeonSpriteFactory.Instance.CreateClosedWestDoorSprite();
        }

        public void DiamondLockNorthDoor()
        {
            northDoor = DungeonSpriteFactory.Instance.CreateDiamondLockedNorthDoorSprite();
        }

        public void DiamondLockSouthDoor()
        {
            southDoor = DungeonSpriteFactory.Instance.CreateDiamondLockedSouthDoorSprite();
        }

        public void DiamondLockEastDoor()
        {
            eastDoor = DungeonSpriteFactory.Instance.CreateDiamondLockedEastDoorSprite();
        }

        public void DiamondLockWestDoor()
        {
            westDoor = DungeonSpriteFactory.Instance.CreateDiamondLockedWestDoorSprite();
        }

        public void DamageNorthDoor()
        {
            northDoor = DungeonSpriteFactory.Instance.CreateDamagedNorthDoorSprite();
        }

        public void DamageSouthDoor()
        {
            southDoor = DungeonSpriteFactory.Instance.CreateDamagedSouthDoorSprite();
        }

        public void DamageEastDoor()
        {
            eastDoor = DungeonSpriteFactory.Instance.CreateDamagedEastDoorSprite();
        }

        public void DamageWestDoor()
        {
            westDoor = DungeonSpriteFactory.Instance.CreateDamagedWestDoorSprite();
        }
    }
}
