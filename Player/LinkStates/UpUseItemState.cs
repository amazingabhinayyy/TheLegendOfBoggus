using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class UpUseItemState : ILinkState
    {
        private Link link;
        private int frameCounter;
        public UpUseItemState(Link link, ILinkProjectile item)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateUpItemLinkSprite();
            link.Items.Add(item);
            CollisionManager.GameObjectList.Add(item);
            frameCounter = 0;
        }
        public void Stop()
        {
            link.State = new UpIdleLinkState(link);
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
            frameCounter++;
            if (frameCounter >= 10)
            {
                Stop();
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
        public void CollectBow()
        {

        }
        public void CollectTriForce()
        {

        }
    }
}
