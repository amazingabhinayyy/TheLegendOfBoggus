using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Interfaces;
using Sprint2_Attempt3.Player.LinkStates;
using System.Collections.Generic;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.CommandClasses;
using Sprint2_Attempt3.Collision.SideCollisionHandlers;

namespace Sprint2_Attempt3.Player
{
    public class Link : ILink
    {
        public Vector2 position;
        public ILinkSprite Sprite { get; set; }
        public ILinkState State { get; set; }
        public List<ILinkItem> Items { get; set; }
        private Game1 game;
        public Link(Game1 game)
        {
            this.game = game;
            //CollisionDetector.GameObjectList.Add(this);
            StartLinkState();
        }
        public void GetDamaged(ICollision side)
        {
            //State.GetDamaged();
            if(side is BottomCollision)
            {
                State = new KnockbackDownLinkState(this);
            } else if(side is LeftCollision)
            {
                State = new KnockbackLeftLinkState(this);
            } else if(side is RightCollision)
            {
                State = new KnockbackRightLinkState(this);
            }
            else
            {
                State = new KnockbackUpLinkState(this);
            }
            ICommand damage = new SetDamageLinkCommand(game);
            damage.Execute();
        }
        public void BecomeIdle()
        {
            State.BecomeIdle();
        }
        public void MoveRight()
        {
            State.MoveRight();
        }
        public void MoveLeft()
        {
            State.MoveLeft();
        }
        public void MoveUp()
        {
            State.MoveUp();
        }
        public void MoveDown()
        {
            State.MoveDown();
        }
        public void Attack()
        {
            State.Attack();
        }
        public void UseBomb()
        {
            State.UseBomb();
        }
        public void UseArrow()
        {
            State.UseArrow();
        }
        public void UseBoomerang()
        {
            State.UseBoomerang();
        }
        public void UseBlueBoomerang()
        {
            State.UseBlueBoomerang();
        }
        public void UseBlueArrow()
        {
            State.UseBlueArrow();
        }
        public void UseFire()
        {
            State.UseFire();
        }
        public void UseThrowingSword()
        {
            State.UseThrowingSword();
        }
        public void StartLinkState()
        {
            position = new Vector2(105, 90);
            State = new DownIdleLinkState(this);
            Items = new List<ILinkItem>();
        }

        public void Update()
        {
            State.Update();
            Sprite.Update();
            for (int c = 0; c < Items.Count; c++)
            {
                Items[c].Update();
            }
        }

        public void Draw(SpriteBatch _spriteBatch, Color color)
        {
            Sprite.Draw(_spriteBatch, position, color);
            foreach (ILinkItem item in Items)
            {
                item.Draw(_spriteBatch);
            }

        }
        public Rectangle GetHitBox()
        {
            return new Rectangle((int)position.X, (int)position.Y, 15 * 3, 15 * 3);
        }
    }
}