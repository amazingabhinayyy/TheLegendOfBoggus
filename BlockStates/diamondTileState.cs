using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class diamondTileState : BlockStates.IStateTiles
    {
        private Block block;

        public diamondTileState(Block block)
        {
            this.block = block;
        }
        public void diamondTile()
        {
            block.Sprite = BlockSpriteFactory.Instance.CreateDiamondTile();
        }
        public void plainTile() { 
        
        }

        public void Update()
        {

        }

    }
}