using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemSprites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Inventory
{
    internal class PlayerTrackerController
    {
        private static int x = InventoryController.destRectangle.X;
        private static int y = InventoryController.destRectangle.Y;
        private static IItemSprite sprite = ItemSpriteFactory.Instance.CreatePlayerMarkerSprite();

        private static Rectangle[] MarkerDestRectangles = new Rectangle[]
        {
            new Rectangle(x + 132, y + 670, 9, 9),
            new Rectangle(x + 106, y + 670, 9, 9),
            new Rectangle(x + 158, y + 670, 9, 9),
            new Rectangle(x + 132, y + 657, 9, 9),
            new Rectangle(x + 106, y + 644, 9, 9),
            new Rectangle(x + 132, y + 644, 9, 9),
            new Rectangle(x + 158, y + 644, 9, 9),
            new Rectangle(x + 80, y + 631, 9, 9),
            new Rectangle(x + 106, y + 631, 9, 9),
            new Rectangle(x + 132, y + 631, 9, 9),
            new Rectangle(x + 158, y + 631, 9, 9),
            new Rectangle(x + 184, y + 631, 9, 9),
            new Rectangle(x + 132, y + 618, 9, 9),
            new Rectangle(x + 184, y + 618, 9, 9),
            new Rectangle(x + 210, y + 618, 9, 9),
            new Rectangle(x + 106, y + 605, 9, 9),
            new Rectangle(x + 106, y + 605, 9, 9),
            new Rectangle(x + 132, y + 605, 9, 9)
        };
        public PlayerTrackerController() { }

        public static void DrawPlayerTracker(SpriteBatch spriteBatch) {
            sprite.Draw(spriteBatch, MarkerDestRectangles[RoomSecondary.currentRoomNumber]);
        }
        public static void ShiftUp() {
            for (int i = 0; i < MarkerDestRectangles.Length; i++) {
                MarkerDestRectangles[i].Y -= InventoryController.AnimateRate;
            }
        }
        public static void ShiftDown() {
            for (int i = 0; i < MarkerDestRectangles.Length; i++)
            {
                MarkerDestRectangles[i].Y += InventoryController.AnimateRate;
            }
        }
    }
}
