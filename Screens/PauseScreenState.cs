using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Screens
{
    public class PauseScreenState
    {
        private ISprite sprite;
        private Game1 game1;
        public PauseScreenState(Game1 game) 
        {
            sprite = ScreenSpriteFactory.Instance.CreatePauseScreen();
            this.game1 = game;
        }
        public void Update()
        {
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch);
        }
    }
}
