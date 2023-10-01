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

namespace Sprint2_Attempt3
{
    internal class Globals
    {
        public const float scale = 3.0f;

        //my futile attempt to avoid making a Projectile class, probably will delete
        public static bool changeDirection = false;

        public static IEnemy[] enemies = { new Keese(200,200), new Rope(200, 200), new Gel(200, 200), new Zol(200, 200), new SpikeTrap(200, 200), new Dodongo(200, 200), new Goriya(200, 200), new Hand(200,200), new Stalfos(200,200) };
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

        public static Rectangle GoriyaBoomerang1 { get { return new Rectangle(1, 74, 7, 17); } }
        public static Rectangle GoriyaBoomerang2 { get { return new Rectangle(10, 74, 9, 17); } }
        public static Rectangle GoriyaBoomerang3 { get { return new Rectangle(20, 76, 7, 17); } }

        public static Rectangle[] GoriyaBoomerangLeft = { GoriyaBoomerang1, GoriyaBoomerang2, GoriyaBoomerang2, GoriyaBoomerang2, GoriyaBoomerang1, GoriyaBoomerang2, GoriyaBoomerang3, GoriyaBoomerang2 }; 
        public static Rectangle StalfosSprite { get { return new Rectangle(34, 18, 15, 16); } }
    }
}
