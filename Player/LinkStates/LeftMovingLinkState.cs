using Sprint2_Attempt3.Player.Interfaces;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class LeftMovingLinkState : ILinkState
    {
        private Link link;
        public LeftMovingLinkState(Link link)
        {
            this.link = link;

            link.Sprite = LinkSpriteFactory.Instance.CreateLeftMovingLinkSprite();
        }
        public void BecomeIdle()
        {
            link.State = new LeftIdleLinkState(link);
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
            link.State = new LeftAttackLinkState(link);
        }
        public void Update()
        {
            link.position.X -= 4;
        }
        public void UseBomb()
        {
            link.State = new LeftUseBombLinkState(link);
        }
        public void UseArrow()
        {
            link.State = new LeftUseArrowState(link);
        }
        public void UseBoomerang()
        {
            link.State = new LeftUseBoomerangState(link);
        }
        public void UseBlueBoomerang()
        {
            link.State = new LeftUseBlueBoomerangState(link);
        }
        public void UseBlueArrow()
        {
            link.State = new LeftUseBlueArrowState(link);
        }
        public void UseFire()
        {
            link.State = new LeftUseFireState(link);
        }
        public void UseThrowingSword()
        {

        }
    }
}