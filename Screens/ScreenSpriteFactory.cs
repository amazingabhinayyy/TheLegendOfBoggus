using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.StartScreen
{
    public class ScreenSpriteFactory
    {
        private static Texture2D startScreenTexture;
        private static Texture2D deathScreenTexture;
        // More private Texture2Ds follow
        // ...

        private static ScreenSpriteFactory instance = new ScreenSpriteFactory();

        public static ScreenSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        private ScreenSpriteFactory()
        {
        }

        public void LoadAllTextures(ContentManager content)
        {
            startScreenTexture = content.Load<Texture2D>("TitleScreen");
            deathScreenTexture = content.Load<Texture2D>("DeathScreen");
            // More Content.Load calls follow
            //...
        }
        public ISprite CreateStartScreen()
        {
            return new StartScreenSprite(startScreenTexture);
        }
        public ISprite CreateDeathScreen()
        {
            return new DeathScreenSprite(deathScreenTexture); 
        }
    }
}
