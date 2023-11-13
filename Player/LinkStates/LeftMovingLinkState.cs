using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;
using Microsoft.Xna.Framework;

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
        public void CollectBow()
        {
            link.State = new CollectBowState(link);
        }
        public void CollectTriForce()
        {
            link.State = new CollectTriForceState(link);
        }
        public void Attack()
        {
            link.State = new LeftAttackLinkState(link);
        }
        public void Update()
        {
            link.Position = new Vector2(link.Position.X - 4, link.Position.Y);
            //link.Position.X -= 4;
        }
        public void UseBomb()
        {
            link.State = new LeftUseItemState(link, new LeftBomb(link));
        }
        public void UseArrow()
        {
            link.State = new LeftUseItemState(link, new LeftArrow(link));
        }
        public void UseBoomerang()
        {
            link.State = new LeftUseItemState(link, new LeftBoomerang(link));
        }
        public void UseBlueBoomerang()
        {
            link.State = new LeftUseItemState(link, new LeftBlueBoomerang(link));
        }
        public void UseBlueArrow()
        {
            link.State = new LeftUseItemState(link, new LeftBlueArrow(link));
        }
        public void UseFire()
        {
            link.State = new LeftUseItemState(link, new LeftFire(link));
        }
        public void Killed()
        {
            link.State = new KilledLinkState(link);
        }
    }
}