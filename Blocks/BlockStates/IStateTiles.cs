using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Blocks.BlockStates
{
    public interface IStateTiles : IGameObject
    {
        public void ChangeToDiamondTile();
        public void ChangeToPlainTile();
        public void ChangeToUpChunk();
        public void ChangeToSideChunk();
        public void ChangeToStaircaseChuck();
        public void ChangeToBlueTileChuck();
        public void ChangeToWhiteBrick();
        public void ChangeToWhiteStairs();
        public void ChangeToBlackBlock();
        public void ChangeToDotTile();
        public void Update();
    }
}
