using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.WallBlocks
{
    public class WestNorthCollisionBlock : IWall
    {
        Rectangle wall;
        public WestNorthCollisionBlock()
        {
            wall = new Rectangle(700, 87, 99, 110);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
