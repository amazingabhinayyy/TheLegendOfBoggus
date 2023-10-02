using Sprint2_Attempt3.Enemy.Dodongo;
using Sprint2_Attempt3.Enemy.Gel;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;
using Sprint2_Attempt3.Enemy.SpikeTrap;
using Sprint2_Attempt3.Enemy.Zol;
using Sprint2_Attempt3.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.ItemClasses;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Diagnostics;
//using System.Numerics;
//using System.Drawing;

namespace Sprint2_Attempt3.CommandClasses
{
    internal class SwitchToNextItem : ICommand
    {
        private Game1 game1;
        /*private Vector2 position;
        private Texture2D texture;
        private Rectangle source;*/
        private Item item;
        private int itemIndex;
        //private int itemNumber;
        public SwitchToNextItem(Game1 game) {
            this.game1 = game;
            //itemIndex = this.game1.itemIndex;
            //itemIndex = game.itemIndex;
            //this.itemNumber = itemNumber +1;

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
            if (game1.itemIndex <= 13)
            {
                game1.itemIndex++;
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
                    //Debug.WriteLine("Test");
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
