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
    internal class CheckPlayerHitWallCollision
    {
        public List<Rectangle> wallBlocks;
        
        public CheckPlayerHitWallCollision(Link link)
        {
            wallBlocks = Globals.WallBlocks; 
        }
        
        public static bool CheckPlayerWallCollision(Link link)
        {
            Rectangle linkRectangle = link.GetHitBox();
            foreach (Rectangle wall in Globals.WallBlocks)
                if (link.GetHitBox().Intersects(wall))
                {
                    PlayerBlockHandler.HandleLinkBlockCollision(linkRectangle, wall, link);
                    return true;
                }
            return false;
        }
    }
}