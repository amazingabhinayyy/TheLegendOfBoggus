using Sprint2_Attempt3.Player.Interfaces;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class KnockbackUpLinkState : ILinkState
    {
        int currentframe = 0;
        private Link link;
        public KnockbackUpLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateUpIdleLinkSprite();
        }
        public void FinishAnimation()
        {
            link.State = new UpIdleLinkState(link);
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
                link.position.Y -= 10;
            } else
            {
                FinishAnimation();
            }
            currentframe++;
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