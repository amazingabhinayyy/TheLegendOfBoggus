using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.CommandClasses;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Items.ItemClasses;
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
        private static Rectangle destRectangle = new Rectangle(0, -525, 800, 700);
        private static Rectangle sourceRectangle = new Rectangle(0, 0, 255, 231);
        private static int ItemAIndex = 1;
        private static int ItemBIndex = 4;
        private static int ItemSelectedIndex = 0;
        private static int HeartBoxCount = 18;
        private static int count = 0;
        private Texture2D texture;
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
            new Rectangle(destRectangle.X + 132, destRectangle.Y + 605, 9, 9)
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
            { 17, new Rectangle(destRectangle.X + 477, destRectangle.Y + 317, 25, 24) }
        };

        private static Rectangle[] TriforceMarkers = new Rectangle[] { new Rectangle(262, 140, 3, 3), new Rectangle(270, 140, 3, 3) };

        private static String[] ItemMenuStrings = { "Boomerang", "Bomb", "Arrow", "BlueCandle", "SwordProjectile", "Clock", "BluePotion", "Fairy" };

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
        public InventoryController(Game1 game1) {
            LinkItems = new Dictionary<string, InventoryItem>() {
                { "Arrow", new InventoryItem(ArrowDestRectangle, ArrowSrcRectangle, new SetUseArrowCommand(game1)) },
                { "BlueCandle", new InventoryItem(BlueCandleDestRectangle, BlueCandleSrcRectangle, new SetUseFireCommand(game1)) },
                { "BluePotion", new InventoryItem(BluePotionDestRectangle, BluePotionSrcRectangle, new UseBluePotion()) },
                { "Bomb", new InventoryItem(BombDestRectangle, BombSrcRectangle, new SetUseBombCommand(game1), 99) },
                { "Boomerang", new InventoryItem(BoomerangDestRectangle, BoomerangSrcRectangle, new SetUseBoomerangCommand(game1)) },
                { "Bow", new InventoryItem(BowDestRectangle, BowSrcRectangle) },
                { "Clock", new InventoryItem(ClockDestRectangle, ClockSrcRectangle, new UseClock()) },
                { "Compass", new InventoryItem(CompassDestRectangle, CompassSrcRectangle, 0) },
                { "Fairy", new InventoryItem(FairyDestRectangle, FairySrcRectangle, new UseFairy()) },
                { "SwordProjectile", new InventoryItem(SwordDestRectangle, SwordSrcRectangle, new SetAttackLinkCommand(game1)) },
                { "Heart", new InventoryItem(3.5f) },
                { "HeartContainer", new InventoryItem(5) },
                { "Key", new InventoryItem(99) },
                { "Map", new InventoryItem(MapDestRectangle, MapSrcRectangle, 0) },
                { "Rupee", new InventoryItem(99) },
                { "TriforcePiece", new InventoryItem() },
                { "Cursor", new InventoryItem(CursorDestRectangle, CursorSrcRectangle, 1) },
                { "ItemA", new InventoryItem(ItemADestRectangle, BombSrcRectangle, 1) },
                { "ItemB", new InventoryItem(ItemBDestRectangle, SwordSrcRectangle, 1) },
                { "ItemSelected", new InventoryItem(ItemSelectedDestRectangle, BoomerangSrcRectangle, 1) },
                { "MapLayout", new InventoryItem(DungeonMapDestRectangle, DungeonMapSrcRectangle, 0) },
                { "PlayerMarker", new InventoryItem(MarkerDestRectangles[0], WhiteMarkerSrcRectangle, 1) },
                { "TriforceMarker", new InventoryItem(MarkerDestRectangles[14], RedMarkerSrcRectangle, 0) }
            };

            MakeNumberSrcRectangles();
            MakeDigitBoxes();
            MakeHeartBoxes();

            for (int i = 0; i < MarkerDestRectangles.Length; i++)
            {
                LinkItems.Add("UnvisitedRoom" + (i + 1).ToString(), new InventoryItem(MapRoomDestRectangles[i], OrangeSrcRectangle, 1));
            }

            this.texture = Game1.InventoryTexture;
        }

        private void MakeNumberSrcRectangles()
        {
            numberSrcRectangles.Add(' ', blackSrcRectangle);
            int i = 0;
            for (int x = 271; x <= 352; x += 9)
            {
                numberSrcRectangles.Add(i.ToString().ElementAt(0), new Rectangle(x, 131, 8, 8));
                i++;
            }
        }

        private void MakeHeartBoxes() {
            int i = 0;
            for (int y = 630; y <= 655; y += 25)
            {
                for (int x = 552; x <= 728; x += 26)
                {
                    LinkItems.Add("Heart" + (i + 1).ToString(), new InventoryItem(new Rectangle(destRectangle.X + x, destRectangle.Y + y, 26, 25), EmptyHeartSrcRectangle, 0));
                    i++;
                }
            }
        }
        private void MakeDigitBoxes()
        {
            int i = 0;
            for (int y = 581; y <= 655; y = y == 581 ? y + 48 : y + 26)
            {
                for (int x = 326; x <= 352; x += 26)
                {
                    LinkItems.Add("Digit" + (i + 1).ToString(), new InventoryItem(new Rectangle(destRectangle.X + x, destRectangle.Y + y, 26, 26), numberSrcRectangles['0'], 1));
                    i++;
                }
            }
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
            if (LinkItems["Cursor"].destRectangle.X < 627)
            {
                CursorDestRectangle.X += 75;
                LinkItems["Cursor"].SetDestRectangle(CursorDestRectangle);
                ItemSelectedIndex++;
                LinkItems["ItemSelected"].SetSrcRectangle(LinkItems[ItemMenuStrings[ItemSelectedIndex]].GetSrcRectangle());
            }
        }
        public static void ShiftCursorLeft()
        {
            if (LinkItems["Cursor"].destRectangle.X > 402)
            {
                CursorDestRectangle.X -= 75;
                LinkItems["Cursor"].SetDestRectangle(CursorDestRectangle);
                ItemSelectedIndex--;
                LinkItems["ItemSelected"].SetSrcRectangle(LinkItems[ItemMenuStrings[ItemSelectedIndex]].GetSrcRectangle());
            }
        }
        public static void ShiftCursorUp()
        {
            if (LinkItems["Cursor"].destRectangle.Y > 145)
            {
                CursorDestRectangle.Y -= 50;
                LinkItems["Cursor"].SetDestRectangle(CursorDestRectangle);
                ItemSelectedIndex -= 4;
                LinkItems["ItemSelected"].SetSrcRectangle(LinkItems[ItemMenuStrings[ItemSelectedIndex]].GetSrcRectangle());
            }
        }
        public static void ShiftCursorDown()
        {
            if (LinkItems["Cursor"].destRectangle.Y < 195)
            {
                CursorDestRectangle.Y += 50;
                LinkItems["Cursor"].SetDestRectangle(CursorDestRectangle);
                ItemSelectedIndex += 4;
                LinkItems["ItemSelected"].SetSrcRectangle(LinkItems[ItemMenuStrings[ItemSelectedIndex]].GetSrcRectangle());
            }
        }

        public static void SetItemA() {
            if (ItemSelectedIndex != ItemBIndex)
            {
                ItemAIndex = ItemSelectedIndex;
                LinkItems["ItemA"].SetSrcRectangle(LinkItems[ItemMenuStrings[ItemAIndex]].GetSrcRectangle());
            }
            UsingFairy = false;
        }
        public static void SetItemB()
        {
            if (ItemSelectedIndex != ItemAIndex)
            {
                ItemBIndex = ItemSelectedIndex;
                LinkItems["ItemB"].SetSrcRectangle(LinkItems[ItemMenuStrings[ItemBIndex]].GetSrcRectangle());
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

        public static void VisitRoom(int i) {
            LinkItems["UnvisitedRoom" + (i + 1).ToString()].DecrementCount();
        }

        public static void ShiftUp() {
            if (destRectangle.Y > -525)
            {
                destRectangle.Y--;
                foreach (KeyValuePair<String, InventoryItem> item in LinkItems)
                {
                    item.Value.ShiftUp();
                }

                for (int i = 0; i < MarkerDestRectangles.Length; i++)
                {
                    MarkerDestRectangles[i].Y--;
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
                destRectangle.Y++;
                foreach (KeyValuePair<String, InventoryItem> item in LinkItems)
                {
                    item.Value.ShiftDown();
                }

                for (int i = 0; i < MarkerDestRectangles.Length; i++)
                {
                    MarkerDestRectangles[i].Y++;
                }

                CursorDestRectangle.Y--;
            }
            else {
                FullView = true;
            }
        }
        public void Update() {
            LinkItems["TriforceMarker"].SetSrcRectangle(TriforceMarkers[Globals.FindIndex(count % 20, 10, TriforceMarkers.Length)]);
            count++;
        }

        private void UpdateHearts() {
            float hearts = LinkItems["Heart"].Count();
            float heartContainers = LinkItems["HeartContainer"].Count();
            for (int i = 0; i < HeartBoxCount; i++)
            {
                if (hearts <= 0)
                {
                    if (heartContainers - LinkItems["Heart"].Count() - .5 > 0)
                    {
                        heartContainers--;
                        LinkItems["Heart" + (i + 1).ToString()].IncrementCount();
                        LinkItems["Heart" + (i + 1).ToString()].SetSrcRectangle(EmptyHeartSrcRectangle);
                    }
                }
                else if (hearts < 1) {
                    LinkItems["Heart" + (i + 1).ToString()].IncrementCount();
                    LinkItems["Heart" + (i + 1).ToString()].SetSrcRectangle(HalfHeartSrcRectangle);
                    hearts -= .5f;
                }
                else { 
                    LinkItems["Heart" + (i + 1).ToString()].SetSrcRectangle(FullHeartSrcRectangle);
                    LinkItems["Heart" + (i + 1).ToString()].IncrementCount();
                    hearts--;
                }
            }
        }

        private static void UpdateItemCounts()
        {
            String ItemsCount = LinkItems["Rupee"].Count().ToString();
            if (ItemsCount.Length % 2 != 0)
            {
                ItemsCount += ' ';
            }
            LinkItems["Digit1"].SetSrcRectangle(numberSrcRectangles[ItemsCount.ElementAt(0)]);
            LinkItems["Digit2"].SetSrcRectangle(numberSrcRectangles[ItemsCount.ElementAt(1)]);

            ItemsCount = LinkItems["Key"].Count().ToString();
            if (ItemsCount.Length % 2 != 0)
            {
                ItemsCount += ' ';
            }
            LinkItems["Digit3"].SetSrcRectangle(numberSrcRectangles[ItemsCount.ElementAt(0)]);
            LinkItems["Digit4"].SetSrcRectangle(numberSrcRectangles[ItemsCount.ElementAt(1)]);

            ItemsCount = LinkItems["Bomb"].Count().ToString();
            if (ItemsCount.Length % 2 != 0)
            {
                ItemsCount += ' ';
            }
            LinkItems["Digit5"].SetSrcRectangle(numberSrcRectangles[ItemsCount.ElementAt(0)]);
            LinkItems["Digit6"].SetSrcRectangle(numberSrcRectangles[ItemsCount.ElementAt(1)]);
        }

        public void Draw(SpriteBatch spriteBatch) {
            spriteBatch.Draw(texture, destRectangle, sourceRectangle, Color.White);

            LinkItems["PlayerMarker"].SetDestRectangle(MarkerDestRectangles[RoomSecondary.GetCurrentRoomNumber()]);
            UpdateItemCounts();
            UpdateHearts();
            foreach (KeyValuePair<String, InventoryItem> pair in LinkItems)
            {
                if(pair.Value.Count() > 0)
                    spriteBatch.Draw(texture, pair.Value.destRectangle, pair.Value.GetSrcRectangle(), Color.White);
            }
            spriteBatch.Draw(texture, LinkItems["PlayerMarker"].destRectangle, LinkItems["PlayerMarker"].GetSrcRectangle(), Color.White);
        }
    }
}
