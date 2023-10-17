using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles;
using System;
using System.Threading;

namespace Sprint2_Attempt3.Enemy.Aquamentus
{
    internal class MovingLeftAquamentusState : IEnemyState
    {
        private Aquamentus Aquamentus;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private int elaspedFrameCount;
        private int endFrame;
        public MovingLeftAquamentusState(Aquamentus Aquamentus)
        {
            this.Aquamentus = Aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftAquamentusSprite();
            currentFrame = 0;
            sourceRectangle = Globals.AquamentusGreenLeft;
            Aquamentus.Position = new Rectangle(Aquamentus.X, Aquamentus.Y, sourceRectangle.Width, sourceRectangle.Height);
            //implement
            elaspedFrameCount = 0;
            endFrame = 100;

        }
        public void ChangeDirection()
        {
            Aquamentus.FireballPosition = new Vector2(Aquamentus.X, Aquamentus.Y);
            Aquamentus.Fireball = new AquamentusFireball(Aquamentus.FireballPosition);
            ((AquamentusFireball)Aquamentus.Fireball).GenerateLeft();
            Aquamentus.State = new AttackWithFireballLeftState(Aquamentus);
            
        }
        public void ChangeAttackedStatus() {
            Aquamentus.State = new MovingAttackedLeftAquamentusState(Aquamentus);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame < 30)
            {
                if (currentFrame < 15)
                {
                    sourceRectangle = Globals.AquamentusGreenLeft;

                }
                else
                {
                    sourceRectangle = Globals.AquamentusGreenLeft2;

                }
                Aquamentus.X -= 1;
                Aquamentus.Position = new Rectangle(Aquamentus.X, Aquamentus.Y, sourceRectangle.Width, sourceRectangle.Height);
            }
            else
            {
                currentFrame = 0;
            }
            elaspedFrameCount++;
            if (elaspedFrameCount >= endFrame)
            {
                ChangeDirection();
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Aquamentus.X, Aquamentus.Y, sourceRectangle);
        }
    }
}
