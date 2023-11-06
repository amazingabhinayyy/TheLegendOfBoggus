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

namespace Sprint2_Attempt3
{
    internal class Globals
    {
        public const float scale = 3.0f;
        public const int ScreenHeight = 725;
        public const int ScreenWidth = 800;
        public const int YOffset = 175;

        public static Dictionary<int, Rectangle> FloorGrid = new Dictionary<int, Rectangle>()
        {
            {1, new Rectangle(100, 100 + Globals.YOffset, 50, 50) },
            {2, new Rectangle(150, 100 + Globals.YOffset, 50, 50) },
            {3, new Rectangle(200, 100 + Globals.YOffset, 50, 50) },
            {4, new Rectangle(250, 100 + Globals.YOffset, 50, 50) },
            {5, new Rectangle(300, 100 + Globals.YOffset, 50, 50) },
            {6, new Rectangle(350, 100 + Globals.YOffset, 50, 50) },
            {7, new Rectangle(400, 100 + Globals.YOffset, 50, 50) },
            {8, new Rectangle(450, 100 + Globals.YOffset, 50, 50) },
            {9, new Rectangle(500, 100 + Globals.YOffset, 50, 50) },
            {10, new Rectangle(550, 100 + Globals.YOffset, 50, 50) },
            {11, new Rectangle(600, 100 + Globals.YOffset, 50, 50) },
            {12, new Rectangle(650, 100 + Globals.YOffset, 50, 50) },

            {13, new Rectangle(100, 150 + Globals.YOffset, 50, 50) },
            {14, new Rectangle(150, 150 + Globals.YOffset, 50, 50) },
            {15, new Rectangle(200, 150 + Globals.YOffset, 50, 50) },
            {16, new Rectangle(250, 150 + Globals.YOffset, 50, 50) },
            {17, new Rectangle(300, 150 + Globals.YOffset, 50, 50) },
            {18, new Rectangle(350, 150 + Globals.YOffset, 50, 50) },
            {19, new Rectangle(400, 150 + Globals.YOffset, 50, 50) },
            {20, new Rectangle(450, 150 + Globals.YOffset, 50, 50) },
            {21, new Rectangle(500, 150 + Globals.YOffset, 50, 50) },
            {22, new Rectangle(550, 150 + Globals.YOffset, 50, 50) },
            {23, new Rectangle(600, 150 + Globals.YOffset, 50, 50) },
            {24, new Rectangle(650, 150 + Globals.YOffset, 50, 50) },

            {25, new Rectangle(100, 200 + Globals.YOffset, 50, 50) },
            {26, new Rectangle(150, 200 + Globals.YOffset, 50, 50) },
            {27, new Rectangle(200, 200 + Globals.YOffset, 50, 50) },
            {28, new Rectangle(250, 200 + Globals.YOffset, 50, 50) },
            {29, new Rectangle(300, 200 + Globals.YOffset, 50, 50) },
            {30, new Rectangle(350, 200 + Globals.YOffset, 50, 50) },
            {31, new Rectangle(400, 200 + Globals.YOffset, 50, 50) },
            {32, new Rectangle(450, 200 + Globals.YOffset, 50, 50) },
            {33, new Rectangle(500, 200 + Globals.YOffset, 50, 50) },
            {34, new Rectangle(550, 200 + Globals.YOffset, 50, 50) },
            {35, new Rectangle(600, 200 + Globals.YOffset, 50, 50) },
            {36, new Rectangle(650, 200 + Globals.YOffset, 50, 50) },

            {37, new Rectangle(100, 250 + Globals.YOffset, 50, 50) },
            {38, new Rectangle(150, 250 + Globals.YOffset, 50, 50) },
            {39, new Rectangle(200, 250 + Globals.YOffset, 50, 50) },
            {40, new Rectangle(250, 250 + Globals.YOffset, 50, 50) },
            {41, new Rectangle(300, 250 + Globals.YOffset, 50, 50) },
            {42, new Rectangle(350, 250 + Globals.YOffset, 50, 50) },
            {43, new Rectangle(400, 250 + Globals.YOffset, 50, 50) },
            {44, new Rectangle(450, 250 + Globals.YOffset, 50, 50) },
            {45, new Rectangle(500, 250 + Globals.YOffset, 50, 50) },
            {46, new Rectangle(550, 250 + Globals.YOffset, 50, 50) },
            {47, new Rectangle(600, 250 + Globals.YOffset, 50, 50) },
            {48, new Rectangle(650, 250 + Globals.YOffset, 50, 50) },

            {49, new Rectangle(100, 300 + Globals.YOffset, 50, 50) },
            {50, new Rectangle(150, 300 + Globals.YOffset, 50, 50) },
            {51, new Rectangle(200, 300 + Globals.YOffset, 50, 50) },
            {52, new Rectangle(250, 300 + Globals.YOffset, 50, 50) },
            {53, new Rectangle(300, 300 + Globals.YOffset, 50, 50) },
            {54, new Rectangle(350, 300 + Globals.YOffset, 50, 50) },
            {55, new Rectangle(400, 300 + Globals.YOffset, 50, 50) },
            {56, new Rectangle(450, 300 + Globals.YOffset, 50, 50) },
            {57, new Rectangle(500, 300 + Globals.YOffset, 50, 50) },
            {58, new Rectangle(550, 300 + Globals.YOffset, 50, 50) },
            {59, new Rectangle(600, 300 + Globals.YOffset, 50, 50) },
            {60, new Rectangle(650, 300 + Globals.YOffset, 50, 50) },

            {61, new Rectangle(100, 350 + Globals.YOffset, 50, 50) },
            {62, new Rectangle(150, 350 + Globals.YOffset, 50, 50) },
            {63, new Rectangle(200, 350 + Globals.YOffset, 50, 50) },
            {64, new Rectangle(250, 350 + Globals.YOffset, 50, 50) },
            {65, new Rectangle(300, 350 + Globals.YOffset, 50, 50) },
            {66, new Rectangle(350, 350 + Globals.YOffset, 50, 50) },
            {67, new Rectangle(400, 350 + Globals.YOffset, 50, 50) },
            {68, new Rectangle(450, 350 + Globals.YOffset, 50, 50) },
            {69, new Rectangle(500, 350 + Globals.YOffset, 50, 50) },
            {70, new Rectangle(550, 350 + Globals.YOffset, 50, 50) },
            {71, new Rectangle(600, 350 + Globals.YOffset, 50, 50) },
            {72, new Rectangle(650, 350 + Globals.YOffset, 50, 50) },

            {73, new Rectangle(100, 400 + Globals.YOffset, 50, 50) },
            {74, new Rectangle(150, 400 + Globals.YOffset, 50, 50) },
            {75, new Rectangle(200, 400 + Globals.YOffset, 50, 50) },
            {76, new Rectangle(250, 400 + Globals.YOffset, 50, 50) },
            {77, new Rectangle(300, 400 + Globals.YOffset, 50, 50) },
            {78, new Rectangle(350, 400 + Globals.YOffset, 50, 50) },
            {79, new Rectangle(400, 400 + Globals.YOffset, 50, 50) },
            {80, new Rectangle(450, 400 + Globals.YOffset, 50, 50) },
            {81, new Rectangle(500, 400 + Globals.YOffset, 50, 50) },
            {82, new Rectangle(550, 400 + Globals.YOffset, 50, 50) },
            {83, new Rectangle(600, 400 + Globals.YOffset, 50, 50) },
            {84, new Rectangle(650, 400 + Globals.YOffset, 50, 50) }
        };

