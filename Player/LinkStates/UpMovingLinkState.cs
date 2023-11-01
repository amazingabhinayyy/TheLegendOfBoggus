using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;

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
            link.position.Y -= 4;
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
