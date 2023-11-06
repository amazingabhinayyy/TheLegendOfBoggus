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
    public class StartScreenSpriteFactory
    {
        private static Texture2D startScreenTexture;
        // More private Texture2Ds follow
        // ...

        private static StartScreenSpriteFactory instance = new StartScreenSpriteFactory();

        public static StartScreenSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        private StartScreenSpriteFactory()
        {
        }

        public void LoadAllTextures(ContentManager content)
        {
            startScreenTexture = content.Load<Texture2D>("TitleScreen");
            // More Content.Load calls follow
            //...
        }
        public ISprite CreateStartScreen()
        {
            return new StartScreenSprite(startScreenTexture);
        }
    }
}
