using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.BlockStates
{
    public interface IStateTiles
    {
        public void Update();
        public void diamondTile();
        public void plainTile();
    }
}
