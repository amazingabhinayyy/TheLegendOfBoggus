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

        public static Rectangle DodongoUp { get { return new Rectangle(35, 35, 15, 16); } }
        public static Rectangle DodongoDown { get { return new Rectangle(1, 35, 15, 16); } }
        public static Rectangle DodongoRight1 { get { return new Rectangle(69, 35, 28, 18); } }
        public static Rectangle DodongoRight2 { get { return new Rectangle(102, 35, 28, 18); } }
            
            
            public static Rectangle DodongoUpAttacked { get { return new Rectangle(52, 35, 16, 16); } }
        public static Rectangle DodongoDownAttacked { get { return new Rectangle(17, 35, 17, 16); } }
        public static Rectangle DodongoRightAttacked { get { return new Rectangle(135, 35, 32, 16); } }
        public static Rectangle[] Dodongos { get; } = new Rectangle[] { new Rectangle(35, 35, 15, 16), new Rectangle(1, 35, 15, 16), new Rectangle(69, 35, 28, 18), new Rectangle(102, 35, 28, 18) };
        public static Rectangle[] AttackedDodongos { get; } = new Rectangle[] { new Rectangle(52, 35, 16, 16), new Rectangle(17, 35, 17, 16), new Rectangle(135, 35, 32, 16) };

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

        public static Rectangle HandGreen2 { get { return new Rectangle(68, 1, 16, 16); } }
        public static Rectangle HandTeal1 { get { return new Rectangle(50, 18, 17, 16); } }
        public static Rectangle HandBlue1 { get { return new Rectangle(50, 35, 17, 16); } }
        public static Rectangle HandRed1 { get { return new Rectangle(50, 52, 17, 16); } }
        public static Rectangle HandRed2 { get { return new Rectangle(68, 52, 16, 16); } }
        public static Rectangle[] Hands { get; } = new Rectangle[] { new Rectangle(50, 52, 17, 16), new Rectangle(68, 52, 16, 16), new Rectangle(50, 18, 17, 16), new Rectangle(68, 1, 16, 16), new Rectangle(50, 35, 17, 16) };

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

        public static Rectangle DungeonStandard { get { return new Rectangle(1, 1, 256, 176); } }
        public static Rectangle NorthDoorPosition { get { return new Rectangle(348, 0 + Globals.YOffset, 105, 100); } }
        public static Rectangle SouthDoorPosition { get { return new Rectangle(348, 450 + Globals.YOffset, 105, 100); } }
        public static Rectangle EastDoorPosition { get { return new Rectangle(700, 227 + Globals.YOffset, 100, 94); } }
        public static Rectangle WestDoorPosition { get { return new Rectangle(0, 227 + Globals.YOffset, 100, 94); } }
        public static Rectangle StairExitPosition { get { return new Rectangle(150, 0 + Globals.YOffset, 50, 10); } }

        public static Rectangle OpenNorthDoor { get { return new Rectangle(259, 1, 30, 32); } }
        public static Rectangle OpenSouthDoor { get { return new Rectangle(259, 100, 30, 32); } }
        public static Rectangle OpenWestDoor { get { return new Rectangle(259, 35, 31, 30); } }
        public static Rectangle OpenEastDoor { get { return new Rectangle(259, 68, 31, 30); } }

        public static Rectangle ClosedNorthDoor { get { return new Rectangle(291, 1, 31, 32); } }
        public static Rectangle ClosedSouthDoor { get { return new Rectangle(291, 100, 31, 32); } }
        public static Rectangle ClosedWestDoor { get { return new Rectangle(291, 34, 31, 32); } }
        public static Rectangle ClosedEasttDoor { get { return new Rectangle(291, 67, 31, 32); } }

        public static Rectangle DiamondLockedNorthDoor { get { return new Rectangle(324, 1, 31, 32); } }
        public static Rectangle DiamondLockedSouthDoor { get { return new Rectangle(324, 100, 31, 32); } }
        public static Rectangle DiamondLockedWestDoor { get { return new Rectangle(324, 34, 31, 32); } }
        public static Rectangle DiamondLockedEastDoor { get { return new Rectangle(324, 67, 31, 32); } }

        public static Rectangle DamagedNorthDoor { get { return new Rectangle(357, 1, 31, 32); } }
        public static Rectangle DamagedSouthDoor { get { return new Rectangle(324, 100, 31, 32); } }
        public static Rectangle DamagedEastDoor { get { return new Rectangle(324, 34, 31, 32); } }
        public static Rectangle DamagedWestDoor { get { return new Rectangle(324, 67, 31, 32); } }

        public static List<IWall> WallBlocks = new List<IWall>
        {
            new NorthEastCollisionBlock(), new NorthWestCollisionBlock(), new SouthEastCollisionBlock(),
            new SouthWestCollisionBlock(), new EastNorthCollisionBlock(), new EastSouthCollisionBlock(),
            new NorthDoorCollisionBlock(), new SouthDoorCollisionBlock(), new EastDoorCollisionBlock(),
            new WestDoorCollisionBlock(), new WestSouthCollisionBlock(), new WestNorthCollisionBlock()
        };

        public static List<IWall> Room16WallBlocks = new List<IWall> {
            new Room16Wall1(),
            new Room16Wall2(),
            new Room16Wall3(),
            new Room16Wall4(),
            new Room16Wall5(),
            new Room16Wall6(),
            new Room16Wall7(),
            new Room16Wall8(),
            new ScreenBottom(),
            new ScreenTop(),
            new ScreenLeft(),
            new ScreenRight()
        };
    }

}
