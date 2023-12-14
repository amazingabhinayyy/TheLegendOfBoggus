using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Keese;
using System;
using Sprint2_Attempt3.Enemy.Ganon;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Collision;

namespace Sprint2_Attempt3.Enemy.Projectile.GanonProjectiles;

internal class GanonFireballIdleState : IEnemyProjectileState
{
    private GanonFireball GanonFireball;
    private IEnemyProjectileSprite sprite;
    private int index;
    private double elapsedTime;
    
    //private int horDistance = 12;

    public GanonFireballIdleState(GanonFireball GanonFireball)
    {
        this.GanonFireball = GanonFireball;
        sprite = EnemyProjectileSpriteFactory.Instance.MovingGanonFireball();
        index = 0;

        elapsedTime = 0;

    }
    public void Update()
    {
        GameTime gameTime = GanonFireball.GameTime;
        double time = gameTime.ElapsedGameTime.TotalSeconds;
        elapsedTime += time;
        if (elapsedTime > 0.10f)
        {
            GanonFireball.State = new GanonFireballMovingState(GanonFireball);
        }
       
    }
    public void Draw(SpriteBatch spriteBatch)
    {
        sprite.Draw(spriteBatch, (int)GanonFireball.Position2.X, (int)(GanonFireball.Position2.Y), GanonFireball.GanonFireballs[0]);
    }
}
