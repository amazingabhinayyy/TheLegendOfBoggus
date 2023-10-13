using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Blocks.BlockStates;

namespace Sprint2_Attempt3.Blocks
{
    public class Block : IBlock
    {
        public Vector2 position;

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
        public void ChangeToStaircaseTileChunk()
        {
            State.ChangeToStaircaseChuck();
        }
        public void ChangeToBlueTileChunk()
        {
            State.ChangeToBlueTileChuck();
        }

        public void ChangeToBlackBlock()
        {
            State.ChangeToBlackBlock();
        }
        public void ChangeToDotTile()
        {
            State.ChangeToDotTile();
        }
        public void StartBlockState()
        {
            State = new PlainTileState(this);
        }
        public void ChangeToWhiteBrick()
        {
            State.ChangeToWhiteBrick();
        }

        public void ChangeToWhiteStairs()
        {
            State.ChangeToWhiteStairs();
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