﻿ using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System;

namespace Sprint2_Attempt3
{
    internal class Globals
    {
        public const float scale = 3.0f;
        public const int ScreenHeight = 725;
        public const int ScreenWidth = 800;
        public const int YOffset = 175;
        public const int NumberOfRooms = 19;
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

        public static Rectangle GoriyaGreenDown { get { return new Rectangle(84, 1, 14, 16); } }
        public static Rectangle GoriyaGreenUp { get { return new Rectangle(101, 1, 14, 16); } }
        public static Rectangle GoriyaGreenRight2 { get { return new Rectangle(135, 1, 15, 16); } }
        public static Rectangle GoriyaTealDown { get { return new Rectangle(84, 18, 14, 16); } }
        public static Rectangle GoriyaTealUp { get { return new Rectangle(101, 18, 14, 16); } }
        public static Rectangle GoriyaTealRight { get { return new Rectangle(117, 18, 14, 16); } }
        public static Rectangle GoriyaRedDown { get { return new Rectangle(84, 35, 14, 16); } }
        public static Rectangle GoriyaRedUp { get { return new Rectangle(101, 35, 14, 16); } }
        public static Rectangle GoriyaRedRight { get { return new Rectangle(117, 35, 14, 16); } }
        public static Rectangle GoriyaRedRight2 { get { return new Rectangle(135, 35, 15, 16); } }
        public static Rectangle GoriyaBlueDown { get { return new Rectangle(84, 52, 14, 16); } }
        public static Rectangle GoriyaBlueUp { get { return new Rectangle(101, 52, 14, 16); } }
        public static Rectangle GoriyaBlueRight { get { return new Rectangle(117, 52, 14, 16); } }
        public static Rectangle GoriyaBlueRight2 { get { return new Rectangle(135, 52, 15, 16); } }
        public static Rectangle[] DownGoryia { get; } = new Rectangle[] { new Rectangle(84, 1, 14, 16), new Rectangle(84, 18, 14, 16), new Rectangle(84, 35, 14, 16), new Rectangle(84, 52, 14, 16) };
        public static Rectangle[] UpGoryia { get; } = new Rectangle[] { new Rectangle(101, 1, 14, 16), new Rectangle(101, 18, 14, 16), new Rectangle(101, 35, 14, 16), new Rectangle(101, 52, 14, 16) };
        public static Rectangle[] RightGoryia { get; } = new Rectangle[] { new Rectangle(135, 35, 15, 16), new Rectangle(117, 35, 14, 16), new Rectangle(135, 1, 15, 16), new Rectangle(117, 18, 14, 16), new Rectangle(135, 52, 15, 16) };

        public static Rectangle GoriyaBoomerang1 { get { return new Rectangle(0, 74, 7, 9); } }
        public static Rectangle GoriyaBoomerang2 { get { return new Rectangle(10, 74, 9, 9); } }
        public static Rectangle GoriyaBoomerang3 { get { return new Rectangle(20, 76, 9, 6); } }
        
        public static int currentIndex = 0;
        public static Rectangle[] GoriyaBoomerangLeft = { GoriyaBoomerang1, GoriyaBoomerang2, GoriyaBoomerang3, GoriyaBoomerang2, GoriyaBoomerang1, GoriyaBoomerang2, GoriyaBoomerang3, GoriyaBoomerang2 };
        public static SpriteEffects[] GoriyaBoomerangLeftEffects = { SpriteEffects.None, SpriteEffects.None, SpriteEffects.None, SpriteEffects.FlipHorizontally, SpriteEffects.FlipHorizontally, SpriteEffects.FlipHorizontally | SpriteEffects.FlipVertically, SpriteEffects.FlipVertically, SpriteEffects.FlipVertically };

        public static Rectangle[] GoriyaBoomerangUp = { GoriyaBoomerang1, GoriyaBoomerang2, GoriyaBoomerang2, GoriyaBoomerang2, GoriyaBoomerang1, GoriyaBoomerang2, GoriyaBoomerang3, GoriyaBoomerang2 }; 
        public static Rectangle[] GoriyaBoomerangRight = { GoriyaBoomerang1, GoriyaBoomerang2, GoriyaBoomerang2, GoriyaBoomerang2, GoriyaBoomerang1, GoriyaBoomerang2, GoriyaBoomerang3, GoriyaBoomerang2 }; 
        public static Rectangle[] GoriyaBoomerangDown = { GoriyaBoomerang1, GoriyaBoomerang2, GoriyaBoomerang2, GoriyaBoomerang2, GoriyaBoomerang1, GoriyaBoomerang2, GoriyaBoomerang3, GoriyaBoomerang2 };
        public static int boomerangSpeed = 5;
        public static int boomerangSpriteSwitchSpeed = 20;

        public static Rectangle AquamentusGreenLeft { get { return new Rectangle(51, 0, 24, 33); } }
        public static Rectangle AquamentusGreenLeft2 { get { return new Rectangle(76, 0, 24, 33); } }
        public static Rectangle AquamentusGreenLeftMouthOpen { get { return new Rectangle(0, 0, 24, 33); } }
        public static Rectangle AquamentusGreenLeftMouthOpen2 { get { return new Rectangle(26, 0, 24, 33); } }
        public static Rectangle AquamentusOrangeLeft1 { get { return new Rectangle(140, 0, 24, 33); } }
        public static Rectangle AquamentusBlueLeft { get { return new Rectangle(171, 0, 24, 33); } }
        public static Rectangle AquamentusOrangeLeft2 { get { return new Rectangle(202, 0, 24, 33); } }
        public static Rectangle AquamentusFireball1 { get { return new Rectangle(100, 3, 9, 11); } }
        public static Rectangle AquamentusFireball2 { get { return new Rectangle(109, 3, 9, 11); } }
        public static Rectangle AquamentusFireball3 { get { return new Rectangle(118, 3, 9, 11); } }
        public static Rectangle AquamentusFireball4 { get { return new Rectangle(127, 3, 9, 11); } }
        public static int fireballSpeed = 5;
        public static int fireballSpriteSwitchSpeed = 40;

        public static Rectangle[] AquamentusFireballLeft = {AquamentusFireball1, AquamentusFireball2, AquamentusFireball3, AquamentusFireball4, AquamentusFireball1, AquamentusFireball2, AquamentusFireball3, AquamentusFireball4 };
        public static SpriteEffects[] AquamentusFireballLeftEffects = { SpriteEffects.None, SpriteEffects.None, SpriteEffects.None, SpriteEffects.None, SpriteEffects.None, SpriteEffects.None, SpriteEffects.None, SpriteEffects.None };
        public static Vector2 temp = new Vector2(0, 0);
        public static Vector2[] AquamentusOriginsLeft = { temp, temp, temp, temp, temp, temp, temp, temp };
        public static int fireBallMaxDistance = 500;

    }

}
