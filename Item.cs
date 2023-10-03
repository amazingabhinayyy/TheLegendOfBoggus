using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.ItemStates;

namespace Sprint2_Attempt3
{
    public class Item : IItem
    {
        public Vector2 position;
        public IJustItemSprite ItemSprite { get; set; }
        public IJustItemState ItemState { get; set; }

        public Item()
        {
            StartItemState();
        }
        public void ChangeToRupee()
        {
        ItemState.ChangeToRupee();
        }
        public void ChangeToBomb()
        {
        ItemState.ChangeToBomb();
        }
        public void ChangeToClock()
        {
            ItemState.ChangeToClock();
        }
        public void ChangeToCompass()
        {
            ItemState.ChangeToCompass();
        }
        public void ChangeToHeart()
        {
            ItemState.ChangeToHeart();
        }
        public void ChangeToBoomerang()
        {
            ItemState.ChangeToBoomerang();
        }
        public void ChangeToFairy()
        {
            ItemState.ChangeToFairy();
        }
        public void ChangeToMap()
        {
            ItemState.ChangeToMap();
        }
        public void ChangeToKey()
        {
            ItemState.ChangeToKey();
        }
        public void ChangeToHeartContainer()
        {
            ItemState.ChangeToHeartContainer();
        }
        public void ChangeToTriforcePiece()
        {
            ItemState.ChangeToTriforcePiece();
        }
        public void ChangeToBow()
        {
            ItemState.ChangeToBow();
        }
        public void ChangeToArrow()
        {
            ItemState.ChangeToArrow();
        }
        public void ChangeToBlueCandle()
        {
            ItemState.ChangeToBlueCandle();
        }
        public void ChangeToBluePotion()
        {
            ItemState.ChangeToBluePotion();
        }
        public void StartItemState()
        {
            ItemState = new RupeeItemState(this);
        }
        public void Update()
        {
            ItemState.Update();
            ItemSprite.Update();

        }

        public void Draw(SpriteBatch _spriteBatch)
        {
            ItemSprite.Draw(_spriteBatch);

        }

    }
}