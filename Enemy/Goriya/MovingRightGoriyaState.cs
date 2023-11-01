﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile.GoriyaProjectiles;
using System;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class MovingRightGoriyaState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private int elaspedFrameCount;
        private int endFrame;
        private Random random;
        private int direction;
        private int distance;
        public MovingRightGoriyaState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            sprite = EnemySpriteFactory.Instance.CreateMovingRightGoriyaSprite();
            sourceRectangle = Globals.GoriyaRedRight;
            Goriya.Position = new Rectangle(Goriya.X, Goriya.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            currentFrame = 0;
            random = new Random();
            distance = random.Next(50, 100);

        }
        public void ChangeDirection()
        {
            direction = random.Next(0, 6);
            switch (direction)
            {
                case 0:
                    Goriya.State = new MovingLeftGoriyaState(Goriya);
                    break;
                case 1:
                    Goriya.State = new MovingUpGoriyaState(Goriya);
                    break;
                case 2:
                    Goriya.State = new MovingDownGoriyaState(Goriya);
                    break;
                case 3:
                    Goriya.BoomerangPosition = new Vector2(Goriya.X, Goriya.Y);
                    Goriya.Boomerang = new GoriyaBoomerang(Goriya.BoomerangPosition);
                    ((GoriyaBoomerang)Goriya.Boomerang).GenerateLeft();
                    ((GoriyaBoomerang)Goriya.Boomerang).Throwing = true;
                    CollisionDetector.GameObjectList.Add(Goriya.Boomerang);
                    Goriya.State = new AttackWithBoomerangLeftState(Goriya);
                    break;
                case 4:
                    Goriya.BoomerangPosition = new Vector2(Goriya.X, Goriya.Y);
                    Goriya.Boomerang = new GoriyaBoomerang(Goriya.BoomerangPosition);
                    ((GoriyaBoomerang)Goriya.Boomerang).GenerateUp();
                    ((GoriyaBoomerang)Goriya.Boomerang).Throwing = true;
                    CollisionDetector.GameObjectList.Add(Goriya.Boomerang);
                    Goriya.State = new AttackWithBoomerangUpState(Goriya);
                    break;
                case 5:
                    Goriya.BoomerangPosition = new Vector2(Goriya.X, Goriya.Y);
                    Goriya.Boomerang = new GoriyaBoomerang(Goriya.BoomerangPosition);
                    ((GoriyaBoomerang)Goriya.Boomerang).GenerateRight();
                    ((GoriyaBoomerang)Goriya.Boomerang).Throwing = true;
                    CollisionDetector.GameObjectList.Add(Goriya.Boomerang);
                    Goriya.State = new AttackWithBoomerangRightState(Goriya);
                    break;
                case 6:
                    Goriya.BoomerangPosition = new Vector2(Goriya.X, Goriya.Y);
                    Goriya.Boomerang = new GoriyaBoomerang(Goriya.BoomerangPosition);
                    ((GoriyaBoomerang)Goriya.Boomerang).GenerateDown();
                    ((GoriyaBoomerang)Goriya.Boomerang).Throwing = true;
                    CollisionDetector.GameObjectList.Add(Goriya.Boomerang);
                    Goriya.State = new AttackWithBoomerangDownState(Goriya);
                    break;
            }
        }
        public void ChangeAttackedStatus() {
            Goriya.State = new MovingAttackedRightGoriyaState(Goriya);
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
                Goriya.X += 1;
                Goriya.Position = new Rectangle(Goriya.X, Goriya.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            }
            else
            {
                currentFrame = 0;
            }
            
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Goriya.X, Goriya.Y, sourceRectangle);
        }
    }
}
