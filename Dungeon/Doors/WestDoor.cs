using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Dungeon.Doors
{
    internal class WestDoor : DoorSecondary
    {
        public WestDoor(int state){
            Position = Globals.WestDoorPosition;
            sourceRectangle = Globals.OpenWestDoor;
            sprite = DungeonSpriteFactory.Instance.CreateWestDoorSprite();
            actions[state].Invoke();
        }

        public override Rectangle GetHitBox()
        {
            return new Rectangle(Position.X, Position.Y, Position.Width - 50, Position.Height);
        }
    }
}
