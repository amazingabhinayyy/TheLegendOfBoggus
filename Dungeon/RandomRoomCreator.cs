using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Blocks.BlockSprites;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Enemy.Gel;
using Sprint2_Attempt3.Items.ItemClasses;
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
        private RandomRoomSpriteCreator randRoomSpriteCreator = new RandomRoomSpriteCreator();

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

        public int CreateRandomRoom(IRoom[,] map, int currentX, int currentY)
        {
            currentRoomNumber++;
            String fileName = "Dungeon/RoomFiles/RandomRoom" + currentRoomNumber + ".csv";
            File.WriteAllText(fileName, "");
            //File.AppendAllText(fileName, "Block,BlueTile,43,,\n");
            /*
            File.AppendAllText(fileName, "Door,East,0\n");
            File.AppendAllText(fileName, "Door,North,0\n");
            File.AppendAllText(fileName, "Door,West,0\n");
            File.AppendAllText(fileName, "Door,South,0\n");
            */

            String[] objectPlacements = CreateObjectsInRoom();
            //String[] doors = randRoomSpriteCreator.ConnectAndMakeDoors(map, currentX, currentY);

            for(int i = 0; i < objectPlacements.Length; i++)
            {
                if (objectPlacements[i] != null)
                {
                    File.AppendAllText(fileName, objectPlacements[i] + "\n");
                }
            }

            if (currentX != map.GetLength(1) - 1)
                File.AppendAllText(fileName, randRoomSpriteCreator.CheckIfDoorExist(typeof(WestDoor), map[currentX + 1, currentY]));
            else
                File.AppendAllText(fileName, "Door,East,4\n");
            if(currentX != 0)
                File.AppendAllText(fileName, randRoomSpriteCreator.CheckIfDoorExist(typeof(EastDoor), map[currentX - 1, currentY]));
            else
                File.AppendAllText(fileName, "Door,West,4\n");
            if(currentY != 0)
                File.AppendAllText(fileName, randRoomSpriteCreator.CheckIfDoorExist(typeof(SouthDoor), map[currentX, currentY - 1]));
            else
                File.AppendAllText(fileName, "Door,North,4\n");
            if (currentY != map.GetLength(0) - 1)
                File.AppendAllText(fileName, randRoomSpriteCreator.CheckIfDoorExist(typeof(NorthDoor), map[currentX, currentY + 1]));
            else
                File.AppendAllText(fileName, "Door,South,4\n");

            RoomGenerator.Instance.LoadNewFile(fileName);
            //map[currentX, currentY].gameObjectList = RoomGenerator.Instance.LoadFile(18);

            return currentRoomNumber + 18 - 1;
        }

        public String[] CreateObjectsInRoom()
        {
            String[] objectPlacement = randRoomSpriteCreator.CreateRandomRoomPreset();
            objectPlacement = randRoomSpriteCreator.CreateRandomEnemies(objectPlacement);
            
            return objectPlacement;
        }
    }
}
