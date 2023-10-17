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
using Sprint2_Attempt3.Dungeon.Rooms.DungeonRooms;
using System.Collections.Generic;

namespace Sprint2_Attempt3
{
    internal class Globals
    {
        public const float scale = 3.0f;
        public const int ScreenHeight = 480;
        public const int ScreenWidth = 800;

        public const int cornerX = 100;
        public const int width = 50;
        public const int cornerY = 89;
        public const int height = 43;


          

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

        public static Rectangle NorthEastCollisionBlock { get { return new Rectangle(0, 0, 348, 87); } }
        public static Rectangle NorthWestCollisionBlock { get { return new Rectangle(453, 0, 347, 87); } }
        public static Rectangle SouthEastCollisionBlock { get { return new Rectangle(0, 393, 348, 87); } }
        public static Rectangle SouthWestCollisionBlock { get { return new Rectangle(453, 393, 347, 87); } }
        public static Rectangle EastNorthCollisionBlock { get { return new Rectangle(0, 87, 98, 110); } }
        public static Rectangle EastSouthCollisionBlock { get { return new Rectangle(0, 287, 98, 106); } }
        public static Rectangle WestNorthCollisionBlock { get { return new Rectangle(700, 87, 99, 110); } }
        public static Rectangle WestSouthCollisionBlock { get { return new Rectangle(700, 287, 99, 106); } }

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
        public static int fireBallMaxDistance = 100;

        public static IDungeonRoom[] rooms = { new DungeonRoom1(), new DungeonRoom2(), new DungeonRoom3(), new DungeonRoom4(), new DungeonRoom5(), new DungeonRoom6(), new DungeonRoom7(), new DungeonRoom8(), new DungeonRoom9(), new DungeonRoom10(), new DungeonRoom11(), new DungeonRoom12(), new DungeonRoom13(), new DungeonRoom14(), new DungeonRoom15(), new DungeonRoom16(), new DungeonRoom17(), new DungeonRoom18(), };
        public static Rectangle Dungeon1 { get { return new Rectangle(515, 886, 256, 176); } }
        public static Rectangle Dungeon2 { get { return new Rectangle(258, 886, 256, 176); } }
        public static Rectangle Dungeon3 { get { return new Rectangle(772, 886, 256, 176); } }
        public static Rectangle Dungeon4 { get { return new Rectangle(515, 709, 256, 176); } }
        public static Rectangle Dungeon5 { get { return new Rectangle(258, 532, 256, 176); } }
        public static Rectangle Dungeon6 { get { return new Rectangle(515, 532, 256, 176); } }
        public static Rectangle Dungeon7 { get { return new Rectangle(772, 532, 256, 176); } }
        public static Rectangle Dungeon8 { get { return new Rectangle(1, 355, 256, 176); } }
        public static Rectangle Dungeon9 { get { return new Rectangle(258, 355, 256, 176  ); } }
        public static Rectangle Dungeon10 { get { return new Rectangle(515, 355, 256, 176); } }
        public static Rectangle Dungeon11 { get { return new Rectangle(772, 355, 256, 176); } }
        public static Rectangle Dungeon12 { get { return new Rectangle(1029, 355, 256, 176); } }
        public static Rectangle Dungeon13 { get { return new Rectangle(515, 178, 256, 176); } }
        public static Rectangle Dungeon14 { get { return new Rectangle(1029, 178, 256, 176); } }
        public static Rectangle Dungeon15 { get { return new Rectangle(1286, 178, 256, 176); } }
        public static Rectangle Dungeon16 { get { return new Rectangle(1, 1, 256, 160); } }
        public static Rectangle Dungeon17 { get { return new Rectangle(258, 1, 256, 176); } }
        public static Rectangle Dungeon18 { get { return new Rectangle(515, 1, 256, 176); } }

        public static Rectangle NorthDoorPosition { get { return new Rectangle(348,0, 105, 87); } }
        public static Rectangle SouthDoorPosition { get { return new Rectangle(348, 393, 105, 87); } }
        public static Rectangle EastDoorPosition { get { return new Rectangle(700, 197, 100, 88); } }
        public static Rectangle WestDoorPosition { get { return new Rectangle(0, 197, 98, 88); } }

        public static Rectangle OpenNorthDoor { get { return new Rectangle(848, 11, 31, 32); } }
        public static Rectangle OpenSouthDoor { get { return new Rectangle(848, 110, 31, 32); } }
        public static Rectangle OpenWestDoor { get { return new Rectangle(848, 44, 31, 32); } }
        public static Rectangle OpenEastDoor { get { return new Rectangle(848, 77, 31, 32); } }

        public static Rectangle ClosedNorthDoor { get { return new Rectangle(881, 11, 31, 32); } }
        public static Rectangle ClosedSouthDoor { get { return new Rectangle(881, 110, 31, 32); } }
        public static Rectangle ClosedWestDoor { get { return new Rectangle(881, 44, 31, 32); } }
        public static Rectangle ClosedEasttDoor { get { return new Rectangle(881, 77, 31, 32); } }

        public static Rectangle DiamondLockedNorthDoor { get { return new Rectangle(914, 11, 31, 32); } }
        public static Rectangle DiamondLockedSouthDoor { get { return new Rectangle(914, 110, 31, 32); } }
        public static Rectangle DiamondLockedWestDoor { get { return new Rectangle(914, 44, 31, 32); } }
        public static Rectangle DiamondLockedEastDoor { get { return new Rectangle(914, 77, 31, 32); } }

        public static Rectangle DamagedNorthDoor { get { return new Rectangle(947, 11, 31, 32); } }
        public static Rectangle DamagedSouthDoor { get { return new Rectangle(947, 110, 31, 32); } }
        public static Rectangle DamagedWestDoor { get { return new Rectangle(947, 44, 31, 32); } }
        public static Rectangle DamagedEastDoor { get { return new Rectangle(947, 77, 31, 32); } }
    }
}
