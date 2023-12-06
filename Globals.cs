 using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Dodongo;
using Sprint2_Attempt3.Enemy.Gel;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;
using Sprint2_Attempt3.Enemy.SpikeTrap;
using Sprint2_Attempt3.Enemy.Zol;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Goriya;
using Sprint2_Attempt3.Enemy.Hand;
using Sprint2_Attempt3.Enemy.Stalfos;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Aquamentus;
using Sprint2_Attempt3.Dungeon.Rooms;
using System.Collections.Generic;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.WallBlocks;
using System;
using System.Linq;

namespace Sprint2_Attempt3
{
    internal class Globals
    {
        public const float scale = 3.0f;
        public const int ScreenHeight = 725;
        public const int ScreenWidth = 800;
        public const int YOffset = 175;
        public static Dictionary<int, Rectangle> FloorGrid = new Dictionary<int, Rectangle>();
     
        public static int FindIndex(int count, int step, int length)
        {
            int index = Math.Min(count / step, length - 1);
            return index;
        }

        public static void MakeFloorGrid()
        {
            int i = 1;
            for (int y = 100 + Globals.YOffset; y <= 400 + Globals.YOffset; y += 50)
            {
                for (int x = 100; x <= 650; x += 50)
                {
                    FloorGrid.Add(i, new Rectangle(x, y, 50, 50));
                    
                    i++;
                }
            }
        }
        
       
       
       


    }

}
