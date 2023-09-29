using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class ShootingStillLeftGoriyaSprite : IEnemySprite
    {
        private Texture2D texture;
        private Rectangle sourceRectangle;
        private Rectangle[] boomerangs;
        private SpriteEffects[] boomerangEffects;
        private int currentFrame;
        private int x;
        private int y;
        private int x2;
        private int y2;
        private int i;
        private bool goLeft;

        public ShootingStillLeftGoriyaSprite(Texture2D texture)
        {
            this.texture = texture;
            sourceRectangle = Globals.GoriyaBlueRight;
            boomerangs = new Rectangle[] { Globals.GoriyaBoomerang1, Globals.GoriyaBoomerang2, Globals.GoriyaBoomerang3 };
            //boomerangs = new Rectangle[]{Globals.GoriyaBoomerang1,Globals.GoriyaBoomerang2,Globals.GoriyaBoomerang3, Globals.GoriyaBoomerang2 , Globals.GoriyaBoomerang1, Globals.GoriyaBoomerang2, Globals.GoriyaBoomerang3, Globals.GoriyaBoomerang2};
            //boomerangEffects = new SpriteEffects[] { SpriteEffects.None, SpriteEffects.None, SpriteEffects.None,SpriteEffects.FlipHorizontally,SpriteEffects.FlipHorizontally,SpriteEffects.FlipHorizontally | SpriteEffects.FlipVertically,SpriteEffects.FlipVertically, SpriteEffects.FlipVertically };
            currentFrame = 0;
            x = 200;
            y = 200;
            x2 = x-10; y2 = y;
            int i = 0;
            goLeft = true;
           
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame < 30)
            {
                if (currentFrame < 15)
                {
                    sourceRectangle = Globals.GoriyaBlueRight;

                }
                else
                {
                    sourceRectangle = Globals.GoriyaBlueRight2;

                }
                if (x2<=0)
                {
                    goLeft = false;
                }
                if (goLeft)
                {
                    x2-=10;
                }
                else  
                {
                    x2+=10;
                }
                if (x2 >= x-9)
                {
                    Globals.changeDirection = true;
                    x2 = x - 9;
                    
                }
               
              
            }
            else
            {
                currentFrame = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                texture,
                new Vector2(x, y),
                sourceRectangle,
                Color.White,
                0f,
                new Vector2(0, 0),
                Globals.scale,
                SpriteEffects.FlipHorizontally,
                0f
            );



            if (x2 < x - 9)
            {
                spriteBatch.Draw(
                texture,
                new Vector2(x2, y2),
                boomerangs[i],
                Color.White,
                0f,
                new Vector2(0, 0),
                Globals.scale,
                //boomerangEffects[i],
                SpriteEffects.None,
                0f
            );
            }

            if (i < 2)
            {
                i++;
            }
            else
            {
                i = 0;

            }
        }
        }
    }

