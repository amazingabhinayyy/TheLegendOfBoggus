using Sprint2_Attempt3.Interfaces;

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
            link.State = new RightUseBombLinkState(link);
        }
        public void UseArrow()
        {
            link.State = new RightUseArrowState(link);
        }
        public void UseBoomerang()
        {
            link.State = new RightUseBoomerangState(link);
        }
        public void UseBlueBoomerang()
        {
            link.State = new RightUseBlueBoomerangState(link);
        }
        public void UseBlueArrow()
        {
            link.State = new RightUseBlueArrowState(link);
        }
        public void UseFire()
        {
            link.State = new RightUseFireState(link);
        }
        public void UseThrowingSword()
        {

        }
    }
}