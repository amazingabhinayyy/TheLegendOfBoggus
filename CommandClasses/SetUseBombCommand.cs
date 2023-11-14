using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Sounds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses
{
    public class SetUseBombCommand : ICommand
    {
        private Game1 game;
        public SetUseBombCommand(Game1 game) 
        { 
            this.game = game;
        }

        public void Execute() {
            game.link.UseBomb();
            SoundFactory.PlaySound(SoundFactory.Instance.bombDrop);
        }
    }
}
