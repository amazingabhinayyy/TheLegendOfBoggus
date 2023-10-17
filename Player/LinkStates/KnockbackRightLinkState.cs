using Sprint2_Attempt3.Interfaces;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class KnockbackRightLinkState : ILinkState
    {
        int currentframe = 0;
        private Link link;
        public KnockbackRightLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateLeftIdleLinkSprite();
        }
        public void FinishAnimation()
        {
            link.State = new LeftIdleLinkState(link);
        }
        public void BecomeIdle()
        {
        }
        public void MoveUp()
        {
        }
        public void MoveDown()
        {
        }
        public void MoveLeft()
        {
        }
        public void MoveRight()
        {
        }
        public void GetDamaged()
        {

        }
        public void Attack()
        {
        }
        public void Update()
        {
            if (currentframe < 10)
            {
                link.position.X += 10;
            } else
            {
                FinishAnimation();
            }
        }
        public void UseBomb()
        {
        }
        public void UseArrow()
        {
        }
        public void UseBoomerang()
        {
        }
        public void UseBlueBoomerang()
        {
        }
        public void UseBlueArrow()
        {
        }
        public void UseFire()
        {
        }
        public void UseThrowingSword()
        {

        }
    }
}