using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Items.ItemClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Inventory
{
    public class InventoryController
    {
        public struct InventoryItem {
            internal float count = 0;
            public Rectangle destRectangle { get; private set; }
            public Rectangle sourceRectangle { get; private set; }

            public InventoryItem(Rectangle destination, Rectangle source)
            {
                count = 1;
                destRectangle = destination;
                sourceRectangle = source;
            }

            public InventoryItem(float c)
            {
                count = c;
                destRectangle = new Rectangle();
                sourceRectangle = new Rectangle();
            }

            public InventoryItem(Rectangle destination, Rectangle source, float c)
            {
                count = c;
                destRectangle = destination;
                sourceRectangle = source;
            }

            public void IncrementCount() {
                count++;
            }

            public void DecrementCount()
            {
                count--;
            }

            public void IncrementCount(float i)
            {
                count += i;
            }

            public void DecrementCount(float i)
            {
                count -= i;
            }

            public void ShiftUp() {
                destRectangle = new Rectangle(destRectangle.X, destRectangle.Y - 1, destRectangle.Width, destRectangle.Height);
            }

            public void ShiftDown()
            {
                destRectangle = new Rectangle(destRectangle.X, destRectangle.Y + 1, destRectangle.Width, destRectangle.Height);
            }
        }
        private static Rectangle destRectangle = new Rectangle(0, 12, 800, 700);
        private static Rectangle sourceRectangle = new Rectangle(0, 0, 255, 231);
        private Texture2D texture;
        public static Dictionary<String, InventoryItem> LinkItems { get; set; }
        private static Rectangle[] HeartBoxes = new Rectangle[] {
                new Rectangle(destRectangle.X + 552, destRectangle.Y + 630, 26, 25),
                new Rectangle(destRectangle.X + 578, destRectangle.Y + 630, 26, 25),
                new Rectangle(destRectangle.X + 603, destRectangle.Y + 630, 26, 25),
                new Rectangle(destRectangle.X + 628, destRectangle.Y + 630, 26, 25),
                new Rectangle(destRectangle.X + 653, destRectangle.Y + 630, 26, 25),
                new Rectangle(destRectangle.X + 678, destRectangle.Y + 630, 26, 25),
                new Rectangle(destRectangle.X + 703, destRectangle.Y + 630, 26, 25),
                new Rectangle(destRectangle.X + 728, destRectangle.Y + 630, 26, 25),
                new Rectangle(destRectangle.X + 552, destRectangle.Y + 655, 26, 25),
                new Rectangle(destRectangle.X + 578, destRectangle.Y + 655, 26, 25),
                new Rectangle(destRectangle.X + 603, destRectangle.Y + 655, 26, 25),
                new Rectangle(destRectangle.X + 628, destRectangle.Y + 655, 26, 25),
                new Rectangle(destRectangle.X + 653, destRectangle.Y + 655, 26, 25),
                new Rectangle(destRectangle.X + 678, destRectangle.Y + 655, 26, 25),
                new Rectangle(destRectangle.X + 703, destRectangle.Y + 655, 26, 25),
                new Rectangle(destRectangle.X + 728, destRectangle.Y + 655, 26, 25)
        };

        private static Dictionary<char, Rectangle> numberSrcRectangles = new Dictionary<char, Rectangle>() {
            { '0', new Rectangle(271, 131, 8, 8) },
            { '1', new Rectangle(280, 131, 8, 8) },
            { '2', new Rectangle(289, 131, 8, 8) },
            { '3', new Rectangle(298, 131, 8, 8) },
            { '4', new Rectangle(307, 131, 8, 8) },
            { '5', new Rectangle(316, 131, 8, 8) },
            { '6', new Rectangle(325, 131, 8, 8) },
            { '7', new Rectangle(334, 131, 8, 8) },
            { '8', new Rectangle(343, 131, 8, 8) },
            { '9', new Rectangle(352, 131, 8, 8) },
            { ' ', blackSrcRectangle }
        };

        private static Rectangle[] DigitDestRectangles = new Rectangle[]
        {
            new Rectangle(destRectangle.X + 326, destRectangle.Y + 581, 26, 26),
            new Rectangle(destRectangle.X + 352, destRectangle.Y + 581, 26, 26),
            new Rectangle(destRectangle.X + 326, destRectangle.Y + 629, 26, 26),
            new Rectangle(destRectangle.X + 352, destRectangle.Y + 629, 26, 26),
            new Rectangle(destRectangle.X + 326, destRectangle.Y + 655, 26, 26),
            new Rectangle(destRectangle.X + 352, destRectangle.Y + 655, 26, 26)
        };

        private static Rectangle ItemBDestRectangle = new Rectangle(destRectangle.X + 401, destRectangle.Y + 606, 26, 49);
        private static Rectangle ItemADestRectangle = new Rectangle(destRectangle.X + 477, destRectangle.Y + 606, 26, 49);
        private static Rectangle ItemSelectedDestRectangle = new Rectangle(destRectangle.X + 212, destRectangle.Y + 145, 26, 49);
        private static Rectangle DungeonMapDestRectangle = new Rectangle(destRectangle.X + 50, destRectangle.Y + 582, 201, 97);
        private static Rectangle CursorDestRectangle = new Rectangle(destRectangle.X + 402, destRectangle.Y + 145, 49, 49);

        private static Rectangle DungeonMapSrcRectangle = new Rectangle(258, 34, 62, 30);

        private static Rectangle blackSrcRectangle = new Rectangle(315,170, 10,10);
        
        private static Rectangle ArrowSrcRectangle = new Rectangle(341, 151, 8, 15);
        private static Rectangle BlueCandleSrcRectangle = new Rectangle(368, 151, 8, 15);
        private static Rectangle BluePotionSrcRectangle = new Rectangle(386, 151, 8, 15);
        private static Rectangle BombSrcRectangle = new Rectangle(332, 151, 8, 15);
        private static Rectangle BoomerangSrcRectangle = new Rectangle(314, 151, 8, 15);
        private static Rectangle BowSrcRectangle = new Rectangle(359, 151, 8, 16);
        private static Rectangle ClockSrcRectangle = new Rectangle(413, 151, 11, 16);
        private static Rectangle CompassSrcRectangle = new Rectangle(288, 168, 14, 15);
        private static Rectangle FairySrcRectangle = new Rectangle(404, 151, 8, 15);
        private static Rectangle EmptyHeartSrcRectangle = new Rectangle(370, 131, 8, 8);
        private static Rectangle HalfHeartSrcRectangle = new Rectangle(379, 131, 8, 8);
        private static Rectangle FullHeartSrcRectangle = new Rectangle(388, 131, 8, 8);
        private static Rectangle MapSrcRectangle = new Rectangle(279, 168, 8, 15);
        private static Rectangle CursorSrcRectangle = new Rectangle(262, 151, 16, 16);


        private static Rectangle BoomerangDestRectangle = new Rectangle(destRectangle.X + 415, destRectangle.Y + 145, 26, 49);
        private static Rectangle BombDestRectangle = new Rectangle(destRectangle.X + 489, destRectangle.Y + 145, 26, 49);
        private static Rectangle ArrowDestRectangle = new Rectangle(destRectangle.X + 563, destRectangle.Y + 145, 26, 49);
        private static Rectangle BlueCandleDestRectangle = new Rectangle(destRectangle.X + 638, destRectangle.Y + 145, 29, 49);

        private static Rectangle BowDestRectangle = new Rectangle(destRectangle.X + 415, destRectangle.Y + 196, 26, 49);
        private static Rectangle ClockDestRectangle = new Rectangle(destRectangle.X + 488, destRectangle.Y + 196, 28, 49);
        private static Rectangle BluePotionDestRectangle = new Rectangle(destRectangle.X + 563, destRectangle.Y + 196, 27, 49);
        private static Rectangle FairyDestRectangle = new Rectangle(destRectangle.X + 639, destRectangle.Y + 196, 26, 49);
        
        private static Rectangle MapDestRectangle = new Rectangle(destRectangle.X + 150, destRectangle.Y + 339, 26, 49);
        private static Rectangle CompassDestRectangle = new Rectangle(destRectangle.X + 138, destRectangle.Y + 460, 47, 49);
        public InventoryController(Texture2D texture) {
            LinkItems = new Dictionary<string, InventoryItem>() {
                { "Arrow", new InventoryItem(ArrowDestRectangle, ArrowSrcRectangle) },
                { "BlueCandle", new InventoryItem(BlueCandleDestRectangle, BlueCandleSrcRectangle) },
                { "BluePotion", new InventoryItem(BluePotionDestRectangle, BluePotionSrcRectangle) },
                { "Bomb", new InventoryItem(BombDestRectangle, BombSrcRectangle, 1) },
                { "Boomerang", new InventoryItem(BoomerangDestRectangle, BoomerangSrcRectangle) },
                { "Bow", new InventoryItem(BowDestRectangle, BowSrcRectangle) },
                { "Clock", new InventoryItem(ClockDestRectangle, ClockSrcRectangle) },
                { "Compass", new InventoryItem(CompassDestRectangle, CompassSrcRectangle) },
                { "Fairy", new InventoryItem(FairyDestRectangle, FairySrcRectangle) },
                { "Heart", new InventoryItem(3.5f) },
                { "HeartContainer", new InventoryItem(1) },
                { "Key", new InventoryItem(0) },
                { "Map", new InventoryItem(MapDestRectangle, MapSrcRectangle) },
                { "Rupee", new InventoryItem(35) },
                { "TriforcePiece", new InventoryItem() }
            };
            this.texture = texture;
        }

        private static String UpdateItemCounts() {
            String ItemsCount = LinkItems["Rupee"].count.ToString();
            if (ItemsCount.Length % 2 != 0) {
                ItemsCount += ' ';
            }

            ItemsCount += LinkItems["Key"].count.ToString();
            if (ItemsCount.Length % 2 != 0)
            {
                ItemsCount += ' ';
            }

            ItemsCount += LinkItems["Bomb"].count.ToString();
            if (ItemsCount.Length % 2 != 0)
            {
                ItemsCount += ' ';
            }

            return ItemsCount;
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
            return LinkItems[item].count;
        }

        public static void ShiftCursorRight() {
            if (CursorDestRectangle.X < 627)
                CursorDestRectangle.X += 75;
        }
        public static void ShiftCursorLeft()
        {
            if(CursorDestRectangle.X > 402)
                CursorDestRectangle.X -= 75;
        }
        public static void ShiftCursorUp()
        {
            if (CursorDestRectangle.Y > 145)
                CursorDestRectangle.Y -= 50;
        }
        public static void ShiftCursorDown()
        {
            if (CursorDestRectangle.Y < 195)
                CursorDestRectangle.Y += 50;
        }

        public void ShiftUp() {
            if (destRectangle.Y > -525)
            {
                destRectangle.Y--;
                foreach (KeyValuePair<String, InventoryItem> item in LinkItems)
                {
                    item.Value.ShiftUp();
                }

                for (int i = 0; i < HeartBoxes.Length; i++)
                {
                    HeartBoxes[i].Y--;
                }

                for (int i = 0; i < DigitDestRectangles.Length; i++)
                {
                    DigitDestRectangles[i].Y--;
                }

                ItemBDestRectangle.Y--;
                ItemADestRectangle.Y--;
                ItemSelectedDestRectangle.Y--;
                DungeonMapDestRectangle.Y--;
                CursorDestRectangle.Y--;
            }

        }

        public void DownUp()
        {
            if (destRectangle.Y < 12)
            {
                destRectangle.Y++;
                foreach (KeyValuePair<String, InventoryItem> item in LinkItems)
                {
                    item.Value.ShiftDown();
                }

                for (int i = 0; i < HeartBoxes.Length; i++)
                {
                    HeartBoxes[i].Y++;
                }

                for (int i = 0; i < DigitDestRectangles.Length; i++)
                {
                    DigitDestRectangles[i].Y++;
                }

                ItemBDestRectangle.Y++;
                ItemADestRectangle.Y++;
                ItemSelectedDestRectangle.Y++;
                DungeonMapDestRectangle.Y++;
                CursorDestRectangle.Y++;
            }
        }

        public void Draw(SpriteBatch spriteBatch) {
            spriteBatch.Draw(texture, destRectangle, sourceRectangle, Color.White);

            //draw item Menu
            spriteBatch.Draw(texture, ItemSelectedDestRectangle, BowSrcRectangle, Color.White);
            foreach (KeyValuePair<String, InventoryItem> pair in LinkItems) {
                if (pair.Value.count > 0) {
                    spriteBatch.Draw(texture, pair.Value.destRectangle, pair.Value.sourceRectangle, Color.White);
                }
                else
                {
                    spriteBatch.Draw(texture, pair.Value.destRectangle, blackSrcRectangle, Color.White);
                }
            }

            //draw hearts
            for (int i = 0; i < HeartBoxes.Length; i++)
            {
                if (i < LinkItems["Heart"].count - .5)
                {
                    spriteBatch.Draw(texture, HeartBoxes[i], FullHeartSrcRectangle, Color.White);
                }
                else if ((LinkItems["Heart"].count - i) % 1 == .5)
                {
                    spriteBatch.Draw(texture, HeartBoxes[i], HalfHeartSrcRectangle, Color.White);
                }
                else {
                    if (i < (LinkItems["HeartContainer"].count + LinkItems["Heart"].count - .5)) {
                        spriteBatch.Draw(texture, HeartBoxes[i], EmptyHeartSrcRectangle, Color.White);
                    } else
                    {
                        spriteBatch.Draw(texture, HeartBoxes[i], blackSrcRectangle, Color.White);
                    }
                }
            }

            //Draw Items A&B
            spriteBatch.Draw(texture, ItemBDestRectangle, BowSrcRectangle, Color.White);
            spriteBatch.Draw(texture, ItemADestRectangle, BowSrcRectangle, Color.White);
            spriteBatch.Draw(texture, ItemSelectedDestRectangle, BoomerangSrcRectangle, Color.White);

            //draw layout
            spriteBatch.Draw(texture, DungeonMapDestRectangle, DungeonMapSrcRectangle, Color.White);

            //draw numbers
            String number = UpdateItemCounts();
            for (int i = 0; i < DigitDestRectangles.Length; i++) {
                spriteBatch.Draw(texture, DigitDestRectangles[i], numberSrcRectangles[number.ElementAt(i)], Color.White);
            }

            //draw cursor
            spriteBatch.Draw(texture, CursorDestRectangle, CursorSrcRectangle, Color.White);
        }
    }
}
