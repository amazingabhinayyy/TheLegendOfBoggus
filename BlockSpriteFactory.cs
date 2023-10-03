using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
//using System.Numerics;

namespace Sprint2
{
    public class BlockSpriteFactory
    {
        private static Texture2D tilesSet;
        private static Vector2 diamondPos;
        private static Vector2 plainPos;
        private static Vector2 upChunkPos;
        private static Vector2 sideChunkPos;
        private static Vector2 whiteStairPos;
        private static Vector2 whiteBrickPos;
        private static Vector2 StartPosition;

        private static BlockSpriteFactory instance = new BlockSpriteFactory();

        public static BlockSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        private BlockSpriteFactory()
        {
            StartPosition = new Vector2(125, 125);
            plainPos = diamondPos = upChunkPos = sideChunkPos = whiteStairPos=whiteBrickPos=StartPosition;

        }

        public void LoadAllTextures(ContentManager content)
        {
            tilesSet = content.Load<Texture2D>("blocks");

        }

        public static Rectangle plainScr = new Rectangle(0, 0, 16, 16);
        public static Rectangle diamondScr = new Rectangle(17, 0, 16, 16);
        public static Rectangle upChunkScr = new Rectangle(34, 0, 16, 16);
        public static Rectangle sideChunkScr = new Rectangle(51, 0, 16, 16);
        public static Rectangle whiteStairScr = new Rectangle(17, 34, 16, 16);
        public static Rectangle whiteBrickScr = new Rectangle(0, 34, 16, 16);

        public IBlockSprite CreatePlainTile()
        {
            return new PlainTile(tilesSet, plainPos, plainScr);
        }

        public IBlockSprite CreateDiamondTile()
        {
            return new DiamondTile(tilesSet, diamondPos, diamondScr);
        }

        public IBlockSprite CreateUpChunk()
        {
            return new UpChunk(tilesSet, upChunkPos, upChunkScr);
        }
        public IBlockSprite CreateSideChunk()
        {
            return new SideChunk(tilesSet, sideChunkPos, sideChunkScr);
        }
        public IBlockSprite CreateWhiteBrick()
        {
            return new SideChunk(tilesSet, whiteBrickPos, whiteBrickScr);
        }
        public IBlockSprite CreateWhiteStair()
        {
            return new SideChunk(tilesSet, whiteStairPos, whiteStairScr);
        }
    }
}