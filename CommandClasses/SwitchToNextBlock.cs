using Sprint2_Attempt3.Blocks;

namespace Sprint2_Attempt3.CommandClasses
{
    internal class SwitchToNextBlock : ICommand
    {
        private Game1 game1;
        private Block block;
        private int blockIndex;
        public SwitchToNextBlock(Game1 game)
        {
            this.game1 = game;

        }

        public void Execute()
        {
            /*
            * TODO:
            * call switch to next item method
            */
            if (game1.blockIndex <= 9)
            {
                game1.blockIndex++;
            }


            switch (game1.blockIndex)
            {
                case 0:
                    game1.block.ChangeToPlainTile();
                    break;
                case 1:
                    game1.block.ChangeToDiamondTile();
                    break;
                case 2:
                    game1.block.ChangeToSideChunk();
                    break;
                case 3:
                    game1.block.ChangeToUpChunk();
                    break;
                case 4:
                    game1.block.ChangeToWhiteBrick();
                    break;
                case 5:
                    game1.block.ChangeToWhiteStairs();
                    break;
                case 6:
                    game1.block.ChangeToStaircaseTileChunk();
                    break;
                case 7:
                    game1.block.ChangeToBlueTileChunk();
                    break;

                case 8:
                    game1.block.ChangeToBlackBlock();
                    break;
                case 9:
                    game1.block.ChangeToDotTile();
                    break;
            }
        }

    }
}
