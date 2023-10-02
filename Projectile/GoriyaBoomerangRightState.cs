using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Keese;
using System;
using Sprint2_Attempt3.Enemy.Goriya;

namespace Sprint2_Attempt3.Projectile;

internal class GoriyaBoomerangRightState : IEnemyProjectileState
{
    private GoriyaBoomerang goriyaBoomerang;
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
  


    public GoriyaBoomerangRightState(GoriyaBoomerang goriyaBoomerang)
    {
        this.goriyaBoomerang = goriyaBoomerang;
        enemyProjectileSpriteFactory = new EnemyProjectileSpriteFactory();
        sprite = EnemyProjectileSpriteFactory.Instance.MovingBoomerang();
        
        timeSinceLastUpdate = 0;
        spriteIndex = 0;
        this.currentFrame = 0;
        this.currentFrame2 = 0;
        //finished = false;
        goRight = goriyaBoomerang.GoRight;
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
            spriteIndex = (int)currentFrame2 / 10;
            if (spriteIndex > 7)
            {
                spriteIndex = 0;
                currentFrame2 = 0;
               
            }
            goRight = goriyaBoomerang.GoRight;
            if (goRight)
            {
                goriyaBoomerang.Position2 = new Vector2(goriyaBoomerang.Position2.X + change, goriyaBoomerang.Position2.Y);
                if (goriyaBoomerang.Position2.X>=490)
                {
                    goriyaBoomerang.GoRight = false;
                }
            }
            else 
            {
                goriyaBoomerang.Position2 = new Vector2(goriyaBoomerang.Position2.X - change, goriyaBoomerang.Position2.Y);
                if (goriyaBoomerang.Position2.X <= goriyaBoomerang.InitialX + 17)
                {
                    Goriya.end = true;
                    goriyaBoomerang.GoRight = true;
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
        sprite.Draw(spriteBatch, (int)goriyaBoomerang.Position2.X+9, (int)goriyaBoomerang.Position2.Y+8, Globals.GoriyaBoomerangLeft[spriteIndex], Globals.GoriyaBoomerangLeftEffects[spriteIndex], Globals.originsLeft[spriteIndex]);
    }
}
