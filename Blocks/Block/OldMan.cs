using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Blocks.Block
{
    internal class OldMan : BlockSecondary
    {
        private Rectangle OldManSrc1 = new Rectangle(51,34,16,16);
        public OldMan(Rectangle Position)
        {
            Position.X = 375;
            position = Position;
            sourceRectangle = OldManSrc1;
        }
    }
}
