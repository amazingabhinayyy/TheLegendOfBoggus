using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Zol
{
    internal class MovingLeftZolState : IEnemyState
    {
        private Zol zol;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        public MovingLeftZolState(Zol zol)
        {
            this.zol = zol;
            sprite = EnemySpriteFactory.Instance.CreateZolSprite();
            sourceRectangle = Globals.ZolSprite1;
            currentFrame = 0;
        }
        public void ChangeDirection()
        {
            zol.State = new MovingUpZolState(zol);
        }
        public void ChangeAttackedStatus()
        {
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
                zol.X -= 1;
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
