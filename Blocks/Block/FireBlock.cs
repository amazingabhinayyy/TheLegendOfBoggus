using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Blocks.Block
{
    internal class FireBlock : BlockSecondary
    {
        public FireBlock(Rectangle Position)
        {
            position = Position;
            sourceRectangle = Globals.blackBlockScr;
        }
    }
}
