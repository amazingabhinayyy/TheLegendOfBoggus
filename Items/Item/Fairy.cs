using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Player.Interfaces;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class Fairy : ItemSecondary 
    {
        private static Rectangle[] fairies = new Rectangle[] { new Rectangle(40, 0, 8, 16), new Rectangle(48, 0, 8, 16) };
        private int changeMovementTimer;
        private bool movingUpOrDown;
        private int vector;
        private int timer;
        public Fairy(Vector2 position, bool exists)
        {
            this.sourceRectangle = fairies[0];
            this.Position = new Rectangle((int)position.X, (int)position.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            this.exists = exists;
            this.spawned = false;
            sprite = ItemSpriteFactory.Instance.CreateSpawnItemSprite();
            changeMovementTimer = 40;
            vector = 0;
            timer = 0;
        }

        public override void Update()
        {
            int randMovment = new Random().Next(0, 4);
            if (this.count == 0)
            {
                sprite = ItemSpriteFactory.Instance.CreateItemSprite();
                spawned = true;
            }
            if (spawned)
            {
                count++;
                sourceRectangle = fairies[Globals.FindIndex(count % (fairies.Length * AnimateRate), AnimateRate, fairies.Length)];
                Position.Width = (int)(sourceRectangle.Width * Globals.scale);
                Position.Height = (int)(sourceRectangle.Height * Globals.scale);

            }
            if (changeMovementTimer <= 0)
            {
                if (randMovment == 0)
                {
                    vector = 3;
                    movingUpOrDown = false;
                }
                else if (randMovment == 1)
                {
                    vector = 3;
                    movingUpOrDown = true;
                }
                else if (randMovment == 2)
                {
                    vector = -3;
                    movingUpOrDown = false;
                }
                else if (randMovment == 3)
                {
                    vector = -3;
                    movingUpOrDown = true;
                }
                changeMovementTimer = 20;
            }
            if(movingUpOrDown)
            {
                Position.Y += vector;
            }
            else
            {
                Position.X += vector;
            }
            changeMovementTimer--;
            timer++;
            if(timer >= 2000)
            {
                Despawn();
            }
        }
    }
}
