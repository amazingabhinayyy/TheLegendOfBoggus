using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class DownIdleLinkState : ILinkState
    {

        private Link link;
        public DownIdleLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateDownIdleLinkSprite();
        }
        public void BecomeIdle()
        {
        }
        public void MoveUp()
        {
            link.State = new UpMovingLinkState(link);
        }
        public void MoveDown()
        {
            link.State = new DownMovingLinkState(link);
        }
        public void MoveLeft()
        {
            link.State = new LeftMovingLinkState(link);
        }
        public void MoveRight()
        {
            link.State = new RightMovingLinkState(link);
        }
        public void GetDamaged()
        {

        }
        public void Attack()
        {
            link.State = new DownAttackLinkState(link);
        }
        public void Update()
        {

        }
        public void UseBomb()
        {
            link.State = new DownUseItemState(link, new DownBomb(link));
        }
        public void UseArrow()
        {
            link.State = new DownUseItemState(link, new DownArrow(link));
        }
        public void UseBoomerang()
        {
            link.State = new DownUseItemState(link, new DownBoomerang(link));
        }
        public void UseBlueBoomerang()
        {
            link.State = new DownUseItemState(link, new DownBlueBoomerang(link));
        }
        public void UseBlueArrow()
        {
            link.State = new DownUseItemState(link, new DownBlueArrow(link));
        }
        public void UseFire()
        {
            link.State = new DownUseItemState(link, new DownFire(link));
        }
    }
}