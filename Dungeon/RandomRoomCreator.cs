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
            currentRoomNumber = 1;
        }

        public int CreateRandomRoom()//IGameObject obj)
        {
            String fileName = "Dungeon/RoomFiles/RandomRoom.csv";
            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                streamWriter.WriteLine("Block,DiamondTile,43,,");
            }

            RoomGenerator.Instance.LoadNewFile(fileName);
            //RoomGenerator.Instance.LoadFile(currentRoomNumber + 18 - 1);

            return currentRoomNumber + 18 - 1;
        }
    }
}
