using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class CollectTriForceState : ILinkState
    {

        private Link link;
        private int timer = 440;
        public CollectTriForceState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateTriForceLink();
        }
        public void FinishAnimation()
        {
            link.State = new DownIdleLinkState(link);
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
        public void CollectBow()
        {

        }
        public void CollectTriForce()
        {

        }
        public void Attack()
        {
        }
        public void Update()
        {
            if(timer > 0)
            {
                timer--;
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
        public void Killed()
        {
        }
    }
}