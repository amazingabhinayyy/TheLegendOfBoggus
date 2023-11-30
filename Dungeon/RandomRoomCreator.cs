using Sprint2_Attempt3.Enemy.Gel;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon
{
    public class RandomRoomCreator
    {
        private static RandomRoomCreator instance = new RandomRoomCreator();
        private static int currentRoomNumber;
        private readonly String[] diagonalLine = { "Block,BlueTile,1", "Block,BlueTile,2", "Block,BlueTile,3", "Block,BlueTile,15", "Block,BlueTile,16", "Block,BlueTile,17", "Block,BlueTile,29", "Block,BlueTile,30", "Block,BlueTile,42", "Block,BlueTile,43", "Block,BlueTile,55", "Block,BlueTile,56", "Block,BlueTile,68", "Block,BlueTile,69", "Block,BlueTile,70", "Block,BlueTile,82", "Block,BlueTile,83", "Block,BlueTile,84" };
        private readonly String[] fourBlocksInTopCorner = { "Block,DiamondTile,14", "Block,DiamondTile,62", "Block,DiamondTile,23", "Block,DiamondTile,71" };
        private readonly String[] fourBlocksInTopMiddleCorner = { "Block,DiamondTile,27", "Block,DiamondTile,34", "Block,DiamondTile,51", "Block,DiamondTile,58" };
        //private readonly String[] 
        private readonly int[] noSpawnAreas = { 6, 7, 37, 48, 78, 79 };

        public static RandomRoomCreator Instance
        {
            get
            {
                return instance;
            }
        }
        public RandomRoomCreator() 
        {
            currentRoomNumber = 0;
        }

        public int CreateRandomRoom()
        {
            currentRoomNumber++;
            String fileName = "Dungeon/RoomFiles/RandomRoom" + currentRoomNumber + ".csv";

            File.WriteAllText(fileName, "");
            //File.AppendAllText(fileName, "Block,BlueTile,43,,\n");
            File.AppendAllText(fileName, "Door,East,0\n");
            File.AppendAllText(fileName, "Door,North,0\n");
            File.AppendAllText(fileName, "Door,West,0\n");
            File.AppendAllText(fileName, "Door,South,0\n");

            String[] objectPlacements = CreateObjectsInRoom();

            for(int i = 0; i < 84; i++)
            {
                if (objectPlacements[i] != null)
                {
                    File.AppendAllText(fileName, objectPlacements[i] + "\n");
                }
            }
            /*
            for(int i = 0; i < diagonalLine.Length; i++)
            {
                File.AppendAllText(fileName, diagonalLine[i] + "\n");
            }
            */
            RoomGenerator.Instance.LoadNewFile(fileName);
            //RoomGenerator.Instance.LoadFile(currentRoomNumber + 18 - 1);

            return currentRoomNumber + 18 - 1;
        }

        public String[] CreateObjectsInRoom()
        {
            String[] objectPlacement = new String[84];

            int randDiffAmountEnemies = new Random().Next(1, 4);
            int randDiffAmountBlock = new Random().Next(0, 3);
            String enemyCSV = "";
            
            for (int i = 0; i < 2; i++)
            {
                int randBlockPresets = new Random().Next(0, 3);
                String[] roomPreset;
                if (randBlockPresets == 0)
                    roomPreset = diagonalLine;
                else if (randBlockPresets == 1)
                    roomPreset = fourBlocksInTopCorner;
                else
                    roomPreset = fourBlocksInTopMiddleCorner;

                for (int c = 0; c < roomPreset.Length; c++)
                {
                    //Gets to integer position stated in the string
                    int value = roomPreset[c].LastIndexOf(',') + 1;
                    int blockPosition = int.Parse(roomPreset[c].Substring(roomPreset[c].LastIndexOf(',') + 1)) - 1;
                    objectPlacement[blockPosition] = roomPreset[c] + ",,";
                }
               
            }
            for (int i = 0; i < randDiffAmountEnemies; i++)
            {
                int randEnemies = new Random().Next(0, 7);
                int randAmountEnemies = new Random().Next(1, 4);

                if (randEnemies == 0)
                    enemyCSV = "Enemy,Zol,";
                else if (randEnemies == 1)
                    enemyCSV = "Enemy,Keese,";
                else if (randEnemies == 2)
                    enemyCSV = "Enemy,Gel,";
                else if (randEnemies == 3)
                    enemyCSV = "Enemy,Rope,";
                else if (randEnemies == 4)
                    enemyCSV = "Enemy,Goriya,";
                else if (randEnemies == 5)
                    enemyCSV = "Enemy,Stalfos,";
                else if (randEnemies == 6)
                {
                    enemyCSV = "Enemy,Dodongo,";
                    randAmountEnemies = 1;
                }
                for (int c = 0; c < randAmountEnemies; c++)
                {
                    int randPositionEnemy;
                    do
                    {
                        randPositionEnemy = new Random().Next(0, 84);
                        
                    }
                    while (noSpawnAreas.Contains(randPositionEnemy) || objectPlacement[randPositionEnemy] != null);

                    objectPlacement[randPositionEnemy] = enemyCSV + (randPositionEnemy + 1) + ",,";
                }
            }

            return objectPlacement;
        }
    }
}
