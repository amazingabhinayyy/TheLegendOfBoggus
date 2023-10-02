using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public interface IBlock
    {
        public void ChangeToPlainTile();
        public void ChangeToDiamondTile();
        public void ChangeToSideChunk();
        public void ChangeToUpChunk();
        public void Update();

    }
}
