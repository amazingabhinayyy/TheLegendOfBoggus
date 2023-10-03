using Sprint2_Attempt3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class StaircaseTileState : BlockStates.IStateTiles
    {
        private Block block;
        private Game1 game1;

        public StaircaseTileState(Block block)
        {
            this.block = block;

            block.Sprite = BlockSpriteFactory.Instance.CreateStaircaseTile();
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
        }
        public void ChangeToBlueTileChuck()
        {
            block.State = new BlueTileState(block);
        }
        public void Update()
        {

        }

    }
}