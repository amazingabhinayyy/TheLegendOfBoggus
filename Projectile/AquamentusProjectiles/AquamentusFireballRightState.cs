using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Keese;
using System;
using Sprint2_Attempt3.Enemy.Aquamentus;

namespace Sprint2_Attempt3.Projectile.AquamentusProjectiles;

internal class AquamentusFireballRightState : IEnemyProjectileState
{
    private AquamentusFireball AquamentusFireball;
    private IEnemyProjectileSprite sprite;

    private static EnemyProjectileSpriteFactory enemyProjectileSpriteFactory;
    private bool goRight;
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



    public AquamentusFireballRightState(AquamentusFireball AquamentusFireball)
    {
        this.AquamentusFireball = AquamentusFireball;
        enemyProjectileSpriteFactory = new EnemyProjectileSpriteFactory();
        sprite = EnemyProjectileSpriteFactory.Instance.MovingFireball();

        timeSinceLastUpdate = 0;
        spriteIndex = 0;
        currentFrame = 0;
        currentFrame2 = 0;
        //finished = false;
        goRight = AquamentusFireball.GoRight;
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
            goRight = AquamentusFireball.GoRight;
            if (goRight)
            {
                AquamentusFireball.Position2 = new Vector2(AquamentusFireball.Position2.X + change, AquamentusFireball.Position2.Y);
                if (AquamentusFireball.Position2.X >= 490)
                {
                    AquamentusFireball.GoRight = false;
                }
            }
            else
            {
                AquamentusFireball.Position2 = new Vector2(AquamentusFireball.Position2.X - change, AquamentusFireball.Position2.Y);
                if (AquamentusFireball.Position2.X <= AquamentusFireball.InitialX + 17)
                {
                    Aquamentus.end = true;
                    AquamentusFireball.GoRight = true;
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
        sprite.Draw(spriteBatch, (int)AquamentusFireball.Position2.X + 9, (int)AquamentusFireball.Position2.Y + 8, Globals.AquamentusFireballLeft[spriteIndex], Globals.AquamentusFireballLeftEffects[spriteIndex], Globals.originsLeft[spriteIndex]);
    }
}
