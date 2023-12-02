using Sprint2_Attempt3.Blocks.BlockSprites;
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
        private readonly string[] preset1 = { "Block,BlueTile,1", "Block,BlueTile,2", "Block,BlueTile,3", "Block,BlueTile,15", "Block,BlueTile,16", "Block,BlueTile,17", "Block,BlueTile,29", "Block,BlueTile,30", "Block,BlueTile,42", "Block,BlueTile,43", "Block,BlueTile,55", "Block,BlueTile,56", "Block,BlueTile,68", "Block,BlueTile,69", "Block,BlueTile,70", "Block,BlueTile,82", "Block,BlueTile,83", "Block,BlueTile,84" };
        private readonly string[] normalPreset1 = { "Block,DiamondTile,14", "Block,DiamondTile,62", "Block,DiamondTile,23", "Block,DiamondTile,71" };
        private readonly string[] preset3 = { "Block,DiamondTile,27", "Block,DiamondTile,34", "Block,DiamondTile,51", "Block,DiamondTile,58" };
        private readonly string[] preset4 = { "Block,MovingBlock,45", "Block,DiamondTile,19", "Block,DiamondTile,32", "Block,DiamondTile,56", "Block,DiamondTile,67", "Block,DiamondTile,54", "Block,DiamondTile,41", "Block,DiamondTile,30", "Item,Rupee,43" };
        private readonly string[] normalPreset2 = { "Block,DiamondTile,30", "Block,DiamondTile,31", "Block,DiamondTile,42", "Block,DiamondTile,43", "Block,DiamondTile,54", "Block,DiamondTile,55", };
        private readonly string[] preset6 = { "Block,DiamondTile,3", "Block,DiamondTile,14", "Block,DiamondTile,18", "Block,DiamondTile,29", "Block,DiamondTile,40", "Block,DiamondTile,51", "Block,DiamondTile,62", "Block,DiamondTile,73", "Block,DiamondTile,12", "Block,DiamondTile,23", "Block,DiamondTile,34", "Block,DiamondTile,45", "Block,DiamondTile,56", "Block,DiamondTile,67", "Block,DiamondTile,82", "Block,DiamondTile,71" };
        private readonly string[] preset7 = { "Item,Rupee,18", "Item,Rupee,19", "Item,Rupee,29", "Item,Rupee,40", "Item,Rupee,53", "Item,Rupee,66", "Item,Rupee,67", "Item,Rupee,56", "Item,Rupee,45", "Item,Rupee,32", "Item,Rupee,30", "Item,Rupee,31", "Item,Rupee,41", "Item,Rupee,42", "Item,Rupee,43", "Item,Rupee,44", "Item,Rupee,54", "Item,Rupee,55" };
        private readonly string[] normalPreset3 = { "Block,DiamondTile,17", "Block,DiamondTile,20", "Block,DiamondTile,46", "Block,DiamondTile,68", "Block,DiamondTile,65", "Block,DiamondTile,39" };
        private readonly string[] normalPreset4 = { "Block,DiamondTile,14", "Block,DiamondTile,15", "Block,DiamondTile,22", "Block,DiamondTile,23", "Block,DiamondTile,42", "Block,DiamondTile,43", "Block,DiamondTile,62", "Block,DiamondTile,63", "Block,DiamondTile,70", "Block,DiamondTile,71" };
        private readonly string[] preset10 = { "Block,BlueTile,1", "Block,BlueTile,2", "Block,BlueTile,3", "Block,BlueTile,13", "Block,BlueTile,14", "Block,BlueTile,26", "Block,BlueTile,38", "Block,BlueTile,50", "Block,BlueTile,61", "Block,BlueTile,62", "Block,BlueTile,73", "Block,BlueTile,74", "Block,BlueTile,63", "Block,BlueTile,64", "Block,BlueTile,75", "Block,BlueTile,76", "Block,BlueTile,17", "Block,BlueTile,28", "Block,BlueTile,29", "Block,BlueTile,40", "Block,BlueTile,41", "Block,BlueTile,20", "Block,BlueTile,32", "Block,BlueTile,33", "Block,BlueTile,44", "Block,BlueTile,45", "Block,BlueTile,54", "Block,BlueTile,55", "Block,BlueTile,10", "Block,BlueTile,11", "Block,BlueTile,12", "Block,BlueTile,23", "Block,BlueTile,24", "Block,BlueTile,35", "Block,BlueTile,47", "Block,BlueTile,59", "Block,BlueTile,69", "Block,BlueTile,70", "Block,BlueTile,71", "Block,BlueTile,72", "Block,BlueTile,81", "Block,BlueTile,82", "Block,BlueTile,83", "Block,BlueTile,84" };
        private readonly string[] normalPreset5 = { "Block,DiamondTile,41", "Block,DiamondTile,44" };
        private readonly string[] normalPreset6 = { "Block,DiamondTile,38", "Block,DiamondTile,47", "Block,DiamondTile,64", "Block,DiamondTile,69" };
        private readonly string[] normalPreset7 = { "Block,DiamondTile,27", "Block,DiamondTile,38", "Block,DiamondTile,51", "Block,DiamondTile,34", "Block,DiamondTile,47", "Block,DiamondTile,58" };
        private readonly string[][] normalRoomPresetList;
        private readonly string[][] specialRoomPresetList;
        private readonly int[] noSpawnAreas = { 6, 7, 25, 36, 37, 38, 47, 48, 49, 60, 78, 79 };
        public RandomRoomSpriteCreator() 
        {
            normalRoomPresetList =  new string[][]{normalPreset1, normalPreset2, normalPreset3, normalPreset4, normalPreset5, normalPreset6, normalPreset7, new string[] { } };
            specialRoomPresetList = new string[][] { preset1, preset3, preset4, preset6, preset7, preset10 };

        }

        public string[] CreateRandomRoomPreset()
        {
            string[] objectPlacement = new string[84];

            int randDiffAmountBlock = new Random().Next(1, 4);
            bool spawnSpecialRoom = new Random().Next(0, 8) == 4;

            string[] roomPreset;

            if(spawnSpecialRoom)
            {
                int randBlockPresets = new Random().Next(0, specialRoomPresetList.Length);
                roomPreset = specialRoomPresetList[randBlockPresets];
                randDiffAmountBlock = 1;
            }
            else
            {
                int randBlockPresets = new Random().Next(0, normalRoomPresetList.Length);
                roomPreset = normalRoomPresetList[randBlockPresets];
            }
            for (int i = 0; i < randDiffAmountBlock; i++)
            {
                for (int c = 0; c < roomPreset.Length; c++)
                {
                    //Gets to integer position stated in the string and turns it into a integer
                    int value = roomPreset[c].LastIndexOf(',') + 1;
                    int blockPosition = int.Parse(roomPreset[c].Substring(roomPreset[c].LastIndexOf(',') + 1)) - 1;
                    objectPlacement[blockPosition] = roomPreset[c] + ",,";
                    if (roomPreset[c].Substring(0, roomPreset[c].IndexOf(",")).Equals("Item"))
                        objectPlacement[blockPosition] += "TRUE";
                }
                int randBlockPresets = new Random().Next(0, normalRoomPresetList.Length);
                roomPreset = normalRoomPresetList[randBlockPresets];
            }
            return objectPlacement;
        }

        public string[] CreateRandomEnemies(string[] objectPlacement)
        {
            int randDiffAmountEnemies = new Random().Next(2, 4);
            string enemyCSV = "";

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
        
        public string[] ConnectAndMakeDoors(IRoom[,] map, int currentX, int currentY)
        {
            string[] doors = new string[4];

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
