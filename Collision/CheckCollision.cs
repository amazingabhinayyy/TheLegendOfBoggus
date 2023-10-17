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

namespace Sprint2_Attempt3.Collision
{
    internal class CheckCollision
    {
        public CheckCollision()
        {

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

        public static bool CheckPlayerWallCollision(Rectangle spriteObject, List<Rectangle> WallBlocks)
        {
            foreach (Rectangle wall in WallBlocks)
                if (spriteObject.Intersects(wall))
                {
                    HandleCollision.HandleLinkBlockCollision(spriteObject, wall);
                    return true;
                }
            return false;
        }
    }
}