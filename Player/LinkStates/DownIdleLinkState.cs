using Sprint2_Attempt3.Interfaces;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class DownIdleLinkState : ILinkState
    {

        private Link link;
        public DownIdleLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateDownIdleLinkSprite();
            link.AttackSprite = LinkSpriteFactory.Instance.CreateSwordPlaceholderSprite();
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
            link.State = new DownUseBombLinkState(link);
        }
        public void UseArrow()
        {
            link.State = new DownUseArrowState(link);
        }
        public void UseBoomerang()
        {
            link.State = new DownUseBoomerangState(link);
        }
        public void UseBlueBoomerang()
        {
            link.State = new DownUseBlueBoomerangState(link);
        }
        public void UseBlueArrow()
        {
            link.State = new DownUseBlueArrowState(link);
        }
        public void UseFire()
        {
            link.State = new DownUseFireState(link);
        }
        public void UseThrowingSword()
        {

        }
    }
}