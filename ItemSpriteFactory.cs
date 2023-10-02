using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.ItemClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
//using System.Numerics;

namespace Sprint2_Attempt3
{
    public class ItemSpriteFactory
    {
        public static Texture2D itemTexture;
        private static Vector2 bombPos;
        private static Vector2 clockPos;
        private static Vector2 compassPos;
        private static Vector2 heartPos;
        private static Vector2 keyPos;
        private static Vector2 mapPos;
        public static Vector2 rupeePos;
        public static Vector2 heartcontainerPos;
        public static Vector2 triforcepiecePos;
        public static Vector2 boomerangPos;
        public static Vector2 bowPos;
        public static Vector2 arrowPos;
        public static Vector2 fairyPos;
        public static Vector2 bluecandlePos;
        public static Vector2 bluepotionPos;
        public static Vector2 StartPosition;





        //private static List<IItem> itemList = new List<IItem>();

        private static ItemSpriteFactory instance = new ItemSpriteFactory();

        public static ItemSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        private ItemSpriteFactory()
        {
            StartPosition = new Vector2(40, 40);
            rupeePos = bombPos = arrowPos = bluecandlePos 
                = bluepotionPos = boomerangPos = bowPos 
                = clockPos = compassPos = fairyPos = heartcontainerPos 
                = heartPos = keyPos = mapPos = triforcepiecePos 
                = StartPosition;
        }

        public void LoadAllTextures(ContentManager content)
        {
            itemTexture = content.Load<Texture2D>("Items");
            //itemList.Add(CreateRupeeItem);
        }

        public static Rectangle bombSrc = new Rectangle(135, 0, 9, 15);
        public static Rectangle clockSrc = new Rectangle(57, 0, 13, 17);
        public static Rectangle compassSrc = new Rectangle(258, 1, 11, 12); //???
        public static Rectangle heartSrc = new Rectangle(0, 0, 7, 8); 
        public static Rectangle keySrc = new Rectangle(240, 0, 8, 16);
        public static Rectangle mapSrc = new Rectangle(88, 0, 8, 16);
        public static Rectangle rupeeSrc = new Rectangle(72, 0, 8, 16);

        public static Rectangle heartcontainerSrc = new Rectangle(25, 0, 13, 14);
        public static Rectangle triforcepieceSrc = new Rectangle(275, 3, 10, 10);
        public static Rectangle boomerangSrc = new Rectangle(129, 3, 5, 8);
        public static Rectangle bowSrc = new Rectangle(144, 0, 8, 16);
        public static Rectangle arrowSrc = new Rectangle(154, 0, 5, 16);
        public static Rectangle fairySrc = new Rectangle(48, 0, 8, 16); //???
        public static Rectangle bluecandleSrc = new Rectangle(160, 16, 8, 16);
        public static Rectangle bluepotionSrc = new Rectangle(80, 16, 8, 16);

        public IJustItemSprite CreateRupeeItem()
        {
            return new RupeeItem(itemTexture, rupeePos, rupeeSrc);
        }

        public IJustItemSprite CreateBombItem()
        {
            return new BombItem(itemTexture, bombPos, bombSrc);
        }

        public IJustItemSprite CreateClockItem()
        {
            return new ClockItem(itemTexture, clockPos, clockSrc);
        }

        public IJustItemSprite CreateCompassItem()
        {
            return new CompassItem(itemTexture, compassPos, compassSrc);
        }

        public IJustItemSprite CreateHeartItem()
        {
            return new HeartItem(itemTexture, heartPos, heartSrc);
        }

        public IJustItemSprite CreateKeyItem()
        {
            return new KeyItem(itemTexture, keyPos, keySrc);
        }

        public IJustItemSprite CreateMapItem()
        {
            return new MapItem(itemTexture, mapPos, mapSrc);
        }

        public IJustItemSprite CreateHeartContainerItem()
        {
            return new HeartContainerItem(itemTexture, heartcontainerPos, heartcontainerSrc);
        }

        public IJustItemSprite CreateTriforcePieceItem()
        {
            return new TriforcePieceItem(itemTexture, triforcepiecePos, triforcepieceSrc);
        }

        public IJustItemSprite CreateBoomerangItem()
        {
            return new BoomerangItem(itemTexture, boomerangPos, boomerangSrc);
        }

        public IJustItemSprite CreateBowItem()
        {
            return new BowItem(itemTexture, bowPos, bowSrc);
        }
        public IJustItemSprite CreateArrowItem()
        {
            return new ArrowItem(itemTexture, arrowPos, arrowSrc);
        }
        public IJustItemSprite CreateFairyItem()
        {
            return new FairyItem(itemTexture, fairyPos, fairySrc);
        }
        public IJustItemSprite CreateBlueCandleItem()
        {
            return new BlueCandleItem(itemTexture, bluecandlePos, bluecandleSrc);
        }

        public IJustItemSprite CreateBluePotionItem()
        {
            return new BluePotionItem(itemTexture, bluepotionPos, bluepotionSrc);
        }

    }
}
