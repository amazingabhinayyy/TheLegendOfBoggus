using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.CommandClasses;

namespace Sprint2_Attempt3
{
    
    internal class SwitchToNextBlock : ICommand
    {
        private Game1 game1;
        public SwitchToNextBlock(Game1 g) {
            this.game1 = g;
    }

        public void Execute()
        {
            /*
            * TODO:
            * call switch to previous item method
            */
        }
    }
}