using Sprint2_Attempt3.CommandClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3
{
    internal class MoveLinkLeft : ICommand
    {
        private Game1 game1;
        public MoveLinkLeft(Game1 game)
        {
            this.game1 = game;
        }

        public void Execute()
        {
            /*
             * TODO:
             * call move link left method
             */
        }
    }
}
