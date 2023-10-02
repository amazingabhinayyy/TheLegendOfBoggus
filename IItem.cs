using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3
{
    public interface IItem
    {
        public void ChangeToRupee();
        public void ChangeToBomb();
        public void ChangeToClock();
        public void ChangeToCompass();
        public void ChangeToHeart();
        public void ChangeToBoomerang();
        public void ChangeToFairy();
        public void ChangeToMap();
        public void ChangeToKey();
        public void ChangeToHeartContainer();
        public void ChangeToTriforcePiece();
        public void ChangeToBow();
        public void ChangeToArrow();
        public void ChangeToBlueCandle();
        public void ChangeToBluePotion();
        public void Update();
    }
}
