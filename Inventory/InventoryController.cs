﻿using Microsoft.Xna.Framework;
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
        private static Rectangle DestRectangle = new Rectangle(0, -525, 800, 700);
        public static Rectangle destRectangle { get { return DestRectangle; } }
        public static int AnimateRate { get; } = 5;
        private static IItemSprite menuSprite = ItemSpriteFactory.Instance.CreateInventoryMenuSprite();
        private static IItemSprite mapLayoutSprite = ItemSpriteFactory.Instance.CreateMapLayoutSprite();
        private static int count = 0;
        private static Game1 game;
        public enum ItemMenuState { 
            movingUp,
            movingDown,
            fullView,
            collapsed
        }
        public static ItemMenuState itemMenuState { get; set; } = ItemMenuState.collapsed;
        public static float hearts { get; set; }
        public static int heartContainers { get; set; }
        public static int RupeeCount { get; set; }
        public static int KeyCount { get; set; }
        public static bool HasBow { get; set; }
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
            game = game1;
            LinkItems = new Dictionary<string, InventoryItem>() {
                { "Arrow", new InventoryItem(ArrowDestRectangle, ItemSpriteFactory.Instance.CreateArrowSprite(), new SetUseArrowCommand(game1)) },
                { "BlueCandle", new InventoryItem(BlueCandleDestRectangle, ItemSpriteFactory.Instance.CreateBlueCandleSprite(), new SetUseFireCommand(game1)) },
                { "BluePotion", new InventoryItem(BluePotionDestRectangle, ItemSpriteFactory.Instance.CreateBluePotionSprite(), new UseBluePotion()) },
                { "Bomb", new InventoryItem(BombDestRectangle, ItemSpriteFactory.Instance.CreateBombSprite(), new SetUseBombCommand(game1)) },
                { "Boomerang", new InventoryItem(BoomerangDestRectangle, ItemSpriteFactory.Instance.CreateBoomerangSprite(), new SetUseBoomerangCommand(game1)) },
                { "Clock", new InventoryItem(ClockDestRectangle, ItemSpriteFactory.Instance.CreateClockSprite(), new UseClock()) },
                { "Fairy", new InventoryItem(FairyDestRectangle, ItemSpriteFactory.Instance.CreateFairySprite(), new UseFairy()) },
                { "Compass", new InventoryItem(CompassDestRectangle, ItemSpriteFactory.Instance.CreateCompassSprite(), null) },
                { "Map", new InventoryItem(MapDestRectangle, ItemSpriteFactory.Instance.CreateMapSprite(), null) }
            };
        }

        public static void LoadFile(int i) {
            float[] counts = SaveFileLoader.Instance.LoadFile(i);
            hearts = counts[0];
            heartContainers = (int)counts[1];
            RupeeCount = (int)counts[2];
            KeyCount = (int)counts[3];
            HasBow = Convert.ToBoolean(counts[4]);

            int x = 5;
            foreach (KeyValuePair<String, InventoryItem> item in LinkItems)
            {
                item.Value.SetCount(counts[x]);
                x++;
            }
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

        public static void SaveToFile() {
            float[] counts = new float[SaveFileLoader.numCounts];
            counts[0] = hearts;
            counts[1] = heartContainers;
            counts[2] = RupeeCount;
            counts[3] = KeyCount;
            HasBow = Convert.ToBoolean(counts[4]);
            int i = 5;
            foreach (KeyValuePair<String, InventoryItem> item in LinkItems)
            {
                counts[i] = item.Value.Count();
                i++;
            }
            SaveFileLoader.Instance.SaveFile(counts);
        }

        public static void IncrementCount(String item) {  LinkItems[item].IncrementCount(); }
        public static void DecrementCount(String item) { LinkItems[item].DecrementCount(); }
        public static float GetCount(String item) {  return LinkItems[item].Count(); }
        public static IItemSprite GetSprite(String item) { return LinkItems[item].GetSprite(); }
        public static void UseItem(String item) { LinkItems[item].UseItem(); }

        public static void ShiftUp() {
            if (DestRectangle.Y > -525)
            {
                DestRectangle.Y -= AnimateRate;
                foreach (KeyValuePair<String, InventoryItem> item in LinkItems) { item.Value.ShiftUp(); }
                DungeonMapDestRectangle.Y -= AnimateRate;
                TriforceDestRectangle.Y -= AnimateRate;
                Menu.ShiftUp();
                MapController.ShiftUp();
                PlayerTrackerController.ShiftUp();
            }
            else {
                itemMenuState = ItemMenuState.collapsed;
                game.gameState = Game1.GameState.start;
            }
        }

        public static void ShiftDown()
        {
            if (DestRectangle.Y < -10)
            {
                DestRectangle.Y += AnimateRate;
                foreach (KeyValuePair<String, InventoryItem> item in LinkItems) { item.Value.ShiftDown(); }
                DungeonMapDestRectangle.Y += AnimateRate;
                TriforceDestRectangle.Y += AnimateRate;
                Menu.ShiftDown();
                MapController.ShiftDown();
                PlayerTrackerController.ShiftDown();
            } else { 
                itemMenuState = ItemMenuState.fullView; 
            }
        }
        public void Update() {
            count++;
            triforceSprite = TriforceMarkers[Globals.FindIndex(count % (TriforceMarkers.Length * 5), 5, TriforceMarkers.Length)];
            if (itemMenuState == ItemMenuState.movingUp) { ShiftUp(); } 
            else if (itemMenuState == ItemMenuState.movingDown) { ShiftDown(); }
        }

        public void Draw(SpriteBatch spriteBatch) {
            menuSprite.Draw(spriteBatch, destRectangle);
            if (LinkItems["Map"].Count() > 0) { mapLayoutSprite.Draw(spriteBatch, DungeonMapDestRectangle); }
            if (LinkItems["Compass"].Count() > 0) { triforceSprite.Draw(spriteBatch, TriforceDestRectangle); }

            Menu.Draw(spriteBatch);
            HealthController.DrawHearts(spriteBatch);
            MapController.DrawMap(spriteBatch);
            ItemCountController.DrawCounts(spriteBatch);

            foreach (KeyValuePair<String, InventoryItem> pair in LinkItems) { pair.Value.Draw(spriteBatch); }

            if(RoomSecondary.currentRoomNumber < 18)
                PlayerTrackerController.DrawPlayerTracker(spriteBatch);
        }
    }
}
