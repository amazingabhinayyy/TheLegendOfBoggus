using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;
using Microsoft.Xna.Framework;
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
            link.Position = new Vector2(link.Position.X + 4, link.Position.Y);
            //link.Position.X += 4;
        }
        public void UseBomb()
        {
            link.State = new RightUseItemState(link, new RightBomb(link));
        }
        public void UseArrow()
        {
            link.State = new RightUseItemState(link, new RightArrow(link));
        }
        public void UseBoomerang()
        {
            link.State = new RightUseItemState(link, new RightBoomerang(link));
        }
        public void UseBlueBoomerang()
        {
            link.State = new RightUseItemState(link, new RightBlueBoomerang(link));
        }
        public void UseBlueArrow()
        {
            link.State = new RightUseItemState(link, new RightBlueArrow(link));
        }
        public void UseFire()
        {
            link.State = new RightUseItemState(link, new RightFire(link));
        }
        public void Killed()
        {
            link.State = new KilledLinkState();
        }
    }
}
