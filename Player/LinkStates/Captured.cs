using Sprint2_Attempt3.Player.Interfaces;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class Captured : ILinkState
    {
        private Link link;

        public Captured(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateCapturedLinkSprite(); 
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
            link.position.Y -= 1;
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
        public void GetCaptured()
        {
        }
    }
}
