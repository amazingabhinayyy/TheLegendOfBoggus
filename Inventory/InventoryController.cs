using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.CommandClasses;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemSprites;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Inventory
{
    public class InventoryController
    {
        public static Rectangle destRectangle { get; private set; } = new Rectangle(0, -525, 800, 700);
        private static IItemSprite menuSprite = ItemSpriteFactory.Instance.CreateInventoryMenuSprite();
        private static int ItemAIndex = 1;
        private static int ItemBIndex = 4;
        private static int ItemSelectedIndex = 0;
        private static int count = 0;

        public static float hearts { get; set; } = 3.5f;
        public static int heartContainers { get; set; } = 5;
        public static int RupeeCount { get; set; } = 99;
        public static int KeyCount { get; set; } = 99;
        public static bool HasBow { get; set; } = true;

        private Texture2D texture;
        public static bool FullView { get; private set; } = false;
        public static bool UsingFairy { get; set; } = false;
        private static Dictionary<String, InventoryItem> LinkItems { get; set; }

        private static IItemSprite[] TriforceMarkers = new IItemSprite[] { ItemSpriteFactory.Instance.CreateGreenTriforceMarkerSprite(), ItemSpriteFactory.Instance.CreateRedTriforceMarkerSprite() };

        private static String[] ItemMenuStrings = { "Boomerang", "Bomb", "Arrow", "BlueCandle", "SwordProjectile", "Clock", "BluePotion", "Fairy" };

        private static Rectangle ItemBDestRectangle = new Rectangle(destRectangle.X + 401, destRectangle.Y + 606, 26, 49);
        private static Rectangle ItemADestRectangle = new Rectangle(destRectangle.X + 477, destRectangle.Y + 606, 26, 49);
        private static Rectangle ItemSelectedDestRectangle = new Rectangle(destRectangle.X + 212, destRectangle.Y + 145, 26, 49);
        private static Rectangle DungeonMapDestRectangle = new Rectangle(destRectangle.X + 50, destRectangle.Y + 582, 201, 97);
        private static Rectangle CursorDestRectangle = new Rectangle(destRectangle.X + 402, destRectangle.Y + 145, 49, 49);
        private static Rectangle TriforceDestRectangle = new Rectangle(destRectangle.X + 210, destRectangle.Y + 618, 9, 9);

        private static Rectangle blackSrcRectangle = new Rectangle(315,170, 10,10);

        private static Rectangle BoomerangDestRectangle = new Rectangle(destRectangle.X + 415, destRectangle.Y + 145, 26, 49);
        private static Rectangle BombDestRectangle = new Rectangle(destRectangle.X + 489, destRectangle.Y + 145, 26, 49);
        private static Rectangle ArrowDestRectangle = new Rectangle(destRectangle.X + 563, destRectangle.Y + 145, 26, 49);
        private static Rectangle BlueCandleDestRectangle = new Rectangle(destRectangle.X + 638, destRectangle.Y + 145, 29, 49);

        private static Rectangle ClockDestRectangle = new Rectangle(destRectangle.X + 488, destRectangle.Y + 196, 28, 49);
        private static Rectangle BluePotionDestRectangle = new Rectangle(destRectangle.X + 563, destRectangle.Y + 196, 27, 49);
        private static Rectangle FairyDestRectangle = new Rectangle(destRectangle.X + 639, destRectangle.Y + 196, 26, 49);
        
        private static Rectangle MapDestRectangle = new Rectangle(destRectangle.X + 150, destRectangle.Y + 339, 26, 49);
        private static Rectangle CompassDestRectangle = new Rectangle(destRectangle.X + 138, destRectangle.Y + 460, 47, 49);
        public InventoryController(Game1 game1) {
            LinkItems = new Dictionary<string, InventoryItem>() {
                { "Arrow", new InventoryItem(ArrowDestRectangle, ItemSpriteFactory.Instance.CreateArrowSprite(), new SetUseArrowCommand(game1)) },
                { "BlueCandle", new InventoryItem(BlueCandleDestRectangle, ItemSpriteFactory.Instance.CreateBlueCandleSprite(), new SetUseFireCommand(game1)) },
                { "BluePotion", new InventoryItem(BluePotionDestRectangle, ItemSpriteFactory.Instance.CreateBluePotionSprite(), new UseBluePotion()) },
                { "Bomb", new InventoryItem(BombDestRectangle, ItemSpriteFactory.Instance.CreateBombSprite(), new SetUseBombCommand(game1), 99) },
                { "Boomerang", new InventoryItem(BoomerangDestRectangle, ItemSpriteFactory.Instance.CreateBoomerangSprite(), new SetUseBoomerangCommand(game1)) },
                { "Clock", new InventoryItem(ClockDestRectangle, ItemSpriteFactory.Instance.CreateClockSprite(), new UseClock()) },
                { "Fairy", new InventoryItem(FairyDestRectangle, ItemSpriteFactory.Instance.CreateFairySprite(), new UseFairy()) },
                { "Compass", new InventoryItem(CompassDestRectangle, ItemSpriteFactory.Instance.CreateCompassSprite(), 0) },
                { "Map", new InventoryItem(MapDestRectangle, ItemSpriteFactory.Instance.CreateMapSprite(), 0) },
                { "MapLayout", new InventoryItem(DungeonMapDestRectangle, ItemSpriteFactory.Instance.CreateMapLayoutSprite(), 0) },
                { "TriforceMarker", new InventoryItem(TriforceDestRectangle, TriforceMarkers[0], 0) },
                { "ItemA", new InventoryItem(ItemADestRectangle, ItemSpriteFactory.Instance.CreateBombSprite(), 1) },
                { "ItemB", new InventoryItem(ItemBDestRectangle, ItemSpriteFactory.Instance.CreateBoomerangSprite(), 1) },
                { "ItemSelected", new InventoryItem(ItemSelectedDestRectangle, ItemSpriteFactory.Instance.CreateBoomerangSprite(), 1) },
                { "Cursor", new InventoryItem(CursorDestRectangle, ItemSpriteFactory.Instance.CreateMenuCursorSprite(), 1) }
            };
        }

        public static void IncrementCount(String item)
        {
            LinkItems[item].IncrementCount();
        }
        public static void IncrementCount(String item, float i)
        {
            LinkItems[item].IncrementCount(i);
        }
        public static void DecrementCount(String item)
        {
            LinkItems[item].DecrementCount();
        }
        public static void DecrementCount(String item, float i)
        {
            LinkItems[item].DecrementCount(i);
        }
        public static float GetCount(String item)
        {
            return LinkItems[item].Count();
        }
        public static void UseItem(String item)
        {
            LinkItems[item].UseItem();
        }
        public static void ShiftCursorRight() {
            if (LinkItems["Cursor"].destRectangle.X < 627)
            {
                CursorDestRectangle.X += 75;
                LinkItems["Cursor"].SetDestRectangle(CursorDestRectangle);
                ItemSelectedIndex++;
                LinkItems["ItemSelected"].SetSprite(LinkItems[ItemMenuStrings[ItemSelectedIndex]].GetSprite());
            }
        }
        public static void ShiftCursorLeft()
        {
            if (LinkItems["Cursor"].destRectangle.X > 402)
            {
                CursorDestRectangle.X -= 75;
                LinkItems["Cursor"].SetDestRectangle(CursorDestRectangle);
                ItemSelectedIndex--;
                LinkItems["ItemSelected"].SetSprite(LinkItems[ItemMenuStrings[ItemSelectedIndex]].GetSprite());
            }
        }
        public static void ShiftCursorUp()
        {
            if (LinkItems["Cursor"].destRectangle.Y > 145)
            {
                CursorDestRectangle.Y -= 50;
                LinkItems["Cursor"].SetDestRectangle(CursorDestRectangle);
                ItemSelectedIndex -= 4;
                LinkItems["ItemSelected"].SetSprite(LinkItems[ItemMenuStrings[ItemSelectedIndex]].GetSprite());
            }
        }
        public static void ShiftCursorDown()
        {
            if (LinkItems["Cursor"].destRectangle.Y < 195)
            {
                CursorDestRectangle.Y += 50;
                LinkItems["Cursor"].SetDestRectangle(CursorDestRectangle);
                ItemSelectedIndex += 4;
                LinkItems["ItemSelected"].SetSprite(LinkItems[ItemMenuStrings[ItemSelectedIndex]].GetSprite());
            }
        }

        public static void SetItemA() {
            if (ItemSelectedIndex != ItemBIndex)
            {
                ItemAIndex = ItemSelectedIndex;
                LinkItems["ItemA"].SetSprite(LinkItems[ItemMenuStrings[ItemAIndex]].GetSprite());
            }
            UsingFairy = false;
        }
        public static void SetItemB()
        {
            if (ItemSelectedIndex != ItemAIndex)
            {
                ItemBIndex = ItemSelectedIndex;
                LinkItems["ItemB"].SetSprite(LinkItems[ItemMenuStrings[ItemBIndex]].GetSprite());
            }
            UsingFairy = false;
        }

        public static void UseAItem()
        {
            LinkItems[ItemMenuStrings[ItemAIndex]].UseItem();
        }
        public static void UseBItem()
        {
            LinkItems[ItemMenuStrings[ItemBIndex]].UseItem();
        }

        public static void ShiftUp() {
            if (destRectangle.Y > -525)
            {
                //destRectangle.Y--;
                foreach (KeyValuePair<String, InventoryItem> item in LinkItems)
                {
                    item.Value.ShiftUp();
                }

                CursorDestRectangle.Y--;
            }
            else {
                FullView = false;
            }
        }

        public static void ShiftDown()
        {
            if (destRectangle.Y < 12)
            {
                //destRectangle.Y++;
                foreach (KeyValuePair<String, InventoryItem> item in LinkItems)
                {
                    item.Value.ShiftDown();
                }

                CursorDestRectangle.Y--;
            }
            else {
                FullView = true;
            }
        }
        public void Update() {
            count++;
            LinkItems["TriforceMarker"].SetSprite(TriforceMarkers[Globals.FindIndex(count % (TriforceMarkers.Length * 5), 5, TriforceMarkers.Length)]);
        }

        public void Draw(SpriteBatch spriteBatch) {
            menuSprite.Draw(spriteBatch, destRectangle);

            HealthController.DrawHearts(spriteBatch);
            MapController.DrawMap(spriteBatch);
            ItemCountController.DrawCounts(spriteBatch);

            foreach (KeyValuePair<String, InventoryItem> pair in LinkItems)
            {
                pair.Value.Draw(spriteBatch);
            }

            PlayerTrackerController.DrawPlayerTracker(spriteBatch);
        }
    }
}
