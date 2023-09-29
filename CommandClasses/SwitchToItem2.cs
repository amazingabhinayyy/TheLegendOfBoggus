using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.CommandClasses;

namespace Sprint2_Attempt3
{
    internal class SwitchToItem2 : ICommand
    {
        private Game1 game1;
        public SwitchToItem2(Game1 game) {
            this.game1 = game;
        }

        public void Execute()
        {
            /*
             * TODO:
             * call switch Item 2 method
             */
        }
    }
}
