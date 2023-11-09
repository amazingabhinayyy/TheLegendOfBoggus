using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.WallBlocks
{
    public interface IWall : IGameObject
    {
        public bool EnemyWalkable { get; }
    }
}
