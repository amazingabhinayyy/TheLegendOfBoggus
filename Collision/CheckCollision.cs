using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Enemy;

namespace Sprint2_Attempt3.Collision
{
    internal class CheckCollision
    {
        public CheckCollision()
        {

        }
        public static bool CheckWallCollision(Rectangle spriteObject, List<Rectangle> WallBlocks)
        {
            foreach (Rectangle wall in WallBlocks)
                if (spriteObject.Intersects(wall))
                {
                    return true;
                }
            return false;
        }
    }
}