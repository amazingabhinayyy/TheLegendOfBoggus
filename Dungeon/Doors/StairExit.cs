using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Dungeon.Doors
{
    internal class StairExit : DoorSecondary
    {
        public StairExit(int state){
            Position = Globals.StairExitPosition;
            sourceRectangle = new Rectangle();
            sprite = DungeonSpriteFactory.Instance.CreateStairExitSprite();
            actions[state].Invoke();
        }
    }
}
