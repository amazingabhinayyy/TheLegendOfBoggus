using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.LinkStates
{
    public class UpUseBombLinkState : IState
    {
        private Link link;
        private int frameCounter;
        public UpUseBombLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateUpItemLinkSprite();
            link.ItemPosition = new Vector2(link.position.X, link.position.Y - 45);
            link.Items.Add(LinkSpriteFactory.Instance.CreateBombItem());
            frameCounter = 0;
        }
        public void BecomeIdle()
        {
            if (frameCounter >= 10)
            {
                link.State = new UpIdleLinkState(link);
            }
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
        public void UseThrowingSword()
        {

        }
    }
}
