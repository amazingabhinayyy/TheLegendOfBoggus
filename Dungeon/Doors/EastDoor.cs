using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Dungeon.Doors
{
    internal class EastDoor : DoorSecondary
    {
        public EastDoor(int state){
            Position = Globals.EastDoorPosition;
            sourceRectangle = Globals.OpenEastDoor;
            sprite = DungeonSpriteFactory.Instance.CreateEastDoorSprite();
            actions[state].Invoke();
        }
        public override Rectangle GetHitBox()
        {
            return new Rectangle(Position.X + 50, Position.Y, Position.Width - 50, Position.Height);
        }
    }
}
