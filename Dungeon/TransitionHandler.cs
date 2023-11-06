using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Blocks.BlockSprites;
using Sprint2_Attempt3.Collision.SideCollisionHandlers;
using Sprint2_Attempt3.Enemy;
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
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Dungeon.Rooms;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Collision;


namespace Sprint2_Attempt3.Dungeon
{
    public class TransitionHandler
    {
        private int transitionSpeed = 16;
        private IDoor door;
        private int multiplier = 1;
        public IDoor Door { get { return door; } set { door = value; } }

        private bool start;
        private int roomNumber;
        private Game1 game1;
        private int end;
        private float timeSinceLastUpdate = 0;

        private List<IGameObject> transitionGameObjectList = new List<IGameObject>();
  
        public  List<IGameObject> TransitionGameObjectList
        {
            get { return TransitionGameObjectList; }
            set { transitionGameObjectList = value; }
        }


        public bool Start { get { return start; } set { start = value; } }
        
       private static TransitionHandler instance = new TransitionHandler();
        public static TransitionHandler Instance
        {
            get
            {
                return instance;
            }
        }

        private IRoom currentRoom;
        private IRoom nextRoom;

        public void setGame1(Game1 game)
        {
            this.game1 = game;
        }
        public TransitionHandler(IDoor door)
        {
            this.door = door;
        }
        public TransitionHandler()
        {
        }

        public void Transition(Room1 room1, Room2 room2, int roomNum)
        {
            currentRoom = room1;
            nextRoom = room2;
            roomNumber = roomNum;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (start)
            {
                Vector2 change = Vector2.Zero;
                switch (door)
                {
                    case (NorthDoor):
                        change = new Vector2(0, -1*transitionSpeed * multiplier);
                        end = 11;
                        break;
                    case (SouthDoor):
                        change = new Vector2(0, transitionSpeed * multiplier);
                        end = 11;
                        break;
                    case (EastDoor):
                        change = new Vector2(-transitionSpeed * multiplier, 0);
                        end = 17;
                        break;
                    case (WestDoor):
                        change = new Vector2(transitionSpeed * multiplier, 0);
                        end = 17;
                        break;
                }
                
                currentRoom.getDungeonRoom().Draw(spriteBatch,change);
              
                /*
                foreach (IGameObject obj in CollisionDetector.GameObjectList)
                {
                    if (obj is IBlock)
                        ((IBlock)obj).Draw(spriteBatch,change);
                    else if (obj is IDoor)
                        ((IDoor)obj).Draw(spriteBatch,change);
                }*/

                nextRoom.getDungeonRoom().Draw(spriteBatch, change);


                multiplier++;
                /* if (end <= multiplier)
                 {
                     start = false;
                 }*/
                timeSinceLastUpdate += (float)game1.Gametime.ElapsedGameTime.TotalSeconds;
                if(timeSinceLastUpdate > 5f)
                {
                    start = false;
                    CollisionDetector.GameObjectList = transitionGameObjectList;
                    game1.room = new Room2(game1);
                    multiplier = 1;
                    timeSinceLastUpdate = 0;
                }

            }
            
               
            
        }
    }
}
