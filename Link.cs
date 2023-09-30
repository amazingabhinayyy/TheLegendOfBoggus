using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.ComponentModel;
using Sprint2_Attempt3.LinkStates;

namespace Sprint2_Attempt3
{
    public class Link : ILink
    {
        public Vector2 position;
        public Vector2 ItemPosition { get; set; }

        public ISprite AttackSprite { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public IItemSprite ItemSprite { get; set; }
        public IItemState ItemState { get; set; }
        public List<IItemSprite> Items { get; set; }

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
            for(int c = 0; c < Items.Count; c++)
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