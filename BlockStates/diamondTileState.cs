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

            block.Sprite = BlockSpriteFactory.Instance.CreateDiamondTile();
        }

        public void Update()
        {

        }

    }
}