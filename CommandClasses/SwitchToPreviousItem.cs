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
        private Item item;
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
            // switchItem(itemNumber)
            //nextItem();
            //Debug.WriteLine("TEST");
            if (game1.itemIndex > 0)
            {
                game1.itemIndex--;
            }
            //Debug.Write(itemIndex);

            switch (game1.itemIndex)
            {
                case 0:
                    game1.Item.ChangeToRupee();
                    //item.ChangeToRupee();
                    break;
                case 1:
                    game1.Item.ChangeToBomb();
                    break;
                case 2:
                    game1.Item.ChangeToClock();
                    break;
                case 3:
                    game1.Item.ChangeToCompass();
                    break;
                case 4:
                    game1.Item.ChangeToHeart();
                    break;
                case 5:
                    game1.Item.ChangeToBoomerang();
                    break;
                case 6:
                    game1.Item.ChangeToFairy();
                    break;
                case 7:
                    game1.Item.ChangeToMap();
                    break;
                case 8:
                    game1.Item.ChangeToKey();
                    break;
                case 9:
                    game1.Item.ChangeToHeartContainer();
                    break;
                case 10:
                    game1.Item.ChangeToTriforcePiece();
                    break;
                case 11:
                    game1.Item.ChangeToBow();
                    break;
                case 12:
                    game1.Item.ChangeToArrow();
                    break;
                case 13:
                    game1.Item.ChangeToBlueCandle();
                    break;
                case 14:
                    game1.Item.ChangeToBluePotion();
                    break;
            }
        }
    }
}
