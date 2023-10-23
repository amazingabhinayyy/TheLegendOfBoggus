using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Blocks.BlockSprites;
using Sprint2_Attempt3.Collision.SideCollisionHandlers;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Interfaces;
using Sprint2_Attempt3.Player.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.WallBlocks;

namespace Sprint2_Attempt3.Collision
{
    public class PlayerBlockHandler
    {
        public static void HandlePlayerBlockCollision(ILink link, IWall block, ICollision side)
        {
            if (!(block is DotTile))
            {
                Rectangle wall = block.GetHitBox();
                if (side is BottomCollision)
                {
                    link.Position = new Vector2(link.Position.X, wall.Bottom);
                }
                else if (side is LeftCollision)
                {
                    link.Position = new Vector2(wall.Right - wall.Width - 45, link.Position.Y);
                }
                else if (side is RightCollision)
                {
                    link.Position = new Vector2(wall.Right, link.Position.Y);
                }
                else
                {
                    link.Position = new Vector2(link.Position.X, wall.Top - wall.Height + 40);
                }
            }
        }

    }
}
