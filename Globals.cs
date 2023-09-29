using Microsoft.Xna.Framework;
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
using Sprint2_Attempt3.Enemy.Goriya;

namespace Sprint2_Attempt3
{
    internal class Globals
    {
        public const float scale = 8.0f;

        //my futile attempt to avoid making a Projectile class, probably will delete
        public static bool changeDirection = false;

        public static IEnemy[] enemies = { new Keese(), new Rope(), new Gel(), new Zol(), new SpikeTrap(), new Dodongo(), new Goriya() };
        public static Rectangle KeeseSprite1 { get { return new Rectangle(33, 34, 16, 8); } }
        public static Rectangle KeeseSprite2 { get { return new Rectangle(34, 43, 16, 11); } }
        
        public static Rectangle RopeSprite1 { get { return new Rectangle(18, 18, 14, 15); } }
        public static Rectangle RopeSprite2 { get { return new Rectangle(33, 18, 15, 15); } }

        public static Rectangle ZolSprite1 { get { return new Rectangle(18, 1, 13, 16); } }
        public static Rectangle ZolSprite2 { get { return new Rectangle(34, 1, 14, 16); } }
        
        public static Rectangle GelSprite1 { get { return new Rectangle(0, 1, 9, 9); } }
        public static Rectangle GelSprite2 { get { return new Rectangle(10, 1, 8, 9); } }

        public static Rectangle SpikeTrapSprite { get { return new Rectangle(1, 11, 16, 16); } }
        
        public static Rectangle HandSprite1 { get { return new Rectangle(19, 18, 14, 16); } }
        public static Rectangle HandSprite2 { get { return new Rectangle(34, 42, 16, 12); } }

        public static Rectangle DodongoUp { get { return new Rectangle(35, 35, 15, 16); } }
        public static Rectangle DodongoDown { get { return new Rectangle(1, 35, 15, 16); } }
        public static Rectangle DodongoRight1 { get { return new Rectangle(69, 35, 28, 18); } }
        public static Rectangle DodongoRight2 { get { return new Rectangle(102, 35, 28, 18); } }
        public static Rectangle DodongoUpAttacked { get { return new Rectangle(52, 35, 16, 16); } }
        public static Rectangle DodongoDownAttacked { get { return new Rectangle(17, 35, 17, 16); } }
        public static Rectangle DodongoRightAttacked { get { return new Rectangle(135, 35, 32, 16); } }

        public static Rectangle GoriyaBlueDown { get { return new Rectangle(84, 52, 14, 17); } } 
        public static Rectangle GoriyaBlueUp { get { return new Rectangle(101, 52, 14, 17); } }
        public static Rectangle GoriyaBlueRight { get { return new Rectangle(117, 52, 14, 17); } }
        public static Rectangle GoriyaBlueRight2 { get { return new Rectangle(135, 52, 14, 17); } }
        public static Rectangle GoriyaBoomerang1 { get { return new Rectangle(1, 74, 7, 17); } }
        public static Rectangle GoriyaBoomerang2 { get { return new Rectangle(10, 74, 9, 17); } }
        public static Rectangle GoriyaBoomerang3 { get { return new Rectangle(20, 76, 7, 17); } }
        
        

        public static Rectangle StalfosSprite { get { return new Rectangle(34, 18, 15, 16); } }
    }
}
