using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.BlockStates;
using Sprint2_Attempt3;
using Sprint2_Attempt3.Items;

namespace Sprint2
{
    public class Block : IBlock
    {
        public Vector2 position;
        BlockSpriteFactory spriteFactory;

        public ISprite Sprite { get; set; }
        public IStateTiles State { get; set; }

        public Block()
        {
            State = new plainTileState(this);
        }
        public void CreateDiamondTile()
        {
            State = new diamondTileState(this);
        }

        public void CreatePlainTile()
        {
            State = new plainTileState(this);
        }

        public void diamondTile()
        {
            State.diamondTile();
        }

        public void plainTile()
        {
            State.plainTile();
        }
        public void Update()
        {
            State.Update();
            Sprite.Update();
        }

        public void Draw(SpriteBatch _spriteBatch, Color color)
        {
            Sprite.Draw(_spriteBatch, position, color);
        }

    }
}