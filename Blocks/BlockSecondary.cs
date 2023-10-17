using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Blocks
{
    public abstract class BlockSecondary : IBlock
    {
        public Rectangle position { get; set; }
        protected Rectangle sourceRectangle { get; set; }

        public BlockSecondary() { }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(BlockSpriteFactory.Instance.blocks, position, sourceRectangle, Color.White);
        }

        public Rectangle GetHitBox()
        {
            return position;
        }
    }
}