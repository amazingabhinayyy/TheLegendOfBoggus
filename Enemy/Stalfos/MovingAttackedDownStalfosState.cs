using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.SpikeTrap;
using System;

namespace Sprint2_Attempt3.Enemy.Stalfos
{
    internal class MovingAttackedDownStalfosState : IEnemyState
    {
        private Stalfos Stalfos;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private Random random;
        private int direction;
        public MovingAttackedDownStalfosState(Stalfos Stalfos)
        {
            this.Stalfos = Stalfos;
            sprite = EnemySpriteFactory.Instance.CreateStalfosSprite();
            sourceRectangle = Globals.StalfosRed;
            Stalfos.Position = new Rectangle(Stalfos.X, Stalfos.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            currentFrame = 0;
            random = new Random();
            direction = random.Next(0, 2);
        }
        public void ChangeDirection()
        {
            direction = random.Next(0, 2);
            switch (direction)
            {
                case 0:
                    Stalfos.State = new MovingAttackedLeftStalfosState(Stalfos);
                    break;
                case 1:
                    Stalfos.State = new MovingAttackedUpStalfosState(Stalfos);
                    break;
                case 2:
                    Stalfos.State = new MovingAttackedRightStalfosState(Stalfos);
                    break;
            }
        }
        public void ChangeAttackedStatus() {
            Stalfos.State = new MovingDownStalfosState(Stalfos);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame <= 20)
            {
                if (currentFrame == 5)
                {
                    sourceRectangle = Globals.StalfosGreen;
                }
                else if (currentFrame == 10)
                {
                    sourceRectangle = Globals.StalfosTeal;
                }
                else if (currentFrame == 15)
                {
                    sourceRectangle = Globals.StalfosRed;
                }
                else if (currentFrame == 20)
                {
                    sourceRectangle = Globals.StalfosBlue;
                }
            }
            else
            {
                currentFrame = 0;
            }
            Stalfos.Y += 1;
            Stalfos.Position = new Rectangle(Stalfos.X, Stalfos.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Stalfos.X, Stalfos.Y, sourceRectangle) ;
        }
    }
}
