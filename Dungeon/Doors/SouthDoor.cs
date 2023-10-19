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
    }
}
