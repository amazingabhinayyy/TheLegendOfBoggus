﻿using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Blocks.BlockSprites;
using Sprint2_Attempt3.Collision.SideCollisionHandlers;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Inventory;

namespace Sprint2_Attempt3.Collision
{
    public class PlayerBlockHandler
    {
        private static Vector2 LastLinkPosition = new Vector2(350, 400);
        public static void HandleLinkBlockCollision(Rectangle linkRectangle, Rectangle wall, ILink link)
        {
            Rectangle intersectRect = Rectangle.Intersect(linkRectangle, wall);
            int width = intersectRect.Width;
            ICollision side = CollisionDetector.SideDetector(linkRectangle, wall);
            if (side is BottomCollision)
            {
                link.Position = new Vector2(link.Position.X, wall.Bottom);
            }
            else if (side is LeftCollision)
            {
                link.Position = new Vector2(wall.Left - link.GetHitBox().Width - 1, link.Position.Y);
            }
            else if (side is RightCollision)
            {
                link.Position = new Vector2(wall.Right, link.Position.Y);
            }
            else
            {
                link.Position = new Vector2(link.Position.X, wall.Top - link.GetHitBox().Height - 1);
            }
        }

        public static void HandlePlayerBlockCollision(ILink link, IGameObject obj, ICollision side)
        {
            bool blocked = false;
            if (obj is IBlock)
            {
                var block = (IBlock)obj;
                if(block is IMovingBlock && !((IMovingBlock)block).Moved)
                {
                    ((IMovingBlock)block).MoveBlock(side);
                }
                if (!block.isWalkable)
                {
                    blocked = true;
                }
            }
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
                if (door.IsLocked && InventoryController.GetCount("Key") > 0)
                {
                    door.Open();
                    InventoryController.DecrementCount("Key");
                }
                else
                {
               ;
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
                }
            } 

            else{
               
                //TransitionHandler transition = new TransitionHandler(door);
                //TransitionHandler transition = new TransitionHandler();
                //transition.Door = door;
                TransitionHandler.Instance.Door = door;
                link.Items.Clear();
                if (door is NorthDoor)
                {
                    
                    game.room.SwitchToNorthRoom();
                    // link.Position = new Vector2(link.Position.X, 400 + Globals.YOffset);
                    link.Position = new Vector2(link.Position.X, 450 + Globals.YOffset - link.GetHitBox().Height);
                    changedRooms = true;
                    
                }  
                else if (door is EastDoor)
                {
                  
                    game.room.SwitchToEastRoom();
                    link.Position = new Vector2(100, link.Position.Y);
                    changedRooms = true;
                    
                }
                else if (door is SouthDoor)
                {
                    
                    game.room.SwitchToSouthRoom();
                    link.Position = new Vector2(link.Position.X, 100 + Globals.YOffset);
                    changedRooms = true;
                    
                }
                else if (door is WestDoor)
                {
                   
                    game.room.SwitchToWestRoom();
                    link.Position = new Vector2(650, link.Position.Y);
                    changedRooms = true;
                    
                }
                else if (door is StairExit)
                {
                    game.room.SwitchToUpperRoom();
                    if (room != game.room)
                    {
                        link.Position = new Vector2(LastLinkPosition.X, LastLinkPosition.Y);
                        changedRooms = true;
                    }
                }
                else if (door is StairEntrance) 
                {
                    game.room.SwitchToLowerRoom();
                    LastLinkPosition = new Vector2(link.GetHitBox().X, link.GetHitBox().Y);
                    LastLinkPosition.X -= 50;
                    if (room != game.room)
                    {
                        link.Position = new Vector2(Globals.StairExitPosition.X, Globals.StairExitPosition.Y + 15);
                        changedRooms = true;
                    }
                }
            }
            return changedRooms;
        }
        
    }
}
