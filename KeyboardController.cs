using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Sprint2_Attempt3.CommandClasses;

namespace Sprint2_Attempt3
{
    public class KeyboardController : IController
    {
        private Game1 game1;
        private float timeSinceLastUpdate;
        private Dictionary<Keys, ICommand> commandMapping = new Dictionary<Keys, ICommand>();
        private bool pressed = true;

        public KeyboardController(Game1 game)
        {
            this.game1 = game;
            commandMapping = new Dictionary<Keys, ICommand>();
            RegisterCommands();
            timeSinceLastUpdate = 0;
        }

        public void RegisterCommands()
        {
            //Link movements
            commandMapping.Add(Keys.W, new MoveLinkUp(game1));
            commandMapping.Add(Keys.S, new MoveLinkDown(game1));
            commandMapping.Add(Keys.A, new MoveLinkLeft(game1));
            commandMapping.Add(Keys.D, new MoveLinkRight(game1));
            commandMapping.Add(Keys.E, new SetDamageLinkCommand(game1));
            commandMapping.Add(Keys.Z, new SetAttackLinkCommand(game1));
            commandMapping.Add(Keys.N, new SetAttackLinkCommand(game1));
            commandMapping.Add(Keys.None, new SetIdleLinkCommand(game1));
            //item switching
            commandMapping.Add(Keys.D1, new SwitchToItem1(game1));
            commandMapping.Add(Keys.D2, new SwitchToItem2(game1));
            commandMapping.Add(Keys.D3, new SwitchToItem3(game1));
            commandMapping.Add(Keys.X, new SwitchToSecondaryItem1(game1));
            commandMapping.Add(Keys.M, new SwitchToSecondaryItem2(game1));


            //Block switching
            commandMapping.Add(Keys.T, new SwitchToPreviousItem(game1));
            commandMapping.Add(Keys.Y, new SwitchToNextItem(game1));

            //Enemy switching
            commandMapping.Add(Keys.O, new SwitchToPreviousEnemy(game1));
            commandMapping.Add(Keys.P, new SwitchToNextEnemy(game1));
            commandMapping.Add(Keys.L, new ChangeEnemyAttackedStatus(game1));
            commandMapping.Add(Keys.K, new KillEnemy(game1));

            //other controls
            commandMapping.Add(Keys.Q, new Quit(game1));
            commandMapping.Add(Keys.R, new Reset(game1));
        }
    



        public void Update(GameTime gameTime)
        {
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();

            timeSinceLastUpdate += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (pressedKeys.Length > 0 && timeSinceLastUpdate>0.5f)
            {
                foreach (Keys key in pressedKeys)
                {
                    if (commandMapping.ContainsKey(key))
                    {
                        commandMapping[key].Execute();
                    }
                }
                timeSinceLastUpdate = 0;
                
            }

            /*
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();
            if (pressedKeys.Length > 0 && pressed)
            {
                foreach (Keys key in pressedKeys)
                {
                    if (commandMapping.ContainsKey(key))
                    {
                        commandMapping[key].Execute();
                    }
                }
                pressed = false;
            }
            else
            {
                if (pressedKeys.Length == 0)
                {
                    pressed = true;
                }
            }*/

        }
    }
}
