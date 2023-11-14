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
        public virtual void Update() { }
        public virtual void Draw(SpriteBatch spriteBatch, Color color)
        {
            spriteBatch.Draw(BlockSpriteFactory.Instance.blocks, position, sourceRectangle, color);
        }

        public Rectangle GetHitBox()
        {
            return new Rectangle(position.X, position.Y, position.Width, position.Height / 2);
        }
    }
}