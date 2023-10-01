using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.LinkStates
{
    public class LeftUseBoomerangState : IState
    {
        private Link link;
        private int frameCounter;
        public LeftUseBoomerangState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateLeftItemLinkSprite();
            link.ItemPosition = new Vector2(link.position.X - 30, link.position.Y);
            link.Items.Add(LinkSpriteFactory.Instance.CreateBoomerangItem());
            link.Direction = Link.LinkDirection.Left;
            frameCounter = 0;
        }
        public void BecomeIdle()
        {
            if (frameCounter >= 10)
            {
                link.State = new LeftIdleLinkState(link);
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
    }
}

