using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon
{
    public class RandomRoomCreator
    {
        private static RandomRoomCreator instance = new RandomRoomCreator();
        private static int currentRoomNumber;

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

        public int CreateRandomRoom()//IGameObject obj)
        {
            currentRoomNumber++;
            String fileName = "Dungeon/RoomFiles/RandomRoom" + currentRoomNumber + ".csv";
            /*
            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                streamWriter.WriteLine("Block,DiamondTile,43,,");
                streamWriter.WriteLine("Door,East,0");
            }
            */
            File.WriteAllText(fileName, "");
            File.AppendAllText(fileName, "Block,DiamondTile,43,,\n");
            File.AppendAllText(fileName, "Door,East,0\n");
            File.AppendAllText(fileName, "Door,North,0\n");
            File.AppendAllText(fileName, "Door,West,0\n");

            RoomGenerator.Instance.LoadNewFile(fileName);
            //RoomGenerator.Instance.LoadFile(currentRoomNumber + 18 - 1);

            return currentRoomNumber + 18 - 1;
        }
    }
}
