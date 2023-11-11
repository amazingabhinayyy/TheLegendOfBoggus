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
        public override Rectangle GetHitBox()
        {
            if (IsWalkable)
            {
                return new Rectangle(Position.X, Position.Y, Position.Width, Position.Height - 50);
            }
            else
            {
                return new Rectangle(Position.X, Position.Y, Position.Width, Position.Height - 25);
            }
        }
    }
}
