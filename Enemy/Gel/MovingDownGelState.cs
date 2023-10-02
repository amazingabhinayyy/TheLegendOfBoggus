using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Gel
{
    internal class MovingDownGelState : IEnemyState
    {
        private Gel gel;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        public MovingDownGelState(Gel gel)
        {
            this.gel = gel;
            sprite = EnemySpriteFactory.Instance.CreateGelSprite();
            sourceRectangle = Globals.GelSprite1;
            currentFrame = 0;
        }
        public void ChangeDirection()
        {
            gel.State = new MovingLeftGelState(gel);
        }
        public void ChangeAttackedStatus() {
            gel.State = new DeathAnimationState(gel);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame < 30)
            {
                if (currentFrame < 15)
                {
                    sourceRectangle = Globals.GelSprite1;

                }
                else
                {
                    sourceRectangle = Globals.GelSprite2;

                }
                gel.Y += 1;
            }
            else
            {
                currentFrame = 0;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, gel.X, gel.Y, sourceRectangle);
        }
    }
}
