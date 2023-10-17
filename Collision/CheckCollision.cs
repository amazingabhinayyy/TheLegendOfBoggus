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

namespace Sprint2_Attempt3.Collision
{
    internal class CheckCollision
    {
        public List<Rectangle> wallBlocks;
        
        public CheckCollision(Link link)
        {
            wallBlocks = Globals.WallBlocks;
            
        }
        public static bool CheckEnemyWallCollision(Rectangle spriteObject, List<Rectangle> WallBlocks)
        {
            foreach (Rectangle wall in WallBlocks)
                if (spriteObject.Intersects(wall))
                {
                    HandleCollision.HandleEnemyBlockCollision(spriteObject, wall);
                    return true;
                }
            return false;
        }

        public static bool CheckProjectileWallCollision(Rectangle spriteObject, List<Rectangle> WallBlocks)
        {
            foreach (Rectangle wall in WallBlocks)
                if (spriteObject.Intersects(wall))
                {
                    HandleCollision.HandleProjectileBlockCollision(spriteObject, wall);
                    return true;
                }
            return false;
        }

        public static bool CheckPlayerWallCollision(Rectangle spriteObject, ILink link)
        {
            foreach (Rectangle wall in Globals.WallBlocks)
                if (spriteObject.Intersects(wall))
                {
                    link.BecomeIdle();
                    return true;
                }
            return false;
        }
    }
}