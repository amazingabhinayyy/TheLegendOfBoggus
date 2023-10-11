﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Projectile.AquamentusProjectiles;

namespace Sprint2_Attempt3.Enemy.Aquamentus
{
    internal class MovingRightAquamentusState : IEnemyState
    {
        private Aquamentus Aquamentus;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private int elaspedFrameCount;
        private int endFrame;
        public MovingRightAquamentusState(Aquamentus Aquamentus)
        {
            this.Aquamentus = Aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateMovingRightAquamentusSprite();
            sourceRectangle = Globals.AquamentusGreenLeft;
            currentFrame = 0; 
            this.Aquamentus.Direction = Aquamentus.ProjectileDirection.Right;
            elaspedFrameCount = 0;
            endFrame = 100;

        }
        public void ChangeDirection()
        {
            Aquamentus.FireballPosition = new Vector2(Aquamentus.X, Aquamentus.Y);
            Aquamentus.Fireball = new AquamentusFireball(Aquamentus.FireballPosition);
            ((AquamentusFireball)Aquamentus.Fireball).GenerateRight();
            Aquamentus.State = new AttackWithFireballRightState(Aquamentus);
        }
        public void ChangeAttackedStatus() {
            Aquamentus.State = new MovingAttackedRightAquamentusState(Aquamentus);
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
                Aquamentus.X += 1;
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