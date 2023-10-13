namespace Sprint2_Attempt3.Player.LinkStates
{
    public class UpIdleLinkState : IState
    {
        private Link link;

        public UpIdleLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateUpIdleLinkSprite();
        }

        public void MoveLeft()
        {
            link.State = new LeftMovingLinkState(link);
        }
        public void MoveRight()
        {
            link.State = new RightMovingLinkState(link);
        }

        public void MoveDown()
        {
            link.State = new DownMovingLinkState(link);
        }

        public void MoveUp()
        {
            link.State = new UpMovingLinkState(link);
        }
        public void BecomeIdle()
        {

        }

        public void GetDamaged()
        {
            //link.State = new UpKnockBackState(link);
        }

        public void Attack()
        {
            link.State = new UpAttackLinkState(link);
        }

        public void Update()
        {
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

