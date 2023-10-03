using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.BlockStates;
using Sprint2_Attempt3;
using Sprint2_Attempt3.Items;

namespace Sprint2
{
    public class Block : IBlock
    {
        public Vector2 position;
        BlockSpriteFactory spriteFactory;

        public IBlockSprite Sprite { get; set; }
        public IStateTiles State { get; set; }

        public Block()
        {
            StartBlockState();
        }
        public void ChangeToDiamondTile()
        {
            State.ChangeToDiamondTile();
        }

        public void ChangeToPlainTile()
        {
            State.ChangeToPlainTile();
        }
        public void ChangeToUpChunk()
        {
            State.ChangeToUpChunk();
        }

        public void ChangeToSideChunk()
        {
            State.ChangeToSideChunk();
        }

        public void StartBlockState()
        {
            State = new PlainTileState(this);
        }
        public void Update()
        {
            State.Update();
            Sprite.Update();
        }

        public void Draw(SpriteBatch _spriteBatch)
        {
            Sprite.Draw(_spriteBatch);
        }

    }
}