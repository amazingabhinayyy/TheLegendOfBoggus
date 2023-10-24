using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.WallBlocks
{
    public class EastNorthCollisionBlock : IWall
    {
        Rectangle wall;
        public EastNorthCollisionBlock()
        {
            wall = new Rectangle(695, 87, 105, 110);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
