using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Collision.SideCollisionHandlers;
using Sprint2_Attempt3.Player;

namespace Sprint2_Attempt3.CommandClasses
{
    public class SetDamageLinkCommand : ICommand
    {
        private Game1 game;
        public SetDamageLinkCommand(Game1 game) 
        {
            this.game = game;
        }

        public void Execute()
        {
            DamageLinkDecorator damagedLink = new DamageLinkDecorator(game.link, game);
            damagedLink.GetDamaged(new TopCollision());
        }

    }
}
