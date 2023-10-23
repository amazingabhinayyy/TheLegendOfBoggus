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
        public static bool CheckEnemyWallCollision(Rectangle enemyObject, IEnemy enemy)
        {
            foreach (Rectangle wall in Globals.WallBlocks)

                if (enemyObject.Intersects(wall)) //intersection.isEmpty??
                {
                    //System.Diagnostics.Debug.WriteLine("testcollide");
                    /*System.Diagnostics.Debug.WriteLine("sprite: " + enemyObject.X);
                    System.Diagnostics.Debug.WriteLine("enemy: " + enemy.X);
                    HandleCollision.HandleEnemyBlockCollision(enemyObject, wall, enemy);*/
                    return true;
                }
            return false;
        }
        
        public static bool CheckProjectileWallCollision(Rectangle projObject, ILinkItem projectile)
        {
            foreach (Rectangle wall in Globals.WallBlocks)
                if (projObject.Intersects(wall)) // projectile.getType... boomerang special case
                {
                    HandleCollision.HandleProjectileBlockCollision(projObject, projectile);
                    return true;
                }
            return false;
        }
        
        public static bool CheckPlayerWallCollision(Rectangle playerObject, Link link)
        {
            // get spriteObject hitbox + 
            foreach (Rectangle wall in Globals.WallBlocks)
                if (playerObject.Intersects(wall))
                {
                    //link.BecomeIdle();
                    HandleCollision.HandleLinkBlockCollision(playerObject, wall, link);
                    return true;
                }
            return false;
        }
    }
}