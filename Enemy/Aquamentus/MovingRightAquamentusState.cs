using Microsoft.Xna.Framework;
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
        public MovingRightAquamentusState(Aquamentus Aquamentus)
        {
            this.Aquamentus = Aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateMovingRightAquamentusSprite();
            sourceRectangle = Globals.AquamentusRedRight;
            currentFrame = 0;

        }
        public void ChangeDirection()
        {
            Aquamentus.BoomerangPosition = new Vector2(Aquamentus.X, Aquamentus.Y);
            Aquamentus.Boomerang = new AquamentusBoomerang(Aquamentus.BoomerangPosition);
            ((AquamentusBoomerang)Aquamentus.Boomerang).GenerateRight();
            Aquamentus.State = new AttackWithBoomerangRightState(Aquamentus);
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
                    sourceRectangle = Globals.AquamentusRedRight;

                }
                else
                {
                    sourceRectangle = Globals.AquamentusRedRight2;

                }
                Aquamentus.X += 1;
            }
            else
            {
                currentFrame = 0;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Aquamentus.X, Aquamentus.Y, sourceRectangle);
        }
    }
}
