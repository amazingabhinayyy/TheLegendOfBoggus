using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile.GoriyaProjectiles;
using System;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class MovingAttackedLeftGoriyaState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private int elaspedFrameCount;
        private int endFrame;
        private Random random;
        private int direction;
        private int colorTimer;
        public MovingAttackedLeftGoriyaState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftGoriyaSprite();
            currentFrame = 0;
            sourceRectangle = Globals.GoriyaRedRight;
            Goriya.Position = new Rectangle(Goriya.X, Goriya.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            elaspedFrameCount = 0;
            endFrame = 100;
            colorTimer = 0;
        }
        public void ChangeDirection()
        {
            Goriya.BoomerangPosition = new Vector2(Goriya.X, Goriya.Y);
            Goriya.Boomerang = new GoriyaBoomerang(Goriya.BoomerangPosition);
            ((GoriyaBoomerang)Goriya.Boomerang).GenerateLeft();
            CollisionDetector.GameObjectList.Add(Goriya.Boomerang);
            ((GoriyaBoomerang)Goriya.Boomerang).Throwing = true;
            Goriya.State = new DamagedAttackWithBoomerangLeftState(Goriya);
        }
        public void ChangeAttackedStatus() {
            if(colorTimer >= 60)
                Goriya.State = new MovingLeftGoriyaState(Goriya);
        }
        public void Update()
        {
            
            currentFrame++;
            if (currentFrame <= 20)
            {
                if (currentFrame == 5)
                {
                    sourceRectangle = Globals.GoriyaGreenRight2;
                }
                else if (currentFrame == 10)
                {
                    sourceRectangle = Globals.GoriyaTealRight;
                }
                else if (currentFrame == 15)
                {
                    sourceRectangle = Globals.GoriyaRedRight2;
                }
                else if (currentFrame == 20)
                {
                    sourceRectangle = Globals.GoriyaBlueRight;
                }
                Goriya.X -= 1;
                Goriya.Position = new Rectangle(Goriya.X, Goriya.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            }
            else
            {
                currentFrame = 0;
            }
            colorTimer++;
            ChangeAttackedStatus();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Goriya.X, Goriya.Y, sourceRectangle);
        }
    }
}
