using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;
using Sprint2_Attempt3.Player.LinkProjectiles.ProjectileInterfaces;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class RightAttackLinkState : ILinkState
    {
        private Link link;
        private int count = 0;
        public RightAttackLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateRightAttackLinkSprite();
            RightSword sword = new RightSword(link);
            link.Items.Add(sword);
            CollisionManager.GameObjectList.Add(sword);
        }
        public void FinishAttack()
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
            count++;
            if (count > 20)
            {
                FinishAttack();
            }
            else if (count == 10)
            {
                bool noSwordBeam = true;
                //Checks to see if a sword beam currently exist and if so doesn't spawn another one
                foreach (ILinkProjectile obj in link.Items)
                {
                    if (obj is ISwordBeam)
                    {
                        noSwordBeam = false;
                    }
                }
                //if (noSwordBeam && InventoryController.GetCount("Heart") == 5)
                if (noSwordBeam && InventoryController.hearts == 5)
                {
                    RightSwordBeam swordBeam = new RightSwordBeam(link);
                    link.Items.Add(swordBeam);
                    CollisionManager.GameObjectList.Add(swordBeam);
                }
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
        public void UseBlueBoomerang() { }
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