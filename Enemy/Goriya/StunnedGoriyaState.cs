using System;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Projectile.GoriyaProjectiles;
using Sprint2_Attempt3.Enemy.Dodongo;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class StunnedGoriyaState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private int elaspedFrameCount;
        private int endFrame;
        private Random random;
        private int direction;
        private int stunCounter;
        public StunnedGoriyaState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftGoriyaSprite();
            currentFrame = 0;
            sourceRectangle = Globals.GoriyaRedRight;
            Goriya.Position = new Rectangle(Goriya.X, Goriya.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            this.Goriya.Direction = Goriya.ProjectileDirection.Left;
            elaspedFrameCount = 0;
            endFrame = 100;
            stunCounter = 0;
            random = new Random();
            direction = random.Next(0, 3);
        }
        public void ChangeDirection()
        {
            direction = random.Next(0, 3);
            switch (direction)
            {
                case 0:
                    Goriya.State = new MovingDownGoriyaState(Goriya);
                    break;
                case 1:
                    Goriya.State = new MovingUpGoriyaState(Goriya);
                    break;
                case 2:
                    Goriya.State = new MovingLeftGoriyaState(Goriya);
                    break;
                case 3:
                    Goriya.State = new MovingRightGoriyaState(Goriya);
                    break;
            }
        }
        public void ChangeAttackedStatus()
        {
            Goriya.State = new MovingAttackedLeftGoriyaState(Goriya);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame < 30)
            {
                if (currentFrame < 15)
                {
                    sourceRectangle = Globals.GoriyaRedRight;

                }
                else
                {
                    sourceRectangle = Globals.GoriyaRedRight2;

                }
                Goriya.Position = new Rectangle(Goriya.X, Goriya.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            }
            else
            {
                currentFrame = 0;
            }
            stunCounter++;
            if (stunCounter == 200)
            {
                ChangeDirection();
            }
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Goriya.X, Goriya.Y, sourceRectangle);
        }
    }
}
