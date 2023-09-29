using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.SpikeTrap
{
    internal class MovingRightSpikeTrapState : IEnemyState
    {
        private SpikeTrap spikeTrap;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        public MovingRightSpikeTrapState(SpikeTrap spikeTrap)
        {
            this.spikeTrap = spikeTrap;
            sprite = EnemySpriteFactory.Instance.CreateSpkieTrapSprite();
            sourceRectangle = Globals.SpikeTrapSprite;
        }
        public void ChangeDirection()
        {
            spikeTrap.State = new MovingDownSpikeTrapState(spikeTrap);
        }
        public void ChangeAttackedStatus()
        {

        }
        public void Update()
        {
            spikeTrap.X += 1;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, spikeTrap.X, spikeTrap.Y, sourceRectangle);
        }
    }
}
