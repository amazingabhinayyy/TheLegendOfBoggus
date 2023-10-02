using System;
using System.Collections.Generic;
using System.Linq;
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
        private static int enemyIndex;
        private bool pressed = true;
        private List<Keys> heldKeys = new List<Keys>();

        public int EnemyIndex { 
            get { return enemyIndex; }
            set { enemyIndex = value; }
        }

        public KeyboardController(Game1 game)
        {
            this.game1 = game;
            commandMapping = new Dictionary<Keys, ICommand>();
            RegisterCommands();
            enemyIndex = 0;
            timeSinceLastUpdate = 0;
        }

        public void RegisterCommands()
        {
            //Link movements
            commandMapping.Add(Keys.W, new MoveLinkUp(game1));
            commandMapping.Add(Keys.Up, new MoveLinkUp(game1));
            commandMapping.Add(Keys.S, new MoveLinkDown(game1));
            commandMapping.Add(Keys.Down, new MoveLinkDown(game1));
            commandMapping.Add(Keys.A, new MoveLinkLeft(game1));
            commandMapping.Add(Keys.Left, new MoveLinkLeft(game1));
            commandMapping.Add(Keys.D, new MoveLinkRight(game1));
            commandMapping.Add(Keys.Right, new MoveLinkRight(game1));
            commandMapping.Add(Keys.E, new SetDamageLinkCommand(game1));
            commandMapping.Add(Keys.Z, new SetAttackLinkCommand(game1));
            commandMapping.Add(Keys.N, new SetAttackLinkCommand(game1));
            commandMapping.Add(Keys.None, new SetIdleLinkCommand(game1));
            //item switching
            commandMapping.Add(Keys.D1, new SetUseBombCommand(game1));
            commandMapping.Add(Keys.D2, new SetUseBoomerangCommand(game1));
            commandMapping.Add(Keys.D3, new SetUseArrowCommand(game1));
            commandMapping.Add(Keys.D4, new SetUseBlueBoomerangCommand(game1));
            commandMapping.Add(Keys.D5, new SetUseBlueArrowCommand(game1));
            commandMapping.Add(Keys.D6, new SetUseFireCommand(game1));
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
            for(int c = 0; c < heldKeys.Count; c++)
            {
                if (!(pressedKeys.Contains(heldKeys[c])))
                {
                    heldKeys.Remove(heldKeys[c]);
                    c--;
                }
            }

            timeSinceLastUpdate += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (pressedKeys.Length > 0 && timeSinceLastUpdate>0.1f)
            {
                foreach (Keys key in pressedKeys)
                {
                    if (commandMapping.ContainsKey(key) && !(heldKeys.Contains(key)))
                    {
                        commandMapping[key].Execute();
                        //The if condition hold keys that can be held
                        if(!(key.Equals(Keys.W) || key.Equals(Keys.A) || key.Equals(Keys.S)|| key.Equals(Keys.D) || key.Equals(Keys.Down) || key.Equals(Keys.Up) || key.Equals(Keys.Right) || key.Equals(Keys.Left)))
                        {
                            heldKeys.Add(key);
                        }
                    }
                }
                timeSinceLastUpdate = 0;     
            }
            if (!(pressedKeys.Contains(Keys.W) || pressedKeys.Contains(Keys.S) || pressedKeys.Contains(Keys.A) || pressedKeys.Contains(Keys.D) || pressedKeys.Contains(Keys.Up) || pressedKeys.Contains(Keys.Down) || pressedKeys.Contains(Keys.Left) || pressedKeys.Contains(Keys.Right)))
            {
                commandMapping[Keys.None].Execute();
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
