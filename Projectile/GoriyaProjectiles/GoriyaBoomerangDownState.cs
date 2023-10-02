using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Keese;
using System;
using Sprint2_Attempt3.Enemy.Goriya;

namespace Sprint2_Attempt3.Projectile.GoriyaProjectiles;

internal class GoriyaBoomerangDownState : IEnemyProjectileState
{
    private GoriyaBoomerang goriyaBoomerang;
    private IEnemyProjectileSprite sprite;

    private static EnemyProjectileSpriteFactory enemyProjectileSpriteFactory;
    private bool goDown;
    /*private bool finished;
    public bool Finished
    {
        get { return finished; }
        set { finished = value; }
    }*/
    private int timeSinceLastUpdate;
    private int spriteIndex;
    private int currentFrame;
    private int currentFrame2;
    private int change;



    public GoriyaBoomerangDownState(GoriyaBoomerang goriyaBoomerang)
    {
        this.goriyaBoomerang = goriyaBoomerang;
        enemyProjectileSpriteFactory = new EnemyProjectileSpriteFactory();
        sprite = EnemyProjectileSpriteFactory.Instance.MovingBoomerang();

        timeSinceLastUpdate = 0;
        spriteIndex = 0;
        currentFrame = 0;
        currentFrame2 = 0;
        //finished = false;
        goDown = goriyaBoomerang.GoDown;
        change = Globals.boomerangSpeed;

    }


    public void Update(/*gameTime gametime*/)
    {
        /*
        timeSinceLastUpdate += gametime.ElapsedGameTime;
        spriteIndex = (int)(timeSinceLastUpdate / (0.5f));
        if (spriteIndex > 7)
        {
            spriteIndex = 0;
            timeSinceLastUpdate = 0;
        }*/
        currentFrame++;
        if (currentFrame < Globals.boomerangSpriteSwitchSpeed)
        {
            currentFrame2++;
            spriteIndex = currentFrame2 / 10;
            if (spriteIndex > 7)
            {
                spriteIndex = 0;
                currentFrame2 = 0;

            }
            goDown = goriyaBoomerang.GoDown;
            if (goDown)
            {
                goriyaBoomerang.Position2 = new Vector2(goriyaBoomerang.Position2.X, goriyaBoomerang.Position2.Y + change);
                if (goriyaBoomerang.Position2.Y >= 400)
                {
                    goriyaBoomerang.GoDown = false;
                }
            }
            else
            {
                goriyaBoomerang.Position2 = new Vector2(goriyaBoomerang.Position2.X, goriyaBoomerang.Position2.Y - change);
                if (goriyaBoomerang.Position2.Y <= goriyaBoomerang.InitialY + 17)
                {
                    Goriya.end = true;
                    goriyaBoomerang.GoDown = true;
                    //finished = true;

                }
            }
        }
        else
        {
            currentFrame = 0;
        }

    }
    public void Draw(SpriteBatch spriteBatch)
    {
        Globals.currentIndex = spriteIndex;
        sprite.Draw(spriteBatch, (int)goriyaBoomerang.Position2.X + 6, (int)goriyaBoomerang.Position2.Y + 18, Globals.GoriyaBoomerangLeft[spriteIndex]);
    }
}
