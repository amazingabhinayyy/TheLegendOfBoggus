using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Items
{
    public abstract class ItemSecondary : IItem
    {
        protected IItemSprite sprite;
        protected Rectangle Position;
        protected Rectangle sourceRectangle;
        protected int count;
        protected bool spawned;
        protected bool exists;
        public Rectangle position { get { return Position; } }

        public ItemSecondary() {
            count = 25;
        }
        public void Spawn() {
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
