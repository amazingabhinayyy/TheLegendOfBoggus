namespace Sprint2_Attempt3.Player.LinkStates
{
    public class DownAttackLinkState : IState
    {
        private Link link;
        private int count = 0;
        public DownAttackLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateDownAttackLinkSprite();
            link.AttackSprite = LinkSpriteFactory.Instance.CreateDownAttackLinkSwordSprite();
        }
        public void FinishAttack()
        {
            link.State = new DownIdleLinkState(link);
            link.AttackSprite = LinkSpriteFactory.Instance.CreateSwordPlaceholderSprite();

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
            count++;
            if (count > 30)
            {
                FinishAttack();
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