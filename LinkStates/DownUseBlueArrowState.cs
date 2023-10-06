using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.LinkStates
{
    public class DownUseBlueArrowState : IState
    {
        private Link link;
        private int frameCounter;
        public DownUseBlueArrowState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateDownItemLinkSprite();
            //Constant are to make the item spawn infront of link and adjust for roation
            link.ItemPosition = new Vector2(link.position.X + 48, link.position.Y + 45);
            link.Items.Add(LinkSpriteFactory.Instance.CreateBlueArrowItem());
            link.Direction = Link.LinkDirection.Down;
            frameCounter = 0;
        }

        public void Stop()
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
        public void UseThrowingSword()
        {

        }
    }
}
