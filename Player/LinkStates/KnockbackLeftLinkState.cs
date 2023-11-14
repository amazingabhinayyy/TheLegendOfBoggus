using Sprint2_Attempt3.Player.Interfaces;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Sounds;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class KnockbackLeftLinkState : ILinkState
    {
        int currentframe = 0;
        private Link link;
        public KnockbackLeftLinkState(Link link)
        {
            SoundFactory.PlaySound(SoundFactory.Instance.linkHit);
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateRightIdleLinkSprite();
        }
        public void FinishAnimation()
        {
            link.State = new RightIdleLinkState(link);
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
        public void CollectBow()
        {

        }
        public void CollectTriForce()
        {

        }
        public void Update()
        {
            if (currentframe < 10)
            {
                link.Position = new Vector2(link.Position.X - 10, link.Position.Y);
                //link.Position.X -= 10;
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
        public void Killed()
        {
            link.State = new KilledLinkState(link);
        }
    }
}