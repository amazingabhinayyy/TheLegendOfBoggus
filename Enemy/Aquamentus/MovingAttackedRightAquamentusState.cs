using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles;
using System;

namespace Sprint2_Attempt3.Enemy.Aquamentus
{
    internal class MovingAttackedRightAquamentusState : IEnemyState
    {
        private Aquamentus Aquamentus;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private int elaspedFrameCount;
        private int endFrame;
        public MovingAttackedRightAquamentusState(Aquamentus Aquamentus)
        {
            this.Aquamentus = Aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateMovingRightAquamentusSprite();
            sourceRectangle = Globals.AquamentusOrangeLeft1;
            currentFrame = 0;
            this.Aquamentus.Direction = Aquamentus.ProjectileDirection.Right;
            Aquamentus.Position = new Rectangle(Aquamentus.X, Aquamentus.Y, sourceRectangle.Width, sourceRectangle.Height);
            elaspedFrameCount = 0;
            endFrame = 100;

        }
        public void ChangeDirection()
        {
            Aquamentus.FireballPosition = new Vector2(Aquamentus.X, Aquamentus.Y);
            Aquamentus.Fireball = new AquamentusFireball(Aquamentus.FireballPosition);
            ((AquamentusFireball)Aquamentus.Fireball).GenerateRight();
            Aquamentus.State = new AttackedAttackWithFireballRightState(Aquamentus);
        }
        public void ChangeAttackedStatus() {
            Aquamentus.State = new MovingRightAquamentusState(Aquamentus);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame <= 20)
            {
                if (currentFrame == 5)
                {
                    sourceRectangle = Globals.AquamentusOrangeLeft1;
                }
                else if (currentFrame == 10)
                {
                    sourceRectangle = Globals.AquamentusBlueLeft;
                }
                else if (currentFrame == 15)
                {
                    sourceRectangle = Globals.AquamentusOrangeLeft2;
                }
                Aquamentus.X += 1;
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
