using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Collision;

namespace Sprint2_Attempt3.Player
{
    public class DamageLinkDecorator : ILink
    {
        private Game1 game;
        private ILink decoratedLink;
        private int timer;
        public ILinkState State { get; set; }
        public DamageLinkDecorator(ILink decoratedLink, Game1 game)
        {
            this.decoratedLink = decoratedLink;
            this.game = game;
            game.link = this;
        }

        public void GetDamaged(ICollision side)
        {
            timer = 100;
        }
        public void StopMoving(ICollision side)
        {
            timer = 100;
        }
        public void MoveLeft()
        {
            decoratedLink.MoveLeft();
        }
        public void MoveRight()
        {
            decoratedLink.MoveRight();
        }
        public void MoveUp()
        {
            decoratedLink.MoveUp();
        }
        public void MoveDown()
        {
            decoratedLink.MoveDown();
        }

        public void BecomeIdle()
        {
            decoratedLink.BecomeIdle();
        }
        public void Attack()
        {
            decoratedLink.Attack();
        }
        public void UseBomb()
        {
            decoratedLink.UseBomb();
        }
        public void UseArrow()
        {
            decoratedLink.UseArrow();
        }
        public void UseBoomerang()
        {
            decoratedLink.UseBoomerang();
        }
        public void UseBlueBoomerang()
        {
            decoratedLink.UseBlueBoomerang();
        }
        public void UseBlueArrow()
        {
            decoratedLink.UseBlueArrow();
        }
        public void UseFire()
        {
            decoratedLink.UseFire();
        }
        public void UseThrowingSword()
        {
            decoratedLink.UseThrowingSword();
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
            game.link = decoratedLink;
        }

        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            decoratedLink.Draw(spriteBatch, Color.Red);
        }
        public Rectangle GetHitBox()
        {
            return decoratedLink.GetHitBox();
        }

    }
}
