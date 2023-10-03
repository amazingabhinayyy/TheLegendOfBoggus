using Sprint2_Attempt3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.BlockStates
{
    public interface IStateTiles
    {
        public void ChangeToDiamondTile();
        public void ChangeToPlainTile();
        public void ChangeToUpChunk();
        public void ChangeToSideChunk();
        public void ChangeToWhiteBrick();
        public void ChangeToWhiteStairs();
        public void Update();
    }
}
