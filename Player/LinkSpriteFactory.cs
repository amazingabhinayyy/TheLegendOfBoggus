using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.Items;
using Sprint2_Attempt3.Player.LinkSprites;

namespace Sprint2_Attempt3.Player
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

        public ILinkSprite CreateDownAttackLinkSprite()
        {
            return new DownAttackLinkSprite(linkTexture);
        }
        public ILinkSprite CreateDownIdleLinkSprite()
        {
            return new DownIdleLinkSprite(linkTexture);
        }
        public ILinkSprite CreateDownMovingLinkSprite()
        {
            return new DownMovingLinkSprite(linkTexture);
        }
        public ILinkSprite CreateLeftAttackLinkSprite()
        {
            return new LeftAttackLinkSprite(linkTexture);
        }
        public ILinkSprite CreateLeftIdleLinkSprite()
        {
            return new LeftIdleLinkSprite(linkTexture);
        }
        public ILinkSprite CreateLeftMovingLinkSprite()
        {
            return new LeftMovingLinkSprite(linkTexture);
        }
        public ILinkSprite CreateRightAttackLinkSprite()
        {
            return new RightAttackLinkSprite(linkTexture);
        }
        public ILinkSprite CreateRightIdleLinkSprite()
        {
            return new RightIdleLinkSprite(linkTexture);
        }
        public ILinkSprite CreateRightMovingLinkSprite()
        {
            return new RightMovingLinkSprite(linkTexture);
        }
        public ILinkSprite CreateUpAttackLinkSprite()
        {
            return new UpAttackLinkSprite(linkTexture);
        }
        public ILinkSprite CreateUpIdleLinkSprite()
        {
            return new UpIdleLinkSprite(linkTexture);
        }
        public ILinkSprite CreateUpMovingLinkSprite()
        {
            return new UpMovingLinkSprite(linkTexture);
        }
        public ILinkSprite CreateDownAttackLinkSwordSprite()
        {
            return new DownAttackLinkSwordSprite(linkTexture);
        }
        public ILinkSprite CreateUpAttackLinkSwordSprite()
        {
            return new UpAttackLinkSwordSprite(linkTexture);
        }
        public ILinkSprite CreateLeftAttackLinkSwordSprite()
        {
            return new LeftAttackLinkSwordSprite(linkTexture);
        }
        public ILinkSprite CreateRightAttackLinkSwordSprite()
        {
            return new RightAttackLinkSwordSprite(linkTexture);
        }
        public ILinkSprite CreateSwordPlaceholderSprite()
        {
            return new SwordPlaceholderSprite(linkTexture);
        }

        public ILinkSprite CreateDownItemLinkSprite()
        {
            return new DownUseItemLinkSprite(linkTexture);
        }
        public ILinkSprite CreateUpItemLinkSprite()
        {
            return new UpUseItemLinkSprite(linkTexture);
        }
        public ILinkSprite CreateLeftItemLinkSprite()
        {
            return new LeftUseItemLinkSprite(linkTexture);
        }
        public ILinkSprite CreateRightItemLinkSprite()
        {
            return new RightUseItemLinkSprite(linkTexture);
        }
        public ILinkItemSprite CreateBombItem()
        {
            return new BombSprite(linkTexture);
        }
        public ILinkItemSprite CreateArrowItem()
        {
            return new ArrowSprite(linkTexture);
        }
        public ILinkItemSprite CreateBoomerangItem()
        {
            return new BoomerangSprite(linkTexture);
        }
        public ILinkItemSprite CreateBlueBoomerangItem()
        {
            return new BlueBoomerangSprite(linkTexture);
        }
        public ILinkItemSprite CreateBlueArrowItem()
        {
            return new BlueArrowSprite(linkTexture);
        }
        public ILinkItemSprite CreateFireItem()
        {
            return new FireSprite(linkTexture);
        }


        // More public ISprite returning methods follow
        // ...
    }
}

