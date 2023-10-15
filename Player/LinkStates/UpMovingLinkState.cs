using Sprint2_Attempt3.Interfaces;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class UpMovingLinkState : ILinkState
    {
        private Link link;

        public UpMovingLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateUpMovingLinkSprite();
        }
        public void BecomeIdle()
        {
            link.State = new UpIdleLinkState(link);
        }
        public void MoveUp()
        {
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
            link.State = new UpAttackLinkState(link);
        }
        public void Update()
        {
            link.position.Y -= 2;
        }
        public void UseBomb()
        {
            link.State = new UpUseBombLinkState(link);
        }
        public void UseArrow()
        {
            link.State = new UpUseArrowState(link);
        }
        public void UseBoomerang()
        {
            link.State = new UpUseBoomerangState(link);
        }
        public void UseBlueBoomerang()
        {
            link.State = new UpUseBlueBoomerangState(link);
        }
        public void UseBlueArrow()
        {
            link.State = new UpUseBlueArrowState(link);
        }
        public void UseFire()
        {
            link.State = new UpUseFireState(link);
        }
        public void UseThrowingSword()
        {

        }
    }
}
