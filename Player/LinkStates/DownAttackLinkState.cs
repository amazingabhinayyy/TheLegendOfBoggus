using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class DownAttackLinkState : ILinkState
    {
        private Link link;
        private int count = 0;
        public DownAttackLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateDownAttackLinkSprite();
            DownSword sword = new DownSword(link);
            link.Items.Add(sword);
            CollisionDetector.GameObjectList.Add(sword);
        }
        public void FinishAttack()
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
        public void Attack()
        {

        }
        public void Update()
        {
            count++;
            if (count > 20)
            {
                FinishAttack();
            }
            else if(count == 10)
            {
                DownSwordBeam swordBeam = new DownSwordBeam(link);
                link.Items.Add(swordBeam);
                CollisionDetector.GameObjectList.Add(swordBeam);
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

    }
}