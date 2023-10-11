using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses
{
    internal class SwitchToPreviousItem : ICommand
    {
        private Game1 game1;
        private int itemIndex;

        public SwitchToPreviousItem(Game1 game) {
            this.game1 = game;
            itemIndex = game.itemIndex;
        }

        public void Execute()
        {
            /*
            * TODO:
            * call switch to next item method
            */
            if (game1.itemIndex > 0)
            {
                game1.itemIndex--;
            }

            switch (game1.itemIndex)
            {
                case 0:
                    game1.item.ChangeToRupee();
                    break;
                case 1:
                    game1.item.ChangeToBomb();
                    break;
                case 2:
                    game1.item.ChangeToClock();
                    break;
                case 3:
                    game1.item.ChangeToCompass();
                    break;
                case 4:
                    game1.item.ChangeToHeart();
                    break;
                case 5:
                    game1.item.ChangeToBoomerang();
                    break;
                case 6:
                    game1.item.ChangeToFairy();
                    break;
                case 7:
                    game1.item.ChangeToMap();
                    break;
                case 8:
                    game1.item.ChangeToKey();
                    break;
                case 9:
                    game1.item.ChangeToHeartContainer();
                    break;
                case 10:
                    game1.item.ChangeToTriforcePiece();
                    break;
                case 11:
                    game1.item.ChangeToBow();
                    break;
                case 12:
                    game1.item.ChangeToArrow();
                    break;
                case 13:
                    game1.item.ChangeToBlueCandle();
                    break;
                case 14:
                    game1.item.ChangeToBluePotion();
                    break;
            }
        }
    }
}
