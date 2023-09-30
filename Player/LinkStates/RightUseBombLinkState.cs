using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Items;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class RightUseBombLinkState : IState
    {
        private Link link;
        private int frameCounter;
        public RightUseBombLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateRightUseBombLinkSprite();
            link.ItemPosition = new Vector2(link.position.X + 45, link.position.Y);
            link.Items.Add(LinkSpriteFactory.Instance.CreateBombItem());
            frameCounter = 0;
        }
        public void BecomeIdle()
        {
            if (frameCounter >= 10)
            {
                link.State = new RightIdleLinkState(link);
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
    }
}