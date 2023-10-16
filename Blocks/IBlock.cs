using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Blocks
{
    public interface IBlock //: IGameObject
    {
        public void ChangeToPlainTile();
        public void ChangeToDiamondTile();
        public void ChangeToSideChunk();
        public void ChangeToUpChunk();
        public void ChangeToStaircaseTileChunk();
        public void ChangeToBlueTileChunk();
        public void ChangeToWhiteBrick();
        public void ChangeToWhiteStairs();
        public void ChangeToBlackBlock();
        public void ChangeToDotTile();

        public void Update();

        public void Draw(SpriteBatch spriteBatch);

    }
}




