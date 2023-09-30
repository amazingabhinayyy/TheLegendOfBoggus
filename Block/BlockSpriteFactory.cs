using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Block
{
    internal class BlockSpriteFactory
    {
        private static Texture2D BlockTexture;

        private static BlockSpriteFactory instance = new BlockSpriteFactory();

        public static BlockSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }
        public BlockSpriteFactory()
        {

        }

        public void LoadAllTextures(ContentManager content)
        {
            BlockTexture = content.Load<Texture2D>("BlockSprites");
        }
        //Spawn and animation sprites
        public BlockSprite CreateBlockSprite()
        {
            return new BlockSprite(BlockTexture);
        }
    }
}

