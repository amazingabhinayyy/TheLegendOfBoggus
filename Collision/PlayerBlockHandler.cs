using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Blocks.BlockSprites;
using Sprint2_Attempt3.Collision.SideCollisionHandlers;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Player.Interfaces;
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
using System.Reflection.Metadata.Ecma335;

namespace Sprint2_Attempt3.Collision
{
    public class PlayerBlockHandler
    {
        public static void HandleLinkBlockCollision(Rectangle linkRectangle, Rectangle wall, ILink link)
        {
            Rectangle intersectRect = Rectangle.Intersect(linkRectangle, wall);
            int width = intersectRect.Width;
            ICollision side = CollisionDetector.SideDetector(linkRectangle, wall);
            if (side is BottomCollision)
            {
                link.Position = new Vector2(link.Position.X, wall.Bottom);
                //link.position.Y = wall.Bottom;
            }
            else if (side is LeftCollision)
            {
                link.Position = new Vector2(wall.Left - link.GetHitBox().Width - 1, link.Position.Y);
                //link.position.X = wall.Right - wall.Width - 45;
            }
            else if (side is RightCollision)
            {
                link.Position = new Vector2(wall.Right, link.Position.Y);
                //link.position.X = wall.Right;
            }
            else
            {
                link.Position = new Vector2(link.Position.X, wall.Top - link.GetHitBox().Height - 1);
                //link.position.Y = wall.Top - wall.Height + 40;
            }
        }

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
            /*else if (obj is IWall)
            {
                blocked = true;
            }*/
            else if (obj is IDoor) {
                blocked = !(((IDoor)obj).IsWalkable);
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

        public static bool HandlePlayerDoorCollision(ILink link, IDoor door, ICollision side, Game1 game)
        {
            bool changedRooms = false;
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
                // add door transition stuff
            {
                IRoom room = game.room;
                if (door is NorthDoor)
                {
                    game.room.SwitchToNorthRoom();
                    if (room != game.room)
                    {
                        link.Position = new Vector2(link.Position.X, 300);
                        changedRooms = true;
                        //System.Diagnostics.Debug.WriteLine(link.Position.Y);
                    }
                }  
                else if (door is EastDoor)
                {
                    game.room.SwitchToEastRoom();
                    if (room != game.room)
                    {
                        link.Position = new Vector2(100, link.Position.Y);
                        changedRooms = true;
                    }
                }
                else if (door is SouthDoor)
                {
                    game.room.SwitchToSouthRoom();
                    if (room != game.room)
                    {
                        link.Position = new Vector2(link.Position.X, 90);
                        changedRooms = true;
                    }
                }
                else if (door is WestDoor)
                {
                    game.room.SwitchToWestRoom();
                    if (room != game.room)
                    {
                        link.Position = new Vector2(630, link.Position.Y);
                        changedRooms = true;
                    }
                }
            }
            return changedRooms;
        }
        
    }
}
