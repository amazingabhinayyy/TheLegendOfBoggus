using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Sprint2_Attempt3.CommandClasses;
using Sprint2_Attempt3.Items.ItemClasses;

namespace Sprint2_Attempt3
{
    public class MouseController : IController
    {
        private Game1 game1;
        private MouseState mstate;
        private float timeSinceLastUpdate;
        List<ICommand> commands;
        public MouseController(Game1 game)
        {
            this.game1 = game;
            timeSinceLastUpdate = 0;
            RoomIndex = 0;
            commands = new List<ICommand>();
            RegisterCommands();

        }
        public void RegisterCommands()
        {
            commands.Add(new SwitchToNextRoom(game1));
            commands.Add(new SwitchToPrevRoom(game1));
        }

        public int RoomIndex { get; set; }

        public void Update(GameTime gameTime)
        {
            mstate = Mouse.GetState();

            bool pressed = false;
            //go through each movement key incrementing their count by one if they are currently pressed


            timeSinceLastUpdate += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (timeSinceLastUpdate > 0.2f)
            {
                if (mstate.LeftButton.Equals(ButtonState.Pressed))
                {
                    commands[0].Execute();
                 

                }
                else if (mstate.RightButton.Equals(ButtonState.Pressed))
                {

                    
                    commands[1].Execute();
              

                }


                timeSinceLastUpdate = 0;
            }




        }
    }
}
