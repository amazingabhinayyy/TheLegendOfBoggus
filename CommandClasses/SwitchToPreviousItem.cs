using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses
{
    internal class SwitchToPreviousItem : ICommand
    {
        private Game1 game1; 

        public SwitchToPreviousItem(Game1 game) { 
            this.game1 = game;
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
