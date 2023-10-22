using Microsoft.Xna.Framework;
using System;

namespace Sprint2_Attempt3.Dungeon.Doors
{
    internal class NorthDoor : DoorSecondary
    {
        public NorthDoor(int state){
            Position = Globals.NorthDoorPosition;
            sourceRectangle = Globals.OpenNorthDoor;
            sprite = DungeonSpriteFactory.Instance.CreateNorthDoorSprite();
            actions[state].Invoke();
        }
    }
}
