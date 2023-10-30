using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class UpIdleLinkState : ILinkState
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
            link.State = new UpUseItemState(link, new UpBomb(link));
        }
        public void UseArrow()
        {
            link.State = new UpUseItemState(link, new UpArrow(link));
        }
        public void UseBoomerang()
        {
            link.State = new UpUseItemState(link, new UpBoomerang(link));
        }
        public void UseBlueBoomerang()
        {
            link.State = new UpUseItemState(link, new UpBlueBoomerang(link));
        }
        public void UseBlueArrow()
        {
            link.State = new UpUseItemState(link, new UpBlueArrow(link));
        }
        public void UseFire()
        {
            link.State = new UpUseItemState(link, new UpFire(link));
        }
        public void UseThrowingSword()
        {

        }

    }
}

