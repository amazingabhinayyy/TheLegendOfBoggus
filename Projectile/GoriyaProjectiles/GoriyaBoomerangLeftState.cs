using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Keese;
using System;
using Sprint2_Attempt3.Enemy.Goriya;

namespace Sprint2_Attempt3.Projectile.GoriyaProjectiles;

internal class GoriyaBoomerangLeftState : IEnemyProjectileState
{
    private GoriyaBoomerang goriyaBoomerang;
    private IEnemyProjectileSprite sprite;

    private static EnemyProjectileSpriteFactory enemyProjectileSpriteFactory;
    private bool goLeft;
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



    public GoriyaBoomerangLeftState(GoriyaBoomerang goriyaBoomerang)
    {
        this.goriyaBoomerang = goriyaBoomerang;
        enemyProjectileSpriteFactory = new EnemyProjectileSpriteFactory();
        sprite = EnemyProjectileSpriteFactory.Instance.MovingBoomerang();

        timeSinceLastUpdate = 0;
        spriteIndex = 0;
        currentFrame = 0;
        currentFrame2 = 0;
    
        goLeft = goriyaBoomerang.GoLeft;
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
            goLeft = goriyaBoomerang.GoLeft;
            if (goLeft)
            {
                goriyaBoomerang.Position2 = new Vector2(goriyaBoomerang.Position2.X - change, goriyaBoomerang.Position2.Y);
                if (goriyaBoomerang.Position2.X <= 10)
                {
                    goriyaBoomerang.GoLeft = false;
                }
            }
            else
            {
                goriyaBoomerang.Position2 = new Vector2(goriyaBoomerang.Position2.X + change, goriyaBoomerang.Position2.Y);
                if (goriyaBoomerang.Position2.X >= goriyaBoomerang.InitialX - 9)
                {
                    goriyaBoomerang.Throwing = false;
                    goriyaBoomerang.GoLeft = true;
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
        sprite.Draw(spriteBatch, (int)goriyaBoomerang.Position2.X - 9, (int)goriyaBoomerang.Position2.Y + 8, Globals.GoriyaBoomerangLeft[spriteIndex]);
    }
}
