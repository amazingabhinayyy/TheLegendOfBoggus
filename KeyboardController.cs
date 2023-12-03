using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Sprint2_Attempt3.CommandClasses;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Screens;

namespace Sprint2_Attempt3
{
    public class KeyboardController : IController
    {
        private Game1 game1;
        private float timeSinceLastUpdate;
        private Dictionary<Keys, ICommand> commandMapping = new Dictionary<Keys, ICommand>();
        private Dictionary<Keys, int> moveKeyTime = new Dictionary<Keys, int>();
        private List<Keys> moveKeys = new List<Keys>();
        private int currentMoveKeyValue = 10;
        private Keys currentMoveKey;
        private List<Keys> heldKeys = new List<Keys>();

        public int RoomIndex { get; set; }

        public KeyboardController(Game1 game)
        {
            this.game1 = game;
            commandMapping = new Dictionary<Keys, ICommand>();
            RegisterCommands();
            timeSinceLastUpdate = 0;
            RoomIndex = 0;
        }

        public void RegisterCommands()
        {
            //Link movements
            commandMapping.Add(Keys.W, new MoveLinkUp(game1));
            commandMapping.Add(Keys.S, new MoveLinkDown(game1));
            commandMapping.Add(Keys.A, new MoveLinkLeft(game1));
            commandMapping.Add(Keys.D, new MoveLinkRight(game1));
            commandMapping.Add(Keys.Up, new MoveLinkUp(game1));
            commandMapping.Add(Keys.Down, new MoveLinkDown(game1));
            commandMapping.Add(Keys.Left, new MoveLinkLeft(game1));
            commandMapping.Add(Keys.Right, new MoveLinkRight(game1));
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
            
            //other controls
            commandMapping.Add(Keys.Q, new Quit(game1));
            commandMapping.Add(Keys.R, new Reset(game1, game1.room));
            commandMapping.Add(Keys.Escape, new Pause(game1));

            //switching rooms
            commandMapping.Add(Keys.Space, new ToggleItemMenu(game1));

            //Item Menu
            commandMapping.Add(Keys.O, new UseAItem());
            commandMapping.Add(Keys.P, new UseBItem());
            commandMapping.Add(Keys.V, new SetAItem());
            commandMapping.Add(Keys.B, new SetBItem());
            commandMapping.Add(Keys.U, new ShiftItemSelectorUp());
            commandMapping.Add(Keys.J, new ShiftItemSelectorDown());
            commandMapping.Add(Keys.H, new ShiftItemSelectorLeft());
            commandMapping.Add(Keys.K, new ShiftItemSelectorRight());

            moveKeyTime.Add(Keys.W, 0);
            moveKeyTime.Add(Keys.A, 0);
            moveKeyTime.Add(Keys.S, 0);
            moveKeyTime.Add(Keys.D, 0);
            moveKeyTime.Add(Keys.Up, 0);
            moveKeyTime.Add(Keys.Down, 0);
            moveKeyTime.Add(Keys.Left, 0);
            moveKeyTime.Add(Keys.Right, 0);

            moveKeys = moveKeyTime.Keys.ToList();

            //Commands For Testing
            commandMapping.Add(Keys.E, new IncreaseHealthCommand(game1));
            commandMapping.Add(Keys.T, new IncreaseKeyCommand(game1));


        }

        public void Update(GameTime gameTime)
        {
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();
            if (game1.gamePaused)
            {
                if (pressedKeys.Contains(Keys.Enter))
                {
                    game1.gamePaused = false;
                }
                else if (pressedKeys.Contains(Keys.R))
                {
                    commandMapping[Keys.R].Execute();
                }
                else if (pressedKeys.Contains(Keys.Q))
                {
                    commandMapping[Keys.Q].Execute();
                }
            }
            else if (game1.gameStarted)
            {
                bool pressed = false;
                //go through each movement key incrementing their count by one if they are currently pressed
                foreach (Keys key in moveKeys)
                {
                    if (pressedKeys.Contains(key))
                    {
                        pressed = true;
                        moveKeyTime[key] += 1;
                        currentMoveKeyValue = moveKeyTime[key];
                    }
                    else
                    {
                        moveKeyTime[key] = 0;
                    }
                }
                if (!pressed)
                {
                    currentMoveKey = Keys.None;
                }
                //now find most recently pressed movement key
                foreach (Keys key in moveKeys)
                {
                    if (moveKeyTime[key] > 0 && moveKeyTime[key] <= currentMoveKeyValue)
                    {
                        currentMoveKeyValue = moveKeyTime[key];
                        currentMoveKey = key;
                    }
                }

                List<Keys> pressedKeys2 = new List<Keys>();
                for (int j = 0; j < pressedKeys.Length; j++)
                {
                    if (!moveKeys.Contains(pressedKeys[j]))
                    {
                        pressedKeys2.Add(pressedKeys[j]);
                    }
                }
                if (currentMoveKey != Keys.None)
                {
                    pressedKeys2.Add(currentMoveKey);
                }
                pressedKeys = pressedKeys2.ToArray();



                for (int c = 0; c < heldKeys.Count; c++)
                {
                    if (!(pressedKeys.Contains(heldKeys[c])))
                    {
                        heldKeys.Remove(heldKeys[c]);
                        c--;
                    }
                }

                timeSinceLastUpdate += (float)gameTime.ElapsedGameTime.TotalSeconds;

                if (pressedKeys.Length > 0 && timeSinceLastUpdate > 0.1f)
                {
                    foreach (Keys key in pressedKeys)
                    {
                        if (commandMapping.ContainsKey(key) && !(heldKeys.Contains(key)))
                        {
                            commandMapping[key].Execute();
                            //The if condition hold keys that can be held
                            if (!(moveKeys.Contains(key)))
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
            }
            else
            {
                if(pressedKeys.Contains(Keys.Enter))
                {
                    game1.gameStarted = true;
                    game1.room.ResetRooms();
                }
            }
        }
    }
}
