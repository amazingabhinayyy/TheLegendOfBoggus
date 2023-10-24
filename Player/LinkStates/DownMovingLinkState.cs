using Sprint2_Attempt3.Player.Interfaces;

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
        public void GetCaptured()
        {
            link.State = new Captured(link);
        }
    }
}