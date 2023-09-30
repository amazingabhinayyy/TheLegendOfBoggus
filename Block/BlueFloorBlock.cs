using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Block
{
    internal class BlueFloorBlock : IBlock
    {
        private Vector2 position;
        private BlockSprite sprite;
        public BlueFloorBlock(Vector2 Position) { 
            this.position = Position;
            sprite = BlockSpriteFactory.Instance.CreateBlockSprite();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, position, Globals.BlueFloor);
        }
    }
}
