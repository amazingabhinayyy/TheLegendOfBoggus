using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Blocks
{
    public abstract class BlockSecondary : IBlock
    {
        public bool isWalkable { get; set; }
        public Rectangle position { get; set; }
        protected Rectangle sourceRectangle { get; set; }

        public BlockSecondary() { }
        public void Update() { }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(BlockSpriteFactory.Instance.blocks, position, sourceRectangle, Color.White);
        }

        public Rectangle GetHitBox()
        {
            return new Rectangle(position.X, position.Y, position.Width / 2, position.Height / 2);
        }
    }
}