        public static Rectangle plainScr { get { return new Rectangle(0, 0, 16, 16); } }
        public static Rectangle diamondScr { get { return new Rectangle(17, 0, 16, 16); } }
        public static Rectangle upChunkScr { get { return new Rectangle(34, 0, 16, 16); } }
        public static Rectangle sideChunkScr { get { return new Rectangle(51, 0, 16, 16); } }
        public static Rectangle staircaseScr { get { return new Rectangle(51, 17, 16, 16); } }
        public static Rectangle blueTileScr { get { return new Rectangle(34, 17, 16, 16); } }
        public static Rectangle whiteStairScr { get { return new Rectangle(17, 34, 16, 16); } }
        public static Rectangle whiteBrickScr { get { return new Rectangle(0, 34, 16, 16); } }
        public static Rectangle blackBlockScr { get { return new Rectangle(0, 17, 16, 16); } }
        public static Rectangle dotTileScr { get { return new Rectangle(17, 17, 16, 16); } }

        public static Rectangle NorthEastCollisionBlock { get { return new Rectangle(0, 0, 348, 62); } }
        public static Rectangle NorthWestCollisionBlock { get { return new Rectangle(453, 0, 347, 62); } }
        public static Rectangle SouthEastCollisionBlock { get { return new Rectangle(0, 393, 348, 87); } }
        public static Rectangle SouthWestCollisionBlock { get { return new Rectangle(453, 393, 347, 87); } }
        public static Rectangle WestNorthCollisionBlock { get { return new Rectangle(0, 87, 101, 110); } }
        public static Rectangle WestSouthCollisionBlock { get { return new Rectangle(0, 287, 101, 106); } }
        public static Rectangle EastNorthCollisionBlock { get { return new Rectangle(698, 87, 101, 110); } }
        public static Rectangle EastSouthCollisionBlock { get { return new Rectangle(698, 287, 101, 106); } }

