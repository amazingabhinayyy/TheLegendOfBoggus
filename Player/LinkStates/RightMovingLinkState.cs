using Sprint2_Attempt3.Player.Interfaces;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class RightMovingLinkState : ILinkState
    {
        private Link link;
        public RightMovingLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateRightMovingLinkSprite();
        }
        public void BecomeIdle()
        {
            link.State = new RightIdleLinkState(link);
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
            link.position.X += 4;
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
        public void GetCaptured()
        {
            link.State = new Captured(link);
        }
    }
}
