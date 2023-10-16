using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public abstract class DungeonSecondary : IDungeonRoom
    {
        protected IDoorSprite northDoor;
        protected IDoorSprite southDoor;
        protected IDoorSprite eastDoor;
        protected IDoorSprite westDoor;

        public bool NorthDoorWalkable { get; set; }
        public bool SouthDoorWalkable { get; set; }
        public bool EastDoorWalkable { get; set; }
        public bool WestDoorWalkable { get; set; }
        protected DungeonSecondary() { }

        public abstract void Draw(SpriteBatch spriteBatch);

        public void OpenNorthDoor()
        {
            northDoor = DungeonSpriteFactory.Instance.CreateOpenNorthDoorSprite();
            NorthDoorWalkable = true;
        }

        public void OpenSouthDoor()
        {
            southDoor = DungeonSpriteFactory.Instance.CreateOpenSouthDoorSprite();
            SouthDoorWalkable = true;
        }

        public void OpenEastDoor()
        {
            eastDoor = DungeonSpriteFactory.Instance.CreateOpenEastDoorSprite();
            EastDoorWalkable = true;
        }

        public void OpenWestDoor()
        {
            westDoor = DungeonSpriteFactory.Instance.CreateOpenWestDoorSprite();
            WestDoorWalkable = true;
        }

        public void CloseNorthDoor()
        {
            northDoor = DungeonSpriteFactory.Instance.CreateClosedNorthDoorSprite();
            NorthDoorWalkable = false;
        }

        public void CloseSouthDoor()
        {
            southDoor = DungeonSpriteFactory.Instance.CreateClosedSouthDoorSprite();
            SouthDoorWalkable = false;
        }

        public void CloseEastDoor()
        {
            eastDoor = DungeonSpriteFactory.Instance.CreateClosedEastDoorSprite();
            EastDoorWalkable = false;
        }

        public void CloseWestDoor()
        {
            westDoor = DungeonSpriteFactory.Instance.CreateClosedWestDoorSprite();
            WestDoorWalkable = false;
        }

        public void DiamondLockNorthDoor()
        {
            northDoor = DungeonSpriteFactory.Instance.CreateDiamondLockedNorthDoorSprite();
            NorthDoorWalkable = false;
        }

        public void DiamondLockSouthDoor()
        {
            southDoor = DungeonSpriteFactory.Instance.CreateDiamondLockedSouthDoorSprite();
            SouthDoorWalkable = false;
        }

        public void DiamondLockEastDoor()
        {
            eastDoor = DungeonSpriteFactory.Instance.CreateDiamondLockedEastDoorSprite();
            EastDoorWalkable = false;
        }

        public void DiamondLockWestDoor()
        {
            westDoor = DungeonSpriteFactory.Instance.CreateDiamondLockedWestDoorSprite();
            WestDoorWalkable = false;
        }

        public void DamageNorthDoor()
        {
            northDoor = DungeonSpriteFactory.Instance.CreateDamagedNorthDoorSprite();
            NorthDoorWalkable = true;
        }

        public void DamageSouthDoor()
        {
            southDoor = DungeonSpriteFactory.Instance.CreateDamagedSouthDoorSprite();
            SouthDoorWalkable = true;
        }

        public void DamageEastDoor()
        {
            eastDoor = DungeonSpriteFactory.Instance.CreateDamagedEastDoorSprite();
            EastDoorWalkable = true;
        }

        public void DamageWestDoor()
        {
            westDoor = DungeonSpriteFactory.Instance.CreateDamagedWestDoorSprite();
            WestDoorWalkable = true;
        }
    }
}
