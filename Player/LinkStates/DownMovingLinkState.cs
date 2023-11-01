using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class DownMovingLinkState : ILinkState
    {
        private Link link;
        public DownMovingLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateDownMovingLinkSprite();
        }
        public void BecomeIdle()
        {
            link.State = new DownIdleLinkState(link);
        }
        public void MoveUp()
        {
            link.State = new UpMovingLinkState(link);
        }
        public void MoveDown()
        {

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
            link.position.Y += 4;
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
        public void UseThrowingSword()
        {

        }
    }
}