using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Blocks.Block;
using Sprint2_Attempt3.Blocks.BlockSprites;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Aquamentus;
using Sprint2_Attempt3.Enemy.Dodongo;
using Sprint2_Attempt3.Enemy.Gel;
using Sprint2_Attempt3.Enemy.Goriya;
using Sprint2_Attempt3.Enemy.Hand;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;
using Sprint2_Attempt3.Enemy.SpikeTrap;
using Sprint2_Attempt3.Enemy.Stalfos;
using Sprint2_Attempt3.Enemy.Zol;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemClasses;
using System;
using System.Collections.Generic;
using System.IO;

namespace Sprint2_Attempt3.Dungeon
{
    internal class RoomGenerator
    {

        private static RoomGenerator instance = new RoomGenerator();
        private static String[] fileNames = new String[18];

        public static RoomGenerator Instance
        {
            get
            {
                return instance;
            }
        }
        public RoomGenerator()
        {
        }
        public void LoadAllFiles() {
            for (int i = 0; i < fileNames.Length; i++)
            {
                fileNames[i] = "Dungeon/RoomFiles/Room" + (i + 1) + ".csv";
            }

        }

        public List<IGameObject> LoadFile(int fileNumber) {
            List<IGameObject> objectList = new List<IGameObject>();

            StreamReader sr = new StreamReader(fileNames[fileNumber]);
            while (!sr.EndOfStream) { 
                var line = sr.ReadLine();
                if (line != null)
                {
                    var words = line.Split(",");
                    if (words[0].Equals("Enemy")) {
                        objectList.Add(GetEnemy(words[1], int.Parse(words[2]), int.Parse(words[3])));
                    }
                    else if (words[0].Equals("Block"))
                    {
                        objectList.Add(GetBlock(words[1], int.Parse(words[2])));
                    }
                    else if (words[0].Equals("Item"))
                    {
                        objectList.Add(GetItem(words[1], new Vector2(int.Parse(words[2]), int.Parse(words[3])), bool.Parse(words[4])));
                    }
                    else if (words[0].Equals("Door"))
                    {
                        objectList.Add(GetDoor(words[1], int.Parse(words[2])));
                    }

                }
            }

            return objectList;
        }

        private IEnemy GetEnemy(String Enemy, int x, int y) {
            IEnemy enemy = null;
            if (Enemy.Equals("Aquamentus"))
            {
                enemy = new Aquamentus(x,y);
            }
            else if (Enemy.Equals("Dodongo"))
            {
                enemy = new Dodongo(x, y);
            }
            else if (Enemy.Equals("Gel"))
            {
                enemy = new Gel(x, y);
            }
            else if (Enemy.Equals("Goriya"))
            {
                enemy = new Goriya(x, y);
            }
            else if (Enemy.Equals("Hand"))
            {
                enemy = new Hand(x, y);
            }
            else if (Enemy.Equals("Keese"))
            {
                enemy = new Keese(x, y);
            }
            else if (Enemy.Equals("Rope"))
            {
                enemy = new Rope(x, y);
            }
            else if (Enemy.Equals("SpikeTrap"))
            {
                enemy = new SpikeTrap(x, y);
            }
            else if (Enemy.Equals("Stalfos"))
            {
                enemy = new Stalfos(x, y);
            }
            else if (Enemy.Equals("Zol"))
            {
                enemy = new Zol(x, y);
            }
            return enemy;
        }

        private IBlock GetBlock(String Block, int position)
        {
            IBlock block = null;
            if (Block.Equals("BlackBlock"))
            {
                block = new BlackBlock(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("BlueTile"))
            {
                block = new BlueTile(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("DotTile"))
            {
                block = new DotTile(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("PlainTile"))
            {
                block = new PlainTile(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("SideChunk"))
            {
                block = new SideChunk(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("StaircaseTile"))
            {
                block = new StaircaseTile(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("UpChunk"))
            {
                block = new UpChunk(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("WhiteBrick"))
            {
                block = new WhiteBrick(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("WhiteStaircase"))
            {
                block = new WhiteStair(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("DiamondTile"))
            {
                block = new DiamondTile(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("FireBlock"))
            {
                block = new FireBlock(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("BlackFloor"))
            {
                block = new BlackFloor(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("OldMan"))
            {
                block = new OldMan(Globals.FloorGrid[position]);
            }
            return block;
        }

        private IItem GetItem(String Item, Vector2 position, bool spawned)
        {
            IItem item = null;
            if (Item.Equals("Arrow"))
            {
                item = new Arrow(position, spawned);
            }
            else if (Item.Equals("BlueCandle"))
            {
                item = new BlueCandle(position, spawned);
            }
            else if (Item.Equals("BluePotion"))
            {
                item = new BluePotion(position, spawned);
            }
            else if (Item.Equals("Bomb"))
            {
                item = new Bomb(position, spawned);
            }
            else if (Item.Equals("Boomerang"))
            {
                item = new BoomerangItem(position, spawned);
            }
            else if (Item.Equals("Bow"))
            {
                item = new Bow(position, spawned);
            }
            else if (Item.Equals("Clock"))
            {
                item = new Clock(position, spawned);
            }
            else if (Item.Equals("Compass"))
            {
                item = new Compass(position, spawned);
            }
            else if (Item.Equals("Fairy"))
            {
                item = new Fairy(position, spawned);
            }
            else if (Item.Equals("HeartContainer"))
            {
                item = new HeartContainer(position, spawned);
            }
            else if (Item.Equals("Heart"))
            {
                item = new Heart(position, spawned);
            }
            else if (Item.Equals("Key"))
            {
                item = new Key(position, spawned);
            }
            else if (Item.Equals("Map"))
            {
                item = new Map(position, spawned);
            }
            else if (Item.Equals("Rupee"))
            {
                item = new Rupee(position, spawned);
            }
            else if (Item.Equals("Triforce"))
            {
                item = new TriforcePiece(position, spawned);
            }
            return item;
        }

        private IDoor GetDoor(String Door, int state) {
            IDoor door = null;
            if (Door.Equals("North"))
            {
                door = new NorthDoor(state);
            }
            else if (Door.Equals("South"))
            {
                door = new SouthDoor(state);
            }
            else if (Door.Equals("East"))
            {
                door = new EastDoor(state);
            }
            else if (Door.Equals("West"))
            {
                door = new WestDoor(state);
            }
            return door;
        }
    }
}
