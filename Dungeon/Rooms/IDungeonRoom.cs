using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public interface IDungeonRoom : IGameObject
    {
        public void Draw(SpriteBatch spriteBatch);

        public void OpenNorthDoor();
        public void OpenSouthDoor();
        public void OpenEastDoor();
        public void OpenWestDoor();

        public void CloseNorthDoor();
        public void CloseSouthDoor();
        public void CloseEastDoor();
        public void CloseWestDoor();

        public void DiamondLockNorthDoor();
        public void DiamondLockSouthDoor();
        public void DiamondLockEastDoor();
        public void DiamondLockWestDoor();

        public void DamageNorthDoor();
        public void DamageSouthDoor();
        public void DamageEastDoor();
        public void DamageWestDoor();
    }
}
