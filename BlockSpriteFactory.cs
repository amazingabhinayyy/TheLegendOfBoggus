using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class BlockSpriteFactory
    {
        private static Texture2D tilesSet;

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
        }

        public void LoadAllTextures(ContentManager content)
        {
            tilesSet = content.Load<Texture2D>("tilesSet");

        }

        public ISprite CreatePlainTile()
        {
            return new plainTile(tilesSet);
        }

        public ISprite CreateDiamondTile()
        {
            return new diamondTile(tilesSet);
        }
    }
}