using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Enemy.Projectile.GanonProjectiles;
using System;

namespace Sprint2_Attempt3.Enemy.Ganon
{
    internal class AttackWithFireballRightState : IEnemyState
    {
        private Ganon Ganon;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private Rectangle[] sourceRectangles;
        private int currentFrame;
        private int direction;
        private int currentFireballFrame;
        private IEnemyProjectile fireball;
        private IEnemyProjectile fireball2;
        private IEnemyProjectile fireball3;
        private int elapsedFrameCount;
        private int endFrame;
        public AttackWithFireballRightState(Ganon Ganon)
        {
            this.Ganon = Ganon;
            sprite = EnemySpriteFactory.Instance.CreateMovingRightGanonSprite();
            currentFrame = 0;
            currentFireballFrame = 0;
            sourceRectangles = new Rectangle[]{ new Rectangle(0, 0, 24, 33), new Rectangle(26, 0, 24, 33) };
            sourceRectangle = sourceRectangles[0];
            Ganon.Position = new Rectangle(Ganon.X, Ganon.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            fireball = Ganon.Fireball;
            fireball2 = Ganon.Fireball2;
            fireball3 = Ganon.Fireball3;
            elapsedFrameCount = 0;
            endFrame = 10;

        }
        public void ChangeDirection()
        {
            Random random = new Random();
            direction = random.Next(0, 3);
            switch (direction)
            {
                case 0:
                    Ganon.State = new MovingLeftGanonState(Ganon);
                    break;
                case 1:
                    Ganon.FireballPosition = new Vector2(Ganon.X, Ganon.Y);
                    //Ganon.Fireball = new GanonFireball(Ganon.FireballPosition);
                    Ganon.Fireball = new GanonFireball(Ganon.FireballPosition);
                    Ganon.Fireball2 = new GanonFireball(Ganon.FireballPosition);
                    Ganon.Fireball3 = new GanonFireball(Ganon.FireballPosition);
                    ((GanonFireball)Ganon.Fireball).GenerateLeft();
                    ((GanonFireball)Ganon.Fireball2).GenerateTopLeft();
                    ((GanonFireball)Ganon.Fireball3).GenerateBottomLeft();
                    CollisionManager.GameObjectList.Add((IGameObject)Ganon.Fireball);
                    CollisionManager.GameObjectList.Add((IGameObject)Ganon.Fireball2);
                    CollisionManager.GameObjectList.Add((IGameObject)Ganon.Fireball3);
                    Ganon.State = new AttackWithFireballLeftState(Ganon);
                    break;
                case 2:
                    Ganon.State = new MovingRightGanonState(Ganon);
                    break;

            }
                            
        }
        public void ChangeAttackedStatus() {
            Ganon.State = new MovingAttackedRightGanonState(Ganon);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame < 30)
            {
                if (currentFrame < 15)
                {
                    sourceRectangle = sourceRectangles[0];

                }
                else
                {
                    sourceRectangle = sourceRectangles[1];

                }
               
            }
            else
            {
                currentFrame = 0;
            }

            elapsedFrameCount++;
            if (elapsedFrameCount >= endFrame * 1.2)
            {
                ChangeDirection();
            }
            if (elapsedFrameCount >= endFrame)
            {
            ((GanonFireball)fireball).Fire = true;
            ((GanonFireball)fireball2).Fire = true;
            ((GanonFireball)fireball3).Fire = true;
                sourceRectangles[0] = new Rectangle(51, 0, 24, 33);
                sourceRectangles[1] = new Rectangle(76, 0, 24, 33);

            }
            Ganon.Position = new Rectangle(Ganon.X, Ganon.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Ganon.X, Ganon.Y, sourceRectangle);
            
        }
    }
}
