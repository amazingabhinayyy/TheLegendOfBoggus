using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;

namespace Sprint2_Attempt3.CommandClasses
{
    internal class UseBluePotion : ICommand
    {
        public UseBluePotion()
        {
        }

        public void Execute()
        {
            if (InventoryController.GetCount("BluePotion") > 0) {
                float difference = InventoryController.GetCount("HeartContainer") - InventoryController.GetCount("Heart");
                InventoryController.IncrementCount("Heart", difference);
                InventoryController.DecrementCount("BluePotion", difference);
            }
        }
    }
}
