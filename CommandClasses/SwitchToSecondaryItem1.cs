using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.CommandClasses;

namespace Sprint2_Attempt3
{
    internal class SwitchToSecondaryItem1 : ICommand
    {
        private Game1 game1;
        public SwitchToSecondaryItem1(Game1 game) { 
            this.game1 = game;
        }

        public void Execute() {   
            /*
            * TODO:
            * call switch secondary Item 1 method
            */
        }
    }
}
