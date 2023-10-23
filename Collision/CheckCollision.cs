using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Interfaces;

namespace Sprint2_Attempt3.Collision
{
    internal class CheckCollision
    {
        public List<Rectangle> wallBlocks;
        
        public CheckCollision(Link link)
        {
            wallBlocks = Globals.WallBlocks; 
        }
        public static bool CheckEnemyWallCollision(IEnemy enemy)
        {
            foreach (Rectangle wall in Globals.WallBlocks)

                if (enemy.GetHitBox().Intersects(wall)) //intersection.isEmpty??
                {
                    HandleCollision.HandleEnemyBlockCollision(wall, enemy);
                    return true;
                }
            return false;
        }
        
        public static bool CheckProjectileWallCollision(ILinkProjectile projectile)
        {
            foreach (Rectangle wall in Globals.WallBlocks)
                if (projectile.GetHitBox().Intersects(wall))
                {
                    HandleCollision.HandleProjectileBlockCollision(projectile);
                    return true;
                }
            return false;
        }
        
        public static bool CheckPlayerWallCollision(ILink link)
        {
            foreach (Rectangle wall in Globals.WallBlocks)
                if (link.GetHitBox().Intersects(wall))
                {
                    //HandleCollision.HandleLinkWallCollision(wall, link);
                    return true;
                }
            return false;
        }
    }
}