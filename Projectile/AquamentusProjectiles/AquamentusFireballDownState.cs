using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Keese;
using System;
using Sprint2_Attempt3.Enemy.Aquamentus;

namespace Sprint2_Attempt3.Projectile.AquamentusProjectiles;

internal class AquamentusFireballDownState : IEnemyProjectileState
{
    private AquamentusFireball AquamentusFireball;
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



    public AquamentusFireballDownState(AquamentusFireball AquamentusFireball)
    {
        this.AquamentusFireball = AquamentusFireball;
        enemyProjectileSpriteFactory = new EnemyProjectileSpriteFactory();
        sprite = EnemyProjectileSpriteFactory.Instance.MovingFireball();

        timeSinceLastUpdate = 0;
        spriteIndex = 0;
        currentFrame = 0;
        currentFrame2 = 0;
        //finished = false;
        goDown = AquamentusFireball.GoDown;
        change = Globals.fireballSpeed;

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
        if (currentFrame < Globals.fireballSpriteSwitchSpeed)
        {
            currentFrame2++;
            spriteIndex = currentFrame2 / 10;
            if (spriteIndex > 7)
            {
                spriteIndex = 0;
                currentFrame2 = 0;

            }
            goDown = AquamentusFireball.GoDown;
            if (goDown)
            {
                AquamentusFireball.Position2 = new Vector2(AquamentusFireball.Position2.X, AquamentusFireball.Position2.Y + change);
                if (AquamentusFireball.Position2.Y >= 400)
                {
                    AquamentusFireball.GoDown = false;
                }
            }
            else
            {
                AquamentusFireball.Position2 = new Vector2(AquamentusFireball.Position2.X, AquamentusFireball.Position2.Y - change);
                if (AquamentusFireball.Position2.Y <= AquamentusFireball.InitialY + 17)
                {
                    Aquamentus.end = true;
                    AquamentusFireball.GoDown = true;
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
        sprite.Draw(spriteBatch, (int)AquamentusFireball.Position2.X + 6, (int)AquamentusFireball.Position2.Y + 18, Globals.AquamentusFireballLeft[spriteIndex], Globals.AquamentusFireballLeftEffects[spriteIndex], Globals.originsLeft[spriteIndex]);
    }
}
