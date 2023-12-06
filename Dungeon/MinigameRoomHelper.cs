using Sprint2_Attempt3.Enemy.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon
{
    internal class MinigameRoomHelper
    {
        private List<IGameObject>[] gameObjectLists;
        private int roomNumber;
        public MinigameRoomHelper(List<IGameObject>[] gameObjectLists, int roomNumber)
        {
            this.roomNumber = roomNumber;
            this.gameObjectLists = gameObjectLists;
        }
        public void startGame() { 
            Target targetTopRight1 = new Target(105, 275, true);
            Target targetTopRight2 = new Target(190, 275, true);
            Target targetTopRight3 = new Target(280, 275, true);
            Target targetTopRight4 = new Target(370, 275, true);
            Target targetTopRight5 = new Target(460, 275, true);
            Target targetTopRight6 = new Target(550, 275, true);
            Target targetMiddleLeft1 = new Target(155, 340, false);
            Target targetMiddleLeft2 = new Target(245, 340, false);
            Target targetMiddleLeft3 = new Target(335, 340, false);
            Target targetMiddleLeft4 = new Target(425, 340, false);
            Target targetMiddleLeft5 = new Target(515, 340, false);
            Target targetMiddleLeft6 = new Target(605, 340, false);
            Target targetLowerRight1 = new Target(105, 405, true);
            Target targetLowerRight2 = new Target(190, 405, true);
            Target targetLowerRight3 = new Target(280, 405, true);
            Target targetLowerRight4 = new Target(370, 405, true);
            Target targetLowerRight5 = new Target(460, 405, true);
            Target targetLowerRight6 = new Target(550, 405, true);

            gameObjectLists[roomNumber].Add(targetTopRight1);
            gameObjectLists[roomNumber].Add(targetTopRight2);
            gameObjectLists[roomNumber].Add(targetTopRight3);
            gameObjectLists[roomNumber].Add(targetTopRight4);
            gameObjectLists[roomNumber].Add(targetTopRight5);
            gameObjectLists[roomNumber].Add(targetTopRight6);
            gameObjectLists[roomNumber].Add(targetMiddleLeft1);
            gameObjectLists[roomNumber].Add(targetMiddleLeft2);
            gameObjectLists[roomNumber].Add(targetMiddleLeft3);
            gameObjectLists[roomNumber].Add(targetMiddleLeft4);
            gameObjectLists[roomNumber].Add(targetMiddleLeft5);
            gameObjectLists[roomNumber].Add(targetMiddleLeft6);
            gameObjectLists[roomNumber].Add(targetLowerRight1);
            gameObjectLists[roomNumber].Add(targetLowerRight2);
            gameObjectLists[roomNumber].Add(targetLowerRight3);
            gameObjectLists[roomNumber].Add(targetLowerRight4);
            gameObjectLists[roomNumber].Add(targetLowerRight5);
            gameObjectLists[roomNumber].Add(targetLowerRight6);
        }
    }

}
