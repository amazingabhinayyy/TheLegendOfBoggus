using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.StartScreen
{
    public class DeathScreenState
    {
        private ISprite sprite;
        private Game1 game;
        public DeathScreenState(Game1 game)
        {
            sprite = ScreenSpriteFactory.Instance.CreateDeathScreen();
            this.game = game;
        }
        public void Update()
        {
            sprite.Update();
        }
        public void Draw(SpriteBatch spirteBatch)
        {
            sprite.Draw(spirteBatch);
        }
    }
}
