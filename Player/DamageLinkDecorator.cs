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
using Sprint2_Attempt3.Inventory;

namespace Sprint2_Attempt3.Player
{
    public class DamageLinkDecorator : ILink
    {
        //private Game1 game;
        private ILink decoratedLink;
        private static int timer;
        public List<ILinkProjectile> Items { get; set; }
        private Vector2 position;
        public Vector2 Position { get { return position; } set { position = value; }}

        public ILinkSprite Sprite { get; set; }
        public ILinkState State { get; set; }

        public DamageLinkDecorator(ILink decoratedLink)//, Game1 game)
        {
            this.decoratedLink = decoratedLink;
            //this.game = game;
            Items = decoratedLink.Items;
            position = decoratedLink.Position;
            SetDecorator(this);
        }

        public void GetDamaged(ICollision side)
        {
            if (timer < 10)
            {
                if(InventoryController.GetCount("Heart") != 0.5f)
                    Knockback(side);

                timer = 40;
                InventoryController.DecrementCount("Heart", .5f);
                if (InventoryController.GetCount("Heart") <= 0)
                {
                    if (InventoryController.UsingFairy)
                    {
                        InventoryController.IncrementCount("Heart");
                        InventoryController.UsingFairy = false;
                        InventoryController.DecrementCount("Fairy");
                    }
                    else 
                    { 
                        Kill();
                        timer = 0;
                    }
                }
            }
        }
        public void Knockback(ICollision side) 
        {
            decoratedLink.Knockback(side);
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
        public void SetDecorator(ILink link)
        {
            decoratedLink.SetDecorator(this);
        }
        public void Kill()
        {
            decoratedLink.Kill();
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
            decoratedLink.RemoveDecorator();
        }

        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            if (timer % 8 < 4)
            {
                decoratedLink.Draw(spriteBatch, Color.OrangeRed);
            }
            else
            {
                decoratedLink.Draw(spriteBatch, Color.SandyBrown);
            }
        }
        public Rectangle GetHitBox()
        {
            return decoratedLink.GetHitBox();
        }
    }
}
