using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.CommandClasses;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemSprites;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
        private static IItemSprite mapLayoutSprite = ItemSpriteFactory.Instance.CreateMapLayoutSprite();
        private static int count = 0;
        public static float hearts { get; set; }
        public static int heartContainers { get; set; }
        public static int RupeeCount { get; set; }
        public static int KeyCount { get; set; }
        public static int BombCount { get; set; }
        public static bool HasBow { get; set; }
        public static bool FullView { get; private set; } = false;
        public static bool UsingFairy { get; set; } = false;
        private static Dictionary<String, InventoryItem> LinkItems { get; set; }

        private static Dictionary<char, Rectangle> numberSrcRectangles = new Dictionary<char, Rectangle>(); 

        private static Rectangle[] MarkerDestRectangles = new Rectangle[]
        {
            new Rectangle(destRectangle.X + 132, destRectangle.Y + 670, 9, 9),
            new Rectangle(destRectangle.X + 106, destRectangle.Y + 670, 9, 9),
            new Rectangle(destRectangle.X + 158, destRectangle.Y + 670, 9, 9),
            new Rectangle(destRectangle.X + 132, destRectangle.Y + 657, 9, 9),
            new Rectangle(destRectangle.X + 106, destRectangle.Y + 644, 9, 9),
            new Rectangle(destRectangle.X + 132, destRectangle.Y + 644, 9, 9),
            new Rectangle(destRectangle.X + 158, destRectangle.Y + 644, 9, 9),
            new Rectangle(destRectangle.X + 80, destRectangle.Y + 631, 9, 9),
            new Rectangle(destRectangle.X + 106, destRectangle.Y + 631, 9, 9),
            new Rectangle(destRectangle.X + 132, destRectangle.Y + 631, 9, 9),
            new Rectangle(destRectangle.X + 158, destRectangle.Y + 631, 9, 9),
            new Rectangle(destRectangle.X + 184, destRectangle.Y + 631, 9, 9),
            new Rectangle(destRectangle.X + 132, destRectangle.Y + 618, 9, 9),
            new Rectangle(destRectangle.X + 184, destRectangle.Y + 618, 9, 9),
            new Rectangle(destRectangle.X + 210, destRectangle.Y + 618, 9, 9),
            new Rectangle(destRectangle.X + 106, destRectangle.Y + 605, 9, 9),
            new Rectangle(destRectangle.X + 106, destRectangle.Y + 605, 9, 9),
            new Rectangle(destRectangle.X + 132, destRectangle.Y + 605, 9, 9),
            new Rectangle(destRectangle.X + 106, destRectangle.Y + 657, 9, 9)
        };

        private static Dictionary<int, Rectangle> MapRoomDestRectangles = new Dictionary<int, Rectangle>() {
            { 0, new Rectangle(destRectangle.X + 477, destRectangle.Y + 435, 25, 24) },
            { 1, new Rectangle(destRectangle.X + 452, destRectangle.Y + 435, 25, 24) },
            { 2, new Rectangle(destRectangle.X + 502, destRectangle.Y + 435, 25, 24) },
            { 3, new Rectangle(destRectangle.X + 477, destRectangle.Y + 412, 25, 24) },
            { 4, new Rectangle(destRectangle.X + 452, destRectangle.Y + 389, 25, 24) },
            { 5, new Rectangle(destRectangle.X + 477, destRectangle.Y + 389, 25, 24) },
            { 6, new Rectangle(destRectangle.X + 502, destRectangle.Y + 389, 25, 24) },
            { 7, new Rectangle(destRectangle.X + 428, destRectangle.Y + 365, 25, 24) },
            { 8, new Rectangle(destRectangle.X + 452, destRectangle.Y + 365, 25, 24) },
            { 9, new Rectangle(destRectangle.X + 477, destRectangle.Y + 365, 25, 24) },
            { 10, new Rectangle(destRectangle.X + 502, destRectangle.Y + 365, 25, 24) },
            { 11, new Rectangle(destRectangle.X + 527, destRectangle.Y + 365, 25, 24) },
            { 12, new Rectangle(destRectangle.X + 477, destRectangle.Y + 341, 25, 24) },
            { 13, new Rectangle(destRectangle.X + 527, destRectangle.Y + 341, 25, 24) },
            { 14, new Rectangle(destRectangle.X + 552, destRectangle.Y + 341, 25, 24) },
            { 15, new Rectangle(destRectangle.X + 452, destRectangle.Y + 317, 25, 24) },
            { 16, new Rectangle(destRectangle.X + 452, destRectangle.Y + 317, 25, 24) },
            { 17, new Rectangle(destRectangle.X + 477, destRectangle.Y + 317, 25, 24) },
            {18, new Rectangle(destRectangle.X + 452, destRectangle.Y + 412, 25, 24) }
        };

        private static Rectangle[] TriforceMarkers = new Rectangle[] { new Rectangle(262, 140, 3, 3), new Rectangle(270, 140, 3, 3) };

        private static String[] ItemMenuStrings = { "Boomerang", "Bomb", "Arrow", "BlueCandle", "SwordProjectile", "Clock", "BluePotion", "Fairy" };

        private static Rectangle ItemBDestRectangle = new Rectangle(destRectangle.X + 401, destRectangle.Y + 606, 26, 49);
        private static Rectangle ItemADestRectangle = new Rectangle(destRectangle.X + 477, destRectangle.Y + 606, 26, 49);
        private static Rectangle ItemSelectedDestRectangle = new Rectangle(destRectangle.X + 212, destRectangle.Y + 145, 26, 49);
        private static IItemSprite[] TriforceMarkers = new IItemSprite[] { ItemSpriteFactory.Instance.CreateGreenTriforceMarkerSprite(), ItemSpriteFactory.Instance.CreateRedTriforceMarkerSprite() };
        private static IItemSprite triforceSprite = TriforceMarkers[0];
        private static Rectangle DungeonMapDestRectangle = new Rectangle(destRectangle.X + 50, destRectangle.Y + 582, 201, 97);
        private static Rectangle TriforceDestRectangle = new Rectangle(destRectangle.X + 210, destRectangle.Y + 618, 9, 9);
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
            float[] counts = SaveFileLoader.Instance.LoadFile(0);
            hearts = counts[0];
            heartContainers = (int)counts[1];
            RupeeCount = (int)counts[2];
            KeyCount = (int)counts[3];
            HasBow = Convert.ToBoolean(counts[4]);

            LinkItems = new Dictionary<string, InventoryItem>() {
                { "Arrow", new InventoryItem(ArrowDestRectangle, ItemSpriteFactory.Instance.CreateArrowSprite(), new SetUseArrowCommand(game1), counts[5]) },
                { "BlueCandle", new InventoryItem(BlueCandleDestRectangle, ItemSpriteFactory.Instance.CreateBlueCandleSprite(), new SetUseFireCommand(game1), counts[6]) },
                { "BluePotion", new InventoryItem(BluePotionDestRectangle, ItemSpriteFactory.Instance.CreateBluePotionSprite(), new UseBluePotion(), counts[7]) },
                { "Bomb", new InventoryItem(BombDestRectangle, ItemSpriteFactory.Instance.CreateBombSprite(), new SetUseBombCommand(game1), counts[8]) },
                { "Boomerang", new InventoryItem(BoomerangDestRectangle, ItemSpriteFactory.Instance.CreateBoomerangSprite(), new SetUseBoomerangCommand(game1), counts[9]) },
                { "Clock", new InventoryItem(ClockDestRectangle, ItemSpriteFactory.Instance.CreateClockSprite(), new UseClock(), counts[10]) },
                { "Fairy", new InventoryItem(FairyDestRectangle, ItemSpriteFactory.Instance.CreateFairySprite(), new UseFairy(), counts[11]) },
                { "Compass", new InventoryItem(CompassDestRectangle, ItemSpriteFactory.Instance.CreateCompassSprite(), null, counts[12]) },
                { "Map", new InventoryItem(MapDestRectangle, ItemSpriteFactory.Instance.CreateMapSprite(), null, counts[13]) }
            };
        }

        public static void Reset() {
            float[] counts = SaveFileLoader.Instance.LoadFile(0);
            hearts = counts[0];
            heartContainers = (int)counts[1];
            RupeeCount = (int)counts[2];
            KeyCount = (int)counts[3];
            HasBow = Convert.ToBoolean(counts[4]);
            int i = 5;
            foreach(KeyValuePair<String,InventoryItem> item in LinkItems) {
                item.Value.SetCount(counts[i]);
                i++;
            }
        }

        public static void IncrementCount(String item) {  LinkItems[item].IncrementCount(); }
        public static void DecrementCount(String item) { LinkItems[item].DecrementCount(); }
        public static float GetCount(String item) {  return LinkItems[item].Count(); }
        public static IItemSprite GetSprite(String item) { return LinkItems[item].GetSprite(); }
        public static void UseItem(String item) { LinkItems[item].UseItem(); }

        public static void ShiftUp() {
            if (destRectangle.Y > -525)
            {
                //destRectangle.Y--;
                foreach (KeyValuePair<String, InventoryItem> item in LinkItems)
                {
                    item.Value.ShiftUp();
                }
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
            }
            else {
                FullView = true;
            }
        }
        public void Update() {
            count++;
            triforceSprite = TriforceMarkers[Globals.FindIndex(count % (TriforceMarkers.Length * 5), 5, TriforceMarkers.Length)];            
        }

        public void Draw(SpriteBatch spriteBatch) {
            menuSprite.Draw(spriteBatch, destRectangle);
            if (LinkItems["Map"].Count() > 0) { mapLayoutSprite.Draw(spriteBatch, DungeonMapDestRectangle); }
            if (LinkItems["Compass"].Count() > 0) { triforceSprite.Draw(spriteBatch, TriforceDestRectangle); }

            Menu.Draw(spriteBatch);
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
