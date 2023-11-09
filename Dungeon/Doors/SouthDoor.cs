using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Dungeon.Doors
{
    internal class SouthDoor : DoorSecondary
    {
        public SouthDoor(int state){
            Position = Globals.SouthDoorPosition;
            sourceRectangle = Globals.OpenSouthDoor;
            sprite = DungeonSpriteFactory.Instance.CreateSouthDoorSprite();
            actions[state].Invoke();
        }
        public override Rectangle GetHitBox()
        {
            return new Rectangle(Position.X, Position.Y + 50, Position.Width, Position.Height - 50);
        }
    }
}
