using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Projectiles;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Keese;


namespace Sprint2_Attempt3.Projectile;

internal class GoriyaBoomerangLeftState : IEnemyProjectileState
{
    private GoriyaBoomerang goriyaBoomerang;
    private IEnemyProjectileSprite sprite;
    private Rectangle[] sourceRectangles = Globals.GoriyaBoomerangLeft;
    private static EnemyProjectileSpriteFactory enemyProjectileSpriteFactory;
    private int timeSinceLastUpdate;
    private int spriteIndex;
    private int currentFrame;
    private int currentFrame2;

    public GoriyaBoomerangLeftState(GoriyaBoomerang goriyaBoomerang)
    {
        this.goriyaBoomerang = goriyaBoomerang;
        enemyProjectileSpriteFactory = new EnemyProjectileSpriteFactory();
        sprite = EnemyProjectileSpriteFactory.Instance.CreateMovingLeftBoomerang();
        timeSinceLastUpdate = 0;
        spriteIndex = 0;
        this.currentFrame = 0;
        this.currentFrame2 = 0;
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
        if (currentFrame < 30)
        {
            currentFrame2++;
            spriteIndex = (int)currentFrame2 / 10;
            if (spriteIndex > 7)
            {
                spriteIndex = 0;
               
            }
           
        }
        else
        {
            currentFrame = 0;
        }

    }
    public void Draw(SpriteBatch spriteBatch)
    {
        sprite.Draw(spriteBatch, (int)goriyaBoomerang.Position.X, (int)goriyaBoomerang.Position.Y, sourceRectangles[spriteIndex]);
    }
}
