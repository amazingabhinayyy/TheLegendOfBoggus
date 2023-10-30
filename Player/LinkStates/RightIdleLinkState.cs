using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class RightIdleLinkState : ILinkState
    {
        private Link link;
        public RightIdleLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateRightIdleLinkSprite();
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
            link.State = new RightAttackLinkState(link);
        }
        public void Update()
        {

        }
        public void UseBomb()
        {
            link.State = new RightUseItemState(link, new RightBomb(link));
        }
        public void UseArrow()
        {
            link.State = new RightUseItemState(link, new RightArrow(link));
        }
        public void UseBoomerang()
        {
            link.State = new RightUseItemState(link, new RightBoomerang(link));
        }
        public void UseBlueBoomerang()
        {
            link.State = new RightUseItemState(link, new RightBlueBoomerang(link));
        }
        public void UseBlueArrow()
        {
            link.State = new RightUseItemState(link, new RightBlueArrow(link));
        }
        public void UseFire()
        {
            link.State = new RightUseItemState(link, new RightFire(link));
        }
        public void UseThrowingSword()
        {

        }
    }
}