using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Keese;
using System;
using Sprint2_Attempt3.Enemy.Aquamentus;

namespace Sprint2_Attempt3.Projectile.AquamentusProjectiles;

internal class AquamentusFireballUpState : IEnemyProjectileState
{
    private AquamentusFireball AquamentusFireball;
    private IEnemyProjectileSprite sprite;

    private static EnemyProjectileSpriteFactory enemyProjectileSpriteFactory;
    private bool goUp;
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



    public AquamentusFireballUpState(AquamentusFireball AquamentusFireball)
    {
        this.AquamentusFireball = AquamentusFireball;
        enemyProjectileSpriteFactory = new EnemyProjectileSpriteFactory();
        sprite = EnemyProjectileSpriteFactory.Instance.MovingFireball();

        timeSinceLastUpdate = 0;
        spriteIndex = 0;
        currentFrame = 0;
        currentFrame2 = 0;
        //finished = false;
        goUp = AquamentusFireball.GoUp;
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
            goUp = AquamentusFireball.GoUp;
            if (goUp)
            {
                AquamentusFireball.Position2 = new Vector2(AquamentusFireball.Position2.X, AquamentusFireball.Position2.Y - change);
                if (AquamentusFireball.Position2.Y <= 18)
                {
                    AquamentusFireball.GoUp = false;
                }
            }
            else
            {
                AquamentusFireball.Position2 = new Vector2(AquamentusFireball.Position2.X, AquamentusFireball.Position2.Y + change);
                if (AquamentusFireball.Position2.Y >= AquamentusFireball.InitialY)
                {
                    Aquamentus.end = true;
                    AquamentusFireball.GoUp = true;
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
        sprite.Draw(spriteBatch, (int)AquamentusFireball.Position2.X + 6, (int)AquamentusFireball.Position2.Y - 18, Globals.AquamentusFireballUp[spriteIndex], Globals.AquamentusFireballLeftEffects[spriteIndex], Globals.originsLeft[spriteIndex]);
    }
}
