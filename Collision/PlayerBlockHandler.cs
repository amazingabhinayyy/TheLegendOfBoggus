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
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Player;

namespace Sprint2_Attempt3.Collision
{
    public class PlayerBlockHandler
    {
        public static void HandlePlayerBlockCollision(ILink link, IGameObject obj, ICollision side)
        {
            bool blocked = false;
            if (obj is IBlock)
            {
                var block = (IBlock)obj;
                if (!block.isWalkable)
                {
                    blocked = true;
                }
            }
            else if (obj is IWall)
            {
                blocked = true;
            }
            if (blocked)
            {
                Rectangle wall = obj.GetHitBox();
                if (side is BottomCollision)
                {
                    link.Position = new Vector2(link.Position.X, wall.Bottom);
                }
                else if (side is LeftCollision)
                {
                    link.Position = new Vector2(wall.Left - link.GetHitBox().Width, link.Position.Y);
                }
                else if (side is RightCollision)
                {
                    link.Position = new Vector2(wall.Right, link.Position.Y);
                }
                else
                {
                    link.Position = new Vector2(link.Position.X, wall.Top - link.GetHitBox().Height);
                }
            }
        }

        public static void HandlePlayerDoorCollision(ILink link, IDoor door, ICollision side, Game1 game)
        {
            if (!door.IsWalkable)
            {
                Rectangle wall = door.GetHitBox();
                if (side is BottomCollision)
                {
                    link.Position = new Vector2(link.Position.X, wall.Bottom);
                }
                else if (side is LeftCollision)
                {
                    link.Position = new Vector2(wall.Left - link.GetHitBox().Width, link.Position.Y);
                }
                else if (side is RightCollision)
                {
                    link.Position = new Vector2(wall.Right, link.Position.Y);
                }
                else
                {
                    link.Position = new Vector2(link.Position.X, wall.Top - link.GetHitBox().Height);
                }
            } else
            {
                IRoom room = game.room;
                if (door is NorthDoor)
                {
                    game.room.SwitchToSouthRoom();
                    if (room != game.room)
                    {
                        link.Position = new Vector2(link.Position.X, 300);
                    }
                }  
                else if (door is EastDoor)
                {
                    game.room.SwitchToWestRoom();
                    if (room != game.room)
                    {
                        link.Position = new Vector2(95, link.Position.Y);
                    }
                }
                else if (door is SouthDoor)
                {
                    game.room.SwitchToNorthRoom();
                    if (room != game.room)
                    {
                        link.Position = new Vector2(link.Position.X, 90);
                    }
                }
                else if (door is WestDoor)
                {
                    game.room.SwitchToEastRoom();
                    if (room != game.room)
                    {
                        link.Position = new Vector2(675, link.Position.Y);
                    }
                }
            }
        }
        
    }
}
