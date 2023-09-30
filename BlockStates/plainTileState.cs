using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class plainTileState : BlockStates.IStateTiles
    {
        private Block block;

        public plainTileState(Block block)
        {
            this.block = block;

            block.Sprite = BlockSpriteFactory.Instance.CreatePlainTile();
        }
        public void diamondTile()
        {
            
        }
        public void plainTile()
        {
            block.Sprite = BlockSpriteFactory.Instance.CreatePlainTile();
        }
        public void Update()
        {

        }

    }
}