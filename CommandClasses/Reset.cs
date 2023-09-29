using Sprint2_Attempt3.Enemy.Keese;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses
{
    internal class Reset : ICommand
    {
        private Game1 game1;
        public Reset(Game1 game) { 
            this.game1= game;
        }

        public void Execute()
        {
            game1.enemy = new Keese();
            game1.enemy.Spawn();
            game1.Link = new Link();
        }
    }
}
