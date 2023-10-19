using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Items
{
    public abstract class ItemSecondary : IItem
    {
        protected IItemSprite sprite;
        protected Rectangle Position;
        protected Rectangle sourceRectangle;
        protected int count;
        public bool spawned { get; set; }
        public bool exists { get; set; }
        public Rectangle position { get { return Position; } }

        public ItemSecondary() {
            count = 25;
        }
        public void Spawn() {
            sprite = ItemSpriteFactory.Instance.CreateSpawnItemSprite();
            exists = true;
        }
        public void Spawn(Rectangle position)
        {
            Position.X = position.X;
            Position.Y = position.Y;
            sprite = ItemSpriteFactory.Instance.CreateSpawnItemSprite();
            exists = true;
        }
        public void Collect() { 
            exists = false;
        }
        public virtual void Update() {
            if (count == 0)
            {
                sprite = ItemSpriteFactory.Instance.CreateSpawnItemSprite();
                spawned = true;
            }
        }
        public void Draw(SpriteBatch spriteBatch) {
            if (exists)
            {
                sprite.Draw(spriteBatch, Position, sourceRectangle);
                if(!spawned){
                    count--;
                }
            }
        }
        public Rectangle GetHitBox()
        {
            return Position;
        }

    }
}
