

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Interfaces;
using Sprint2_Attempt3.Player.LinkStates;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Player
{
    public class Link : ILink
    {
        public Vector2 position;
        public Vector2 ItemPosition { get; set; }
<<<<<<< Updated upstream:LinkPlayer/Link.cs

        public ILinkSprite AttackSprite { get; set; }
        public ILinkSprite Sprite { get; set; }
        public ILinkState State { get; set; }
=======
        public ISprite AttackSprite { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
>>>>>>> Stashed changes:Link.cs
        public IItemSprite ItemSprite { get; set; }
        public IItemState ItemState { get; set; }
        public List<IItemSprite> Items { get; set; }
        public enum LinkDirection { Left, Right, Up, Down };
        public LinkDirection Direction { get; set; } 
        public Link()
        {
            StartLinkState();
        }

        public void GetDamaged()
        {
            State.GetDamaged();
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
            State = new DownIdleLinkState(this);
            Items = new List<IItemSprite>();
        }

        public void Update()
        {
            State.Update();
            Sprite.Update();
            AttackSprite.Update();
            for (int c = 0; c < Items.Count; c++)
            {
                Items[c].Update(this);
            }
        }

        public void Draw(SpriteBatch _spriteBatch, Color color)
        {
            Sprite.Draw(_spriteBatch, position, color);
            AttackSprite.Draw(_spriteBatch, position, color);
            foreach (IItemSprite item in Items)
            {
                item.Draw(_spriteBatch, ItemPosition, Color.White);
            }

        }

    }
}