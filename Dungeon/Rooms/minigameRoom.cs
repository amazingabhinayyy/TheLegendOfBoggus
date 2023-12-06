using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Target;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Sounds;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class MinigameRoom : RoomSecondary
    {
        private static List<IEnemy> enemies;
        private int counter;
        private int score;
        bool finish;
        private ScoreKeeper scoreKeeper;
        private TriggerSquare trigger = new TriggerSquare(378, 520);
        MinigameRoomHelper minigameRoomHelper;
        private bool firstTime;
        public MinigameRoom(Game1 game1) : base(game1, 18) 
        {
            SoundFactory.Instance.backgroundMusic.Pause();
            SoundFactory.Instance.undertaleMusic.Play();
            counter = 900;
            score = 0;
            scoreKeeper = new ScoreKeeper(score, counter);
            finish = false;
            minigameRoomHelper = new MinigameRoomHelper(gameObjectLists, roomNumber);
            gameObjectLists[roomNumber].Add(trigger);
            firstTime = true;
        }
        
        public override void SwitchToSouthRoom()
        {
            for (int i = 0; i < gameObjectLists[roomNumber].Count; i++)
            {
                IGameObject obj = gameObjectLists[roomNumber][i];
                if (obj is IEnemy)
                {
                    ((IEnemy)obj).Kill();
                }
            }
            trigger.End();
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room2(game1));
            SoundFactory.Instance.undertaleMusic.Pause();
            SoundFactory.Instance.backgroundMusic.Resume();
        }
        public override void Update()
        {
            if (!finish)
            {
                if (!TransitionHandler.Instance.Start)
                {
                    if (!game1.deathAnimationActive)
                        collisionManager.Update();
                    score = 0;
                    if (trigger.isTriggered() && firstTime)
                    {
                        minigameRoomHelper.startGame();
                        firstTime = false;
                    }
                    else if(trigger.isTriggered()) 
                    {
                        counter--;
                    }
                    scoreKeeper.SetCounter(counter);
                    for (int i = 0; i < gameObjectLists[roomNumber].Count; i++)
                    {
                        IGameObject obj = gameObjectLists[roomNumber][i];
                        if (obj is IEnemy)
                        {
                            if (!spawned)
                            {
                                ((IEnemy)obj).Spawn();
                            }
                            else
                            {
                                if (counter < 0)
                                {
                                    ((IEnemy)obj).Kill();
                                    finish = true;
                                    firstTime= true;
                                    SoundFactory.PlaySound(SoundFactory.Instance.rickRoll);
                                }
                            }
                            if (!ClockUsed || ((IEnemy)obj).State is DeathAnimationState)
                            {
                                ((IEnemy)obj).Update();
                                score++;
                            }
                        }
                        else if (obj is IItem)
                        {
                            ((IItem)obj).Update();
                        }
                        else if (obj is IBlock)
                            ((IBlock)obj).Update();
                    }
                    if(trigger.isTriggered())
                        spawned = true;
                    game1.link.Update();
                    RoomConditionCheck();
                }
            }
            base.Update();
        }
        public override void Draw(SpriteBatch spriteBatch, Color color)
        {
            if (TransitionHandler.Instance.Start)
            {
                TransitionHandler.Instance.Draw(spriteBatch);
            }
            else
            {
                room.Draw(spriteBatch, color);
                scoreKeeper.Draw(spriteBatch, 45, 250);
                foreach (IGameObject obj in gameObjectLists[roomNumber])
                {
                    if (obj is IEnemy && color.Equals(Color.White))
                        ((IEnemy)obj).Draw(spriteBatch);
                    else if (obj is IItem && color.Equals(Color.White))
                        ((IItem)obj).Draw(spriteBatch);
                    else if (obj is IBlock)
                        ((IBlock)obj).Draw(spriteBatch, color);
                    else if (obj is IDoor)
                        ((IDoor)obj).Draw(spriteBatch, color);
                    else if (obj is TriggerSquare)
                        ((TriggerSquare)obj).Draw(spriteBatch);

                }

                game1.link.Draw(spriteBatch, Color.White);
            }
        }
    }
}