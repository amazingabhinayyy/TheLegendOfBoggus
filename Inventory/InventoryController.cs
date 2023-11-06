using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.CommandClasses;
using Sprint2_Attempt3.Dungeon;
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
        private static Rectangle destRectangle = new Rectangle(0, -525, 800, 700);
        private static Rectangle sourceRectangle = new Rectangle(0, 0, 255, 231);
        private static int ItemAIndex;
        private static int ItemBIndex;
        private static int ItemSelectedIndex;
        private static int count;
        private Texture2D texture;
        public static bool FullView { get; private set; }
        private static Dictionary<String, InventoryItem> LinkItems { get; set; }
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
            new Rectangle(destRectangle.X + 132, destRectangle.Y + 605, 9, 9)
        };

        private static Dictionary<int, Rectangle> MapRoomDestRectangles = new Dictionary<int, Rectangle>() {
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
            { 17, new Rectangle(destRectangle.X + 477, destRectangle.Y + 317, 25, 24) }
        };

        private static String[] ItemMenuStrings = { "Boomerang", "Bomb", "Arrow", "BlueCandle", "Bow", "Clock", "BluePotion", "Fairy" };
        private static List<int> RoomsNotVisited = new List<int>();

        private static Rectangle ItemBDestRectangle = new Rectangle(destRectangle.X + 401, destRectangle.Y + 606, 26, 49);
        private static Rectangle ItemADestRectangle = new Rectangle(destRectangle.X + 477, destRectangle.Y + 606, 26, 49);
        private static Rectangle ItemSelectedDestRectangle = new Rectangle(destRectangle.X + 212, destRectangle.Y + 145, 26, 49);
        private static Rectangle DungeonMapDestRectangle = new Rectangle(destRectangle.X + 50, destRectangle.Y + 582, 201, 97);
        private static Rectangle CursorDestRectangle = new Rectangle(destRectangle.X + 402, destRectangle.Y + 145, 49, 49);

        private static Rectangle DungeonMapSrcRectangle = new Rectangle(258, 34, 62, 30);

        private static Rectangle blackSrcRectangle = new Rectangle(315,170, 10,10);
        private static Rectangle OrangeSrcRectangle = new Rectangle(100, 100, 10, 10);
        private static Rectangle WhiteMarkerSrcRectangle = new Rectangle(266, 140, 3, 3);
        private static Rectangle GreenMarkerSrcRectangle = new Rectangle(262, 140, 3, 3);
        private static Rectangle RedMarkerSrcRectangle = new Rectangle(270, 140, 3, 3);
        private static Rectangle TriforceMarkerSrcRectangle;

        private static Rectangle ArrowSrcRectangle = new Rectangle(341, 151, 8, 15);
        private static Rectangle BlueCandleSrcRectangle = new Rectangle(368, 151, 8, 15);
        private static Rectangle BluePotionSrcRectangle = new Rectangle(386, 151, 8, 15);
        private static Rectangle BombSrcRectangle = new Rectangle(332, 151, 8, 15);
        private static Rectangle BoomerangSrcRectangle = new Rectangle(314, 151, 8, 15);
        private static Rectangle BowSrcRectangle = new Rectangle(359, 151, 8, 16);
        private static Rectangle ClockSrcRectangle = new Rectangle(413, 151, 11, 16);
        private static Rectangle CompassSrcRectangle = new Rectangle(288, 168, 14, 15);
        private static Rectangle FairySrcRectangle = new Rectangle(404, 151, 8, 15);
        private static Rectangle SwordSrcRectangle = new Rectangle(296, 151, 8, 15);
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
        private static Rectangle SwordDestRectangle = new Rectangle(destRectangle.X + 415, destRectangle.Y + 196, 26, 49);
        private static Rectangle ClockDestRectangle = new Rectangle(destRectangle.X + 488, destRectangle.Y + 196, 28, 49);
        private static Rectangle BluePotionDestRectangle = new Rectangle(destRectangle.X + 563, destRectangle.Y + 196, 27, 49);
        private static Rectangle FairyDestRectangle = new Rectangle(destRectangle.X + 639, destRectangle.Y + 196, 26, 49);
        
        private static Rectangle MapDestRectangle = new Rectangle(destRectangle.X + 150, destRectangle.Y + 339, 26, 49);
        private static Rectangle CompassDestRectangle = new Rectangle(destRectangle.X + 138, destRectangle.Y + 460, 47, 49);
        public InventoryController(Texture2D texture, Game1 game1) {
            LinkItems = new Dictionary<string, InventoryItem>() {
                { "Arrow", new InventoryItem(ArrowDestRectangle, ArrowSrcRectangle, new SetUseArrowCommand(game1)) },
                { "BlueCandle", new InventoryItem(BlueCandleDestRectangle, BlueCandleSrcRectangle) },
                { "BluePotion", new InventoryItem(BluePotionDestRectangle, BluePotionSrcRectangle) },
                { "Bomb", new InventoryItem(BombDestRectangle, BombSrcRectangle, new SetUseBombCommand(game1), 99) },
                { "Boomerang", new InventoryItem(BoomerangDestRectangle, BoomerangSrcRectangle, new SetUseBoomerangCommand(game1)) },
                { "Bow", new InventoryItem(BowDestRectangle, BowSrcRectangle) },
                { "Clock", new InventoryItem(ClockDestRectangle, ClockSrcRectangle) },
                { "Compass", new InventoryItem(CompassDestRectangle, CompassSrcRectangle, 0) },
                { "Fairy", new InventoryItem(FairyDestRectangle, FairySrcRectangle) },
                { "SwordProjectile", new InventoryItem(SwordDestRectangle, SwordSrcRectangle, new SetAttackLinkCommand(game1)) },
                { "Heart", new InventoryItem(3.5f) },
                { "HeartContainer", new InventoryItem(5) },
                { "Key", new InventoryItem(99) },
                { "Map", new InventoryItem(MapDestRectangle, MapSrcRectangle, 0) },
                { "Rupee", new InventoryItem(99) },
                { "TriforcePiece", new InventoryItem() }
            };
            ItemAIndex = 1;
            ItemBIndex = 2;
            ItemSelectedIndex = 0;
            TriforceMarkerSrcRectangle = GreenMarkerSrcRectangle;
            count = 0;
            RoomsNotVisited.AddRange(Enumerable.Range(1,17));
            FullView = false;
            this.texture = texture;
        }

        private static String UpdateItemCounts() {
            String ItemsCount = LinkItems["Rupee"].Count().ToString();
            if (ItemsCount.Length % 2 != 0) {
                ItemsCount += ' ';
            }

            ItemsCount += LinkItems["Key"].Count().ToString();
            if (ItemsCount.Length % 2 != 0)
            {
                ItemsCount += ' ';
            }

            ItemsCount += LinkItems["Bomb"].Count().ToString();
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
            return LinkItems[item].Count();
        }

        public static void ShiftCursorRight() {
            if (CursorDestRectangle.X < 627)
            {
                CursorDestRectangle.X += 75;
                ItemSelectedIndex++;
            }
        }
        public static void ShiftCursorLeft()
        {
            if (CursorDestRectangle.X > 402)
            {
                CursorDestRectangle.X -= 75;
                ItemSelectedIndex--;
            }
        }
        public static void ShiftCursorUp()
        {
            if (CursorDestRectangle.Y > 145)
            {
                CursorDestRectangle.Y -= 50;
                ItemSelectedIndex -= 4;
            }
        }
        public static void ShiftCursorDown()
        {
            if (CursorDestRectangle.Y < 195)
            {
                CursorDestRectangle.Y += 50;
                ItemSelectedIndex += 4;
            }
        }

        public static void SetItemA() {
            if(ItemSelectedIndex != ItemBIndex)
                ItemAIndex = ItemSelectedIndex;
        }
        public static void SetItemB()
        {
            if(ItemSelectedIndex != ItemAIndex)
                ItemBIndex = ItemSelectedIndex;
        }

        public static void UseAItem()
        {
            LinkItems[ItemMenuStrings[ItemAIndex]].UseItem();
        }
        public static void UseBItem()
        {
            LinkItems[ItemMenuStrings[ItemBIndex]].UseItem();
        }

        public static void VisitRoom(int i) {
            if(MapRoomDestRectangles.ContainsKey(i))
                MapRoomDestRectangles.Remove(i);
        }

        public static void ShiftUp() {
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

                for (int i = 0; i < MarkerDestRectangles.Length; i++)
                {
                    MarkerDestRectangles[i].Y--;
                }

                ItemBDestRectangle.Y--;
                ItemADestRectangle.Y--;
                ItemSelectedDestRectangle.Y--;
                DungeonMapDestRectangle.Y--;
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
            else {
                FullView = true;
            }
        }

        public void Update() {
            if (count <= 10)
            {
                TriforceMarkerSrcRectangle = GreenMarkerSrcRectangle;
            }
            else if (count <= 20)
            {
                TriforceMarkerSrcRectangle = RedMarkerSrcRectangle;
            }
            else {
                count = 0;
            }
            count++;
        }

        public void Draw(SpriteBatch spriteBatch) {
            spriteBatch.Draw(texture, destRectangle, sourceRectangle, Color.White);

            //draw item Menu
            spriteBatch.Draw(texture, ItemSelectedDestRectangle, BowSrcRectangle, Color.White);
            foreach (KeyValuePair<String, InventoryItem> pair in LinkItems) {
                if (pair.Value.Count() > 0) {
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
                if (i < LinkItems["Heart"].Count() - .5)
                {
                    spriteBatch.Draw(texture, HeartBoxes[i], FullHeartSrcRectangle, Color.White);
                }
                else if ((LinkItems["Heart"].Count() - i) % 1 == .5)
                {
                    spriteBatch.Draw(texture, HeartBoxes[i], HalfHeartSrcRectangle, Color.White);
                }
                else {
                    if (i < LinkItems["HeartContainer"].Count()) {
                        spriteBatch.Draw(texture, HeartBoxes[i], EmptyHeartSrcRectangle, Color.White);
                    } else
                    {
                        spriteBatch.Draw(texture, HeartBoxes[i], blackSrcRectangle, Color.White);
                    }
                }
            }

            //Draw Items A&B
            spriteBatch.Draw(texture, ItemBDestRectangle, LinkItems[ItemMenuStrings[ItemAIndex]].sourceRectangle, Color.White);
            spriteBatch.Draw(texture, ItemADestRectangle, LinkItems[ItemMenuStrings[ItemBIndex]].sourceRectangle, Color.White);
            spriteBatch.Draw(texture, ItemSelectedDestRectangle, LinkItems[ItemMenuStrings[ItemSelectedIndex]].sourceRectangle, Color.White);

            //draw layout
            if (LinkItems["Map"].Count() > 0)
            {
                spriteBatch.Draw(texture, DungeonMapDestRectangle, DungeonMapSrcRectangle, Color.White);
            }

            //draw numbers
            String number = UpdateItemCounts();
            for (int i = 0; i < DigitDestRectangles.Length; i++) {
                spriteBatch.Draw(texture, DigitDestRectangles[i], numberSrcRectangles[number.ElementAt(i)], Color.White);
            }

            //draw cursor
            spriteBatch.Draw(texture, CursorDestRectangle, CursorSrcRectangle, Color.White);

            //draw triforce marker
            if (LinkItems["Compass"].Count() > 0) {
                spriteBatch.Draw(texture, MarkerDestRectangles[14], TriforceMarkerSrcRectangle, Color.White);
            }

            //draw Marker
            spriteBatch.Draw(texture, MarkerDestRectangles[RoomSecondary.GetCurrentRoomNumber()], WhiteMarkerSrcRectangle, Color.White);

            //draw map rooms
            foreach (KeyValuePair<int, Rectangle> room in MapRoomDestRectangles)
            {
                spriteBatch.Draw(texture, room.Value, OrangeSrcRectangle, Color.White);
            }
        }
    }
}
