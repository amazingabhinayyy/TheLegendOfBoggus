using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.Zol
{
    internal class MovingDownZolState : IEnemyState
    {
        private Zol zol;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private Random random;
        private int direction;
        public MovingDownZolState(Zol zol)
        {
            this.zol = zol;
            sprite = EnemySpriteFactory.Instance.CreateZolSprite();
            sourceRectangle = Globals.ZolSprite1;
            zol.Position = new Rectangle(zol.X, zol.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
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
                    zol.State = new MovingLeftZolState(zol);
                    break;
                case 1:
                    zol.State = new MovingUpZolState(zol);
                    break;
                case 2:
                    zol.State = new MovingRightZolState(zol);
                    break;
            }
        }
        public void ChangeAttackedStatus() {
            zol.State = new DeathAnimationState(zol);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame < 30)
            {
                if (currentFrame < 15)
                {
                    sourceRectangle = Globals.ZolSprite1;

                }
                else
                {
                    sourceRectangle = Globals.ZolSprite2;

                }
                zol.Y += 1;
                zol.Position = new Rectangle(zol.X, zol.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            }
            else
            {
                currentFrame = 0;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, zol.X, zol.Y, sourceRectangle);
        }
    }
}
