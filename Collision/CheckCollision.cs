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
using Sprint2_Attempt3.WallBlocks;

namespace Sprint2_Attempt3.Collision
{
    internal class CheckCollision
    {
        public List<Rectangle> wallBlocks;
        
        public CheckCollision(Link link)
        {
            wallBlocks = Globals.WallBlocks; 
        }
        public static bool CheckEnemyWallCollision(IEnemy enemy, IGameObject obj, Rectangle collisionRectangle)
        {
            if (obj is IWall)
            {
                var wall = (IWall)obj;
                HandleCollision.HandleEnemyBlockCollision(collisionRectangle, enemy);
                return true;
            } else if (obj is IBlock)
            {
                var block = (IBlock)obj;
                HandleCollision.HandleEnemyBlockCollision(collisionRectangle, enemy);
                return true;
            }
            return false;
            //}
            //else if (obj is IBlock)
            //{
            //  foreach (Rectangle block in )
            // }


        }
        
        public static bool CheckProjectileWallCollision(ILinkProjectile projectile)
        {
            /*foreach (Rectangle wall in Globals.WallBlocks)
                if (projectile.GetHitBox().Intersects(wall))
                {
                    HandleCollision.HandleProjectileBlockCollision(projectile);
                    return true;
                }*/
            return false;
        }
        
        public static bool CheckPlayerWallCollision(ILink link)
        {
            foreach (Rectangle wall in Globals.WallBlocks)
                if (link.GetHitBox().Intersects(wall))
                {
                    HandleCollision.HandlePlayerBlockCollision(wall, link);
                    return true;
                }
            return false;
        }
    }
}