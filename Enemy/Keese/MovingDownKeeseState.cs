using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Enemy.Keese
{
    internal class MovingDownKeeseState : IEnemyState
    {
        private Keese keese;
        private IEnemySprite sprite;
        private int currentFrame;
        private Rectangle sourceRectangle;
        public MovingDownKeeseState(Keese keese)
        {
            this.keese = keese;
            this.currentFrame = 0;
            this.sprite = EnemySpriteFactory.Instance.CreateKeeseSprite();
            this.sourceRectangle = Globals.KeeseSprite1;
        }
        public void ChangeDirection()
        {
            keese.State = new MovingLeftKeeseState(keese);
        }
        public void ChangeAttackedStatus() {
            keese.State = new DeathAnimationState(keese);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame < 30)
            {
                if (currentFrame < 15)
                {
                    sourceRectangle = Globals.KeeseSprite1;

                }
                else
                {
                    sourceRectangle = Globals.KeeseSprite2;

                }
                keese.Y += 1;
            }
            else
            {
                currentFrame = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, keese.X, keese.Y, sourceRectangle);
        }
    }
}
