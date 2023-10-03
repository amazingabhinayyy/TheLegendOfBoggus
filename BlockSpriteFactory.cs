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
        private static Texture2D blocks;
        private static Vector2 diamondPos;
        private static Vector2 plainPos;
        private static Vector2 upChunkPos;
        private static Vector2 sideChunkPos;
        private static Vector2 StartPosition;
        private static Vector2 blackBlockPos;
        private static Vector2 dotTilePos;


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
            plainPos = diamondPos = upChunkPos = sideChunkPos = blackBlockPos = dotTilePos = StartPosition;

        }

        public void LoadAllTextures(ContentManager content)
        {
            blocks = content.Load<Texture2D>("blocks");

        }

        public static Rectangle plainScr = new Rectangle(0, 0, 16, 16);
        public static Rectangle diamondScr = new Rectangle(17, 0, 16, 16);
        public static Rectangle upChunkScr = new Rectangle(34, 0, 16, 16);
        public static Rectangle sideChunkScr = new Rectangle(51, 0, 16, 16);
        public static Rectangle blackBlockScr = new Rectangle(0, 17, 16, 16);
        public static Rectangle dotTileScr = new Rectangle(17, 17, 16, 16);

        public IBlockSprite CreatePlainTile()
        {
            return new PlainTile(blocks, plainPos, plainScr);
        }

        public IBlockSprite CreateDiamondTile()
        {
            return new DiamondTile(blocks, diamondPos, diamondScr);
        }

        public IBlockSprite CreateUpChunk()
        {
            return new UpChunk(blocks, upChunkPos, upChunkScr);
        }
        public IBlockSprite CreateSideChunk()
        {
            return new SideChunk(blocks, sideChunkPos, sideChunkScr);
        }
        public IBlockSprite CreateBlackBlock()
        {
            return new SideChunk(blocks, blackBlockPos, blackBlockScr);
        }
        public IBlockSprite CreateDotTile()
        {
            return new SideChunk(blocks, dotTilePos, dotTileScr);
        }
    }
}