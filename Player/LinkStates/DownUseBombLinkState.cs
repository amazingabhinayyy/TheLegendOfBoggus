using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Items;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class DownUseBombLinkState : IState
    {
        private Link link;
        private int frameCounter;
        public DownUseBombLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateDownUseBombLinkSprite();
            link.ItemPosition = new Vector2(link.position.X, link.position.Y + 45);
            link.ItemState = new BombState(link);
            frameCounter = 0;
        }
        public void BecomeIdle()
        {
            if (frameCounter >= 10)
            {
                link.State = new DownIdleLinkState(link);
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
