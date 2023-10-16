using Microsoft.Xna.Framework.Graphics;
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
using System;
using System.Collections.Generic;
using System.IO;

namespace Sprint2_Attempt3.Dungeon
{
    internal class RoomGenerator
    {

        private static RoomGenerator instance = new RoomGenerator();

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

        private List<IGameObject> LoadFile(string fileName) {
            List<IGameObject> objectList = new List<IGameObject>();
            
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream) { 
                var line = sr.ReadLine();
                if (line != null)
                {
                    var words = line.Split(";");
                    if (words[0].Equals("Enemy")) {
                        objectList.Add(GetEnemy(words[1], int.Parse(words[2]), int.Parse(words[3])));
                    }
                    else if (words[0].Equals("Block"))
                    {
                    }
                    else if (words[0].Equals("Item"))
                    {
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

        public List<IGameObject> GenerateRoom1() {
            return LoadFile("Room1File.csv");
        }
        public List<IGameObject> GenerateRoom2()
        {
            return LoadFile("Room2File.csv");
        }
        public List<IGameObject> GenerateRoom3()
        {
            return LoadFile("Room3File.csv");
        }
        public List<IGameObject> GenerateRoom4()
        {
            return LoadFile("Room4File.csv");
        }
        public List<IGameObject> GenerateRoom5()
        {
            return LoadFile("Room5File.csv");
        }
        public List<IGameObject> GenerateRoom6()
        {
            return LoadFile("Room6File.csv");
        }
        public List<IGameObject> GenerateRoom7()
        {
            return LoadFile("Room7File.csv");
        }
        public List<IGameObject> GenerateRoom8()
        {
            return LoadFile("Room8File.csv");
        }
        public List<IGameObject> GenerateRoom9()
        {
            return LoadFile("Room9File.csv");
        }
        public List<IGameObject> GenerateRoom10()
        {
            return LoadFile("Room9File.csv");
        }
        public List<IGameObject> GenerateRoom11()
        {
            return LoadFile("Room11File.csv");
        }
        public List<IGameObject> GenerateRoom12()
        {
            return LoadFile("Room12File.csv");
        }
        public List<IGameObject> GenerateRoom13()
        {
            return LoadFile("Room13File.csv");
        }
        public List<IGameObject> GenerateRoom14()
        {
            return LoadFile("Room14File.csv");
        }
        public List<IGameObject> GenerateRoom15()
        {
            return LoadFile("Room15File.csv");
        }
        public List<IGameObject> GenerateRoom16()
        {
            return LoadFile("Room16File.csv");
        }
        public List<IGameObject> GenerateRoom17()
        {
            return LoadFile("Room17File.csv");
        }
        public List<IGameObject> GenerateRoom18()
        {
            return LoadFile("Room18File.csv");
        }
    }
}
