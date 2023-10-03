using Sprint2_Attempt3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class SideChunkState : BlockStates.IStateTiles
    {
        private Block block;
        private Game1 game1;

        public SideChunkState(Block block)
        {
            this.block = block;

            block.Sprite = BlockSpriteFactory.Instance.CreateSideChunk();
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
        public void Update()
        {

        }

    }
}