using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3
{
    public class DamageLinkDecorator : ILink
    {
        private Game1 game;
        private ILink decoratedLink;
        private int timer;
        public IState State { get; set; }
        public DamageLinkDecorator(Link decoratedLink, Game1 game)
        {
            this.decoratedLink = decoratedLink;
            this.game = game;
            game.Link = decoratedLink;
        }

        public void GetDamaged()
        {
            timer = 1000;
        }
        public void MoveLeft()
        {

        }
        public void MoveRight()
        {

        }
        public void MoveUp()
        {

        }
        public void MoveDown()
        {

        }

        public void BecomeIdle()
        {
            decoratedLink.BecomeIdle();
        }
        public void Attack()
        {

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


        public void Update()
        {
            timer--;
            if (timer == 0)
            {
                RemoveDecorator();
            }
            decoratedLink.Update();
        }

        public void RemoveDecorator()
        {
            game.Link = (Link)decoratedLink;
        }

        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            decoratedLink.Draw(spriteBatch, Color.Red);
        }

    }
}
