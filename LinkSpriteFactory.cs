using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.LinkSprites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3
{
    public class LinkSpriteFactory
    {
        private static Texture2D linkTexture;
        private Texture2D items;
            // More private Texture2Ds follow
            // ...

            private static LinkSpriteFactory instance = new LinkSpriteFactory();

            public static LinkSpriteFactory Instance
            {
                get
                {
                    return instance;
                }
            }

            private LinkSpriteFactory()
            {
            }

            public void LoadAllTextures(ContentManager content)
            {
                linkTexture = content.Load<Texture2D>("LinkPlayerSpriteSheetFinal");
                // More Content.Load calls follow
                //...
            }

        public ISprite CreateDownAttackLinkSprite()
        {
            return new DownAttackLinkSprite(linkTexture);
        }
        public ISprite CreateDownIdleLinkSprite()
        {
            return new DownIdleLinkSprite(linkTexture);
        }
        public ISprite CreateDownMovingLinkSprite()
        {
            return new DownMovingLinkSprite(linkTexture);
        }
        public ISprite CreateLeftAttackLinkSprite()
        {
            return new LeftAttackLinkSprite(linkTexture);
        }
        public ISprite CreateLeftIdleLinkSprite()
        {
            return new LeftIdleLinkSprite(linkTexture);
        }
        public ISprite CreateLeftMovingLinkSprite()
        {
            return new LeftMovingLinkSprite(linkTexture);
        }
        public ISprite CreateRightAttackLinkSprite()
        {
            return new RightAttackLinkSprite(linkTexture);
        }
        public ISprite CreateRightIdleLinkSprite()
        {
            return new RightIdleLinkSprite(linkTexture);
        }
        public ISprite CreateRightMovingLinkSprite()
        {
            return new RightMovingLinkSprite(linkTexture);
        }
        public ISprite CreateUpAttackLinkSprite()
        {
            return new UpAttackLinkSprite(linkTexture);
        }
        public ISprite CreateUpIdleLinkSprite()
        {
            return new UpIdleLinkSprite(linkTexture);
        }
        public ISprite CreateUpMovingLinkSprite()
        {
            return new UpMovingLinkSprite(linkTexture);
        }
        public ISprite CreateDownAttackLinkSwordSprite()
        {
            return new DownAttackLinkSwordSprite(linkTexture);
        }
        public ISprite CreateUpAttackLinkSwordSprite()
        {
            return new UpAttackLinkSwordSprite(linkTexture);
        }
        public ISprite CreateLeftAttackLinkSwordSprite()
        {
            return new LeftAttackLinkSwordSprite(linkTexture);
        }
        public ISprite CreateRightAttackLinkSwordSprite()
        {
            return new RightAttackLinkSwordSprite(linkTexture);
        }
        public ISprite CreateSwordPlaceholderSprite()
        {
            return new SwordPlaceholderSprite(linkTexture);
        }

        public ISprite CreateDownItemLinkSprite()
        {
            return new DownUseItemLinkSprite(linkTexture);
        }
        public ISprite CreateUpItemLinkSprite()
        {
            return new UpUseItemLinkSprite(linkTexture);
        }
        public ISprite CreateLeftItemLinkSprite()
        {
            return new LeftUseItemLinkSprite(linkTexture);
        }
        public ISprite CreateRightItemLinkSprite()
        {
            return new RightUseItemLinkSprite(linkTexture);
        }
        public IItemSprite CreateNoItem()
        {
            return new NoItemSprite();
        }
        public IItemSprite CreateBombItem()
        {
            return new Bomb(linkTexture);
        }
        public IItemSprite CreateArrowItem()
        {
            return new Arrow(linkTexture);
        }
        public IItemSprite CreateBoomerangItem()
        {
            return new Boomerang(linkTexture);
        }
        public IItemSprite CreateBlueBoomerangItem()
        {
            return new BlueBoomerang(linkTexture);
        }
        public IItemSprite CreateBlueArrowItem()
        {
            return new BlueArrow(linkTexture);
        }


        // More public ISprite returning methods follow
        // ...
    } 
}

