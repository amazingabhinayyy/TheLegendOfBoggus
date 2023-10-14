﻿namespace Sprint2_Attempt3.Items.ItemStates
{
    internal class RupeeItemState : IJustItemState
    {
        private Game1 game1;
        private Item item;
        public RupeeItemState(Item item)
        {
            this.item = item;
            item.ItemSprite = ItemSpriteFactory.Instance.CreateRupeeItem();
        }
        public void ChangeToRupee()
        {

        }
        public void ChangeToBomb()
        {
            item.ItemState = new BombItemState(item);
        }
        public void ChangeToClock()
        {
            item.ItemState = new ClockItemState(item);
        }
        public void ChangeToCompass()
        {
            item.ItemState = new CompassItemState(item);
        }
        public void ChangeToHeart()
        {
            item.ItemState = new HeartItemState(item);
        }
        public void ChangeToBoomerang()
        {
            item.ItemState = new BoomerangItemState(item);
        }
        public void ChangeToFairy()
        {
            item.ItemState = new FairyItemState(item);
        }
        public void ChangeToMap()
        {
            item.ItemState = new MapItemState(item);
        }
        public void ChangeToKey()
        {
            item.ItemState = new KeyItemState(item);
        }
        public void ChangeToHeartContainer()
        {
            item.ItemState = new HeartContainerItemState(item);
        }
        public void ChangeToTriforcePiece()
        {
            item.ItemState = new TriforcePieceItemState(item);
        }
        public void ChangeToBow()
        {
            item.ItemState = new BowItemState(item);
        }
        public void ChangeToArrow()
        {
            item.ItemState = new ArrowItemState(item);
        }
        public void ChangeToBlueCandle()
        {
            item.ItemState = new BlueCandleItemState(item);
        }
        public void ChangeToBluePotion()
        {
            item.ItemState = new BluePotionItemState(item);
        }
        public void Update()
        {
        }
    }
}