        public static Rectangle bombSrc { get { return new Rectangle(135, 0, 9, 15); } }
        public static Rectangle clockSrc { get { return new Rectangle(57, 0, 13, 17); } }
        public static Rectangle compassSrc { get { return new Rectangle(258, 1, 11, 12); } }
        public static Rectangle heartSrc { get { return new Rectangle(0, 0, 7, 8); } }
        public static Rectangle blueheartSrc { get { return new Rectangle(0, 8, 7, 8); } }
        public static Rectangle keySrc { get { return new Rectangle(240, 0, 8, 16); } }
        public static Rectangle mapSrc { get { return new Rectangle(88, 0, 8, 16); } }
        public static Rectangle rupeeSrc { get { return new Rectangle(72, 0, 8, 16); } }
        public static Rectangle bluerupeeSrc { get { return new Rectangle(72, 16, 8, 16); } }

        public static Rectangle heartcontainerSrc { get { return new Rectangle(25, 0, 13, 14); } }
        public static Rectangle triforcepieceSrc { get { return new Rectangle(275, 3, 10, 10); } }
        public static Rectangle bluetriforcepieceSrc { get { return new Rectangle(275, 19, 10, 10); } }
        public static Rectangle boomerangSrc { get { return new Rectangle(129, 3, 5, 8); } }
        public static Rectangle bowSrc { get { return new Rectangle(144, 0, 8, 16); } }
        public static Rectangle arrowSrc { get { return new Rectangle(154, 0, 5, 16); } }
        public static Rectangle fairySrc { get { return new Rectangle(40, 0, 8, 16); } }
        public static Rectangle fairytwoSrc { get { return new Rectangle(48, 0, 8, 16); } }
        public static Rectangle bluecandleSrc { get { return new Rectangle(160, 16, 8, 16); } }
        public static Rectangle bluepotionSrc { get { return new Rectangle(80, 16, 8, 16); } }

        //my futile attempt to avoid making a Projectile class, probably will delete
        public static bool changeDirection = false;

        public static IEnemy[] enemies = { new Keese(200,200), new Rope(200, 200), new Gel(200, 200), new Zol(200, 200), new SpikeTrap(200, 200), new Dodongo(200, 200), new Goriya(200, 200), new Hand(200,200), new Stalfos(200,200), new Aquamentus(200,200) };
        public static Rectangle KeeseSprite1 { get { return new Rectangle(33, 34, 16, 8); } }
        public static Rectangle KeeseSprite2 { get { return new Rectangle(34, 43, 16, 11); } }

        public static Rectangle RopeSprite1 { get { return new Rectangle(18, 18, 14, 15); } }
        public static Rectangle RopeSprite2 { get { return new Rectangle(33, 18, 15, 15); } }

        public static Rectangle ZolSprite1 { get { return new Rectangle(18, 1, 13, 16); } }
        public static Rectangle ZolSprite2 { get { return new Rectangle(34, 1, 14, 16); } }

        public static Rectangle GelSprite1 { get { return new Rectangle(0, 1, 9, 9); } }
        public static Rectangle GelSprite2 { get { return new Rectangle(10, 1, 8, 9); } }

        public static Rectangle SpikeTrapSprite { get { return new Rectangle(1, 11, 16, 16); } }
        
        public static Rectangle DodongoUp { get { return new Rectangle(35, 35, 15, 16); } }
        public static Rectangle DodongoDown { get { return new Rectangle(1, 35, 15, 16); } }
        public static Rectangle DodongoRight1 { get { return new Rectangle(69, 35, 28, 18); } }
        public static Rectangle DodongoRight2 { get { return new Rectangle(102, 35, 28, 18); } }
        public static Rectangle DodongoUpAttacked { get { return new Rectangle(52, 35, 16, 16); } }
        public static Rectangle DodongoDownAttacked { get { return new Rectangle(17, 35, 17, 16); } }
        public static Rectangle DodongoRightAttacked { get { return new Rectangle(135, 35, 32, 16); } }

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

