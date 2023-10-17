using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Blocks.BlockStates
{
    public class DiamondTileState : BlockStates.IStateTiles
    {
        private Block block;
        private Game1 game1;

        public DiamondTileState(Block block)
        {
            this.block = block;
            block.Sprite = BlockSpriteFactory.Instance.CreateDiamondTile();
        }
        public void ChangeToDiamondTile()
        {
            block.State = new DiamondTileState(block);
        }
        public void ChangeToPlainTile()
        {
            block.State = new PlainTileState(block);
        }
        public void ChangeToUpChunk()
        {
            block.State = new UpChunkState(block);
        }
        public void ChangeToSideChunk()
        {
            block.State = new SideChunkState(block);
        }
        public void ChangeToStaircaseChuck()
        {
            block.State = new StaircaseTileState(block);
        }
        public void ChangeToBlueTileChuck()
        {
            block.State = new BlueTileState(block);
        }
        public void ChangeToWhiteBrick()
        {
            block.State = new WhiteBrickState(block);
        }

        public void ChangeToWhiteStairs()
        {
            block.State = new WhiteStairState(block);
        }

        public void ChangeToBlackBlock()
        {
            block.State = new BlackBlockState(block);
        }
        public void ChangeToDotTile()
        {
            block.State = new DotTileState(block);
        }

        public void Update()
        {

        }
        public Rectangle GetHitBox()
        {
            //To-Do fill in what hit box should be instead of 0s
            return new Rectangle(0, 0, 0, 0);
        }
    }
}