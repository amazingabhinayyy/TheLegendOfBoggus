using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Blocks;
using System.Collections.Generic;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Dungeon.Rooms;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Collision;



namespace Sprint2_Attempt3.Dungeon
{
    public class FadingTransitionHandler : ITransitionHandler
    {
        private int colorValue = 254;
        private int fadeIncrement = 3;
        double fadeDelay = 0.35;

        private bool start;
        private Game1 game1;
        private double elapsedTime = 0;

        private List<IGameObject> transitionGameObjectList = new List<IGameObject>();
  
        public  List<IGameObject> TransitionGameObjectList
        {
            get { return transitionGameObjectList; }
            set { transitionGameObjectList = value; }
        }

        public bool Start { get { return start; } set { start = value; } }
        
       private static FadingTransitionHandler instance = new FadingTransitionHandler();
        public static FadingTransitionHandler Instance
        {
            get
            {
                return instance;
            }
        }
        private IRoom currentRoom;
        private IRoom nextRoom = null;

        public void setGame1(Game1 game)
        {
            this.game1 = game;
        }
        public ITransitionHandler getInstance()
        {
            return instance;
        }
        public FadingTransitionHandler() { }

        public void Transition(IRoom room1, IRoom room2)
        {
            currentRoom = room1;
            nextRoom = room2;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            int color = MathHelper.Clamp(colorValue, 0, 255);

            if (fadeIncrement > 0)
            {
                ((RoomSecondary)currentRoom).room.Draw(spriteBatch, new Color(color, color, color));


                foreach (IGameObject obj in CollisionManager.GameObjectList)
                {
                    if (obj is IBlock)
                        ((IBlock)obj).Draw(spriteBatch, new Color(color, color, color));
                    else if (obj is IDoor)
                        ((IDoor)obj).Draw(spriteBatch, new Color(color, color, color));
                }
            }
            else
            {

                ((RoomSecondary)nextRoom).room.Draw(spriteBatch, new Color(color, color, color));

                foreach (IGameObject obj in transitionGameObjectList)
                {
                    if (obj is IBlock)
                        ((IBlock)obj).Draw(spriteBatch, new Color(color, color, color));
                    else if (obj is IDoor)
                        ((IDoor)obj).Draw(spriteBatch, new Color(color, color, color));

                }
            }

            if (colorValue >= 255)
            {
                start = false;
                CollisionManager.GameObjectList = transitionGameObjectList;
                game1.room = nextRoom;
                ((RoomSecondary)nextRoom).room.Draw(spriteBatch, Color.White);
                elapsedTime = 0;
                colorValue = 254;
                if (nextRoom is Room16)
                {
                    game1.link.Position = new Vector2(150, Globals.YOffset + 10);
                }
            }


        }

        public void Update()
        {
            GameTime gameTime = game1.Gametime;

            
            double time = gameTime.ElapsedGameTime.TotalSeconds;
            fadeDelay -= time;
            elapsedTime += time;

            if (fadeDelay <= 0)
            {
                fadeDelay = .01;

                colorValue -= fadeIncrement;

                if (colorValue >= 255 || colorValue <= 0)
                {
                    fadeIncrement *= -1;
                }
            }

        }
    
    }
    
}