        public static Rectangle HandGreen2 { get { return new Rectangle(68, 1, 16, 16); } }
        public static Rectangle HandTeal1 { get { return new Rectangle(50, 18, 17, 16); } }
        public static Rectangle HandBlue1 { get { return new Rectangle(50, 35, 17, 16); } }
        public static Rectangle HandRed1 { get { return new Rectangle(50, 52, 17, 16); } }
        public static Rectangle HandRed2 { get { return new Rectangle(68, 52, 16, 16); } }

        public static Rectangle StalfosGreen { get { return new Rectangle(1, 34, 15, 16); } }
        public static Rectangle StalfosTeal { get { return new Rectangle(17, 34, 15, 16); } }
        public static Rectangle StalfosRed { get { return new Rectangle(1, 51, 15, 16); } }
        public static Rectangle StalfosBlue { get { return new Rectangle(17, 51, 15, 16); } }

        public static Rectangle GoriyaBoomerang1 { get { return new Rectangle(0, 74, 7, 9); } }
        public static Rectangle GoriyaBoomerang2 { get { return new Rectangle(10, 74, 9, 9); } }
        public static Rectangle GoriyaBoomerang3 { get { return new Rectangle(20, 76, 9, 6); } }
        
        public static int currentIndex = 0;
        public static Rectangle[] GoriyaBoomerangLeft = { GoriyaBoomerang1, GoriyaBoomerang2, GoriyaBoomerang3, GoriyaBoomerang2, GoriyaBoomerang1, GoriyaBoomerang2, GoriyaBoomerang3, GoriyaBoomerang2 };
        public static SpriteEffects[] GoriyaBoomerangLeftEffects = { SpriteEffects.None, SpriteEffects.None, SpriteEffects.None, SpriteEffects.FlipHorizontally, SpriteEffects.FlipHorizontally, SpriteEffects.FlipHorizontally | SpriteEffects.FlipVertically, SpriteEffects.FlipVertically, SpriteEffects.FlipVertically };

        public static Rectangle[] GoriyaBoomerangUp = { GoriyaBoomerang1, GoriyaBoomerang2, GoriyaBoomerang2, GoriyaBoomerang2, GoriyaBoomerang1, GoriyaBoomerang2, GoriyaBoomerang3, GoriyaBoomerang2 }; 
        public static Rectangle[] GoriyaBoomerangRight = { GoriyaBoomerang1, GoriyaBoomerang2, GoriyaBoomerang2, GoriyaBoomerang2, GoriyaBoomerang1, GoriyaBoomerang2, GoriyaBoomerang3, GoriyaBoomerang2 }; 
        public static Rectangle[] GoriyaBoomerangDown = { GoriyaBoomerang1, GoriyaBoomerang2, GoriyaBoomerang2, GoriyaBoomerang2, GoriyaBoomerang1, GoriyaBoomerang2, GoriyaBoomerang3, GoriyaBoomerang2 };
        public static int boomerangSpeed = 3;
        public static int boomerangSpriteSwitchSpeed = 20;
        
        public static Rectangle StalfosSprite { get { return new Rectangle(34, 18, 15, 16); } }

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
        public static int fireballSpeed = 2;
        public static int fireballSpriteSwitchSpeed = 40;

        public static Rectangle[] AquamentusFireballLeft = {AquamentusFireball1, AquamentusFireball2, AquamentusFireball3, AquamentusFireball4, AquamentusFireball1, AquamentusFireball2, AquamentusFireball3, AquamentusFireball4 };
        public static SpriteEffects[] AquamentusFireballLeftEffects = { SpriteEffects.None, SpriteEffects.None, SpriteEffects.None, SpriteEffects.None, SpriteEffects.None, SpriteEffects.None, SpriteEffects.None, SpriteEffects.None };
        public static Vector2 temp = new Vector2(0, 0);
        public static Vector2[] AquamentusOriginsLeft = { temp, temp, temp, temp, temp, temp, temp, temp };
        public static int fireBallMaxDistance = 300;

        public static Rectangle DungeonStandard { get { return new Rectangle(1, 1, 256, 176); } }

        public static Rectangle NorthDoorPosition { get { return new Rectangle(348, 0 + Globals.YOffset, 105, 100); } }
        public static Rectangle SouthDoorPosition { get { return new Rectangle(348, 450 + Globals.YOffset, 105, 100); } }
        public static Rectangle EastDoorPosition { get { return new Rectangle(700, 227 + Globals.YOffset, 100, 94); } }
        public static Rectangle WestDoorPosition { get { return new Rectangle(0, 227 + Globals.YOffset, 100, 94); } }

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
    }

}
