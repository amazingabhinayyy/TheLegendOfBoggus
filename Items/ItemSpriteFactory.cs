using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Items.ItemClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
using Sprint2_Attempt3.Item;

namespace Sprint2_Attempt3.Items
{
    public class ItemSpriteFactory
    {
        private static Texture2D itemTexture;
        private static ItemSpriteFactory instance = new ItemSpriteFactory();

        public static ItemSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        private ItemSpriteFactory()
        {
        }

        public void LoadAllTextures(ContentManager content)
        {
            itemTexture = content.Load<Texture2D>("Items");
        }

        public IItemSprite CreateItemSprite() { 
            return new ItemSprite(itemTexture);
        }

        public IItemSprite CreateSpawnItemSprite() {
            return new SpawnItemSprite(itemTexture);
        }


    }
}
