using Sprint2_Attempt3.Dungeon.Doors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon
{
    public class RandomRoomSpriteCreator
    {
        private readonly String[] diagonalLine = { "Block,BlueTile,1", "Block,BlueTile,2", "Block,BlueTile,3", "Block,BlueTile,15", "Block,BlueTile,16", "Block,BlueTile,17", "Block,BlueTile,29", "Block,BlueTile,30", "Block,BlueTile,42", "Block,BlueTile,43", "Block,BlueTile,55", "Block,BlueTile,56", "Block,BlueTile,68", "Block,BlueTile,69", "Block,BlueTile,70", "Block,BlueTile,82", "Block,BlueTile,83", "Block,BlueTile,84" };
        private readonly String[] fourBlocksInTopCorner = { "Block,DiamondTile,14", "Block,DiamondTile,62", "Block,DiamondTile,23", "Block,DiamondTile,71" };
        private readonly String[] fourBlocksInTopMiddleCorner = { "Block,DiamondTile,27", "Block,DiamondTile,34", "Block,DiamondTile,51", "Block,DiamondTile,58" };
        private readonly String[] middleDiamond = { "Block,MovingBlock,45", "Block,DiamondTile,19", "Block,DiamondTile,32", "Block,DiamondTile,56", "Block,DiamondTile,67", "Block,DiamondTile,54", "Block,DiamondTile,41", "Block,DiamondTile,30", "Item,Rupee,43" };
        private readonly String[] sixBlocksInMiddle = { "Block,DiamondTile,30", "Block,DiamondTile,31", "Block,DiamondTile,42", "Block,DiamondTile,43", "Block,DiamondTile,54", "Block,DiamondTile,55", };
        private readonly String[] fourDiagonalBlocks = { "Block,DiamondTile,3", "Block,DiamondTile,14", "Block,DiamondTile,18", "Block,DiamondTile,29", "Block,DiamondTile,40", "Block,DiamondTile,51", "Block,DiamondTile,62", "Block,DiamondTile,73", "Block,DiamondTile,12", "Block,DiamondTile,23", "Block,DiamondTile,34", "Block,DiamondTile,45", "Block,DiamondTile,56", "Block,DiamondTile,67", "Block,DiamondTile,82", "Block,DiamondTile,71" };
        private readonly String[] rupeeDiamond = { "Item,Rupee,18", "Item,Rupee,19", "Item,Rupee,29", "Item,Rupee,40", "Item,Rupee,53", "Item,Rupee,66", "Item,Rupee,67", "Item,Rupee,56", "Item,Rupee,45", "Item,Rupee,32", "Item,Rupee,30", "Item,Rupee,31", "Item,Rupee,41", "Item,Rupee,42", "Item,Rupee,43", "Item,Rupee,44", "Item,Rupee,54", "Item,Rupee,55" };
        private readonly String[] hexagonShape = { "Block,DiamondTile,17", "Block,DiamondTile,20", "Block,DiamondTile,46", "Block,DiamondTile,68", "Block,DiamondTile,65", "Block,DiamondTile,39" };
        private readonly int[] noSpawnAreas = { 6, 7, 37, 48, 78, 79 };
        public RandomRoomSpriteCreator() { }

        public String[] CreateRandomRoomPreset()
        {
            String[] objectPlacement = new String[84];

            int randDiffAmountBlock = new Random().Next(0, 3);

            for (int i = 0; i < 1; i++)
            {
                int randBlockPresets = new Random().Next(0, 7);
                String[] roomPreset;
                if (randBlockPresets == 0)
                    roomPreset = diagonalLine;
                else if (randBlockPresets == 1)
                    roomPreset = fourBlocksInTopCorner;
                else if (randBlockPresets == 2)
                    roomPreset = fourBlocksInTopMiddleCorner;
                else if (randBlockPresets == 3)
                    roomPreset = middleDiamond;
                else if (randBlockPresets == 4)
                    roomPreset = sixBlocksInMiddle;
                else if (randBlockPresets == 5)
                    roomPreset = fourDiagonalBlocks;
                else
                    roomPreset = rupeeDiamond;

                for (int c = 0; c < roomPreset.Length; c++)
                {
                    //Gets to integer position stated in the string and turns it into a integer
                    int value = roomPreset[c].LastIndexOf(',') + 1;
                    int blockPosition = int.Parse(roomPreset[c].Substring(roomPreset[c].LastIndexOf(',') + 1)) - 1;
                    objectPlacement[blockPosition] = roomPreset[c] + ",,";
                    if (roomPreset[c].Substring(0, roomPreset[c].IndexOf(",")).Equals("Item"))
                        objectPlacement[blockPosition] += "TRUE";
                }

            }

            return objectPlacement;
        }

        public String[] CreateRandomEnemies(String[] objectPlacement)
        {
            int randDiffAmountEnemies = new Random().Next(1, 4);
            String enemyCSV = "";

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
                    while (noSpawnAreas.Contains(randPositionEnemy + 1) || objectPlacement[randPositionEnemy] != null);

                    objectPlacement[randPositionEnemy] = enemyCSV + (randPositionEnemy + 1) + ",,";
                }
            }

            return objectPlacement;
        }
        
        public String[] ConnectAndMakeDoors(IRoom[,] map, int currentX, int currentY)
        {
            String[] doors = new String[4];

            if (currentX != map.GetLength(1) - 1)
            {
                if (map[currentX + 1, currentY] != null)
                {
                    foreach (IGameObject obj in map[currentX + 1, currentY].gameObjectList)
                    {
                        if (obj is WestDoor && ((WestDoor)obj).DoorExists)
                        {
                            doors[0] = "Door,East,0";
                        }
                    }
                }
                else
                {
                    int randNum = new Random().Next(0, 2);
                    if (randNum == 0)
                        doors[0] = "Door,East,0";
                }
            }
            if (currentX != 0)
            {
                if (map[currentX - 1, currentY] != null)
                {
                    foreach (IGameObject obj in map[currentX - 1, currentY].gameObjectList)
                    {
                        if (obj is EastDoor && ((EastDoor)obj).DoorExists)
                        {
                            doors[1] = "Door,West,0";
                        }
                    }
                }
                else
                {
                    int randNum = new Random().Next(0, 2);
                    if (randNum == 0)
                        doors[1] = "Door,West,0";
                }
            }
            if (currentY != map.GetLength(0) - 1)
            {
                if (map[currentX, currentY + 1] != null)
                {
                    foreach (IGameObject obj in map[currentX, currentY + 1].gameObjectList)
                    {
                        if (obj is NorthDoor && ((NorthDoor)obj).DoorExists)
                        {
                            doors[2] = "Door,South,0";
                        }
                    }
                }
                else
                {
                    int randNum = new Random().Next(0, 2);
                    if (randNum == 0)
                        doors[2] = "Door,South,0";
                }
            }
            if (currentY != 0)
            {
                if (map[currentX, currentY - 1] != null)
                {
                    foreach (IGameObject obj in map[currentX, currentY - 1].gameObjectList)
                    {
                        if (obj is SouthDoor && ((SouthDoor)obj).DoorExists)
                        {
                            doors[3] = "Door,North,0";
                        }
                    }
                }
                else
                {
                    int randNum = new Random().Next(0, 2);
                    if (randNum == 0)
                        doors[3] = "Door,North,0";
                }
            }
            return doors; 
        }      
    }
}
