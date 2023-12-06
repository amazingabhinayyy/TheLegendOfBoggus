﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Sounds;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class Bomb : ItemSecondary
    {
        private static Rectangle src = new Rectangle(135, 0, 9, 15);
        public Bomb(Vector2 position, bool exists)
        {
            this.sourceRectangle = src;
            this.Position = new Rectangle((int)position.X, (int)position.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            this.exists = exists;
            this.spawned = false;
            sprite = ItemSpriteFactory.Instance.CreateSpawnItemSprite();
        }
        public override void Collect()
        {
            base.Collect();
            SoundFactory.PlaySound(SoundFactory.Instance.getItem);
        }
        public override void Update()
        {
            if (count == 0)
            {
                sprite = ItemSpriteFactory.Instance.CreateBombSprite();
                spawned = true;
            }
        }
    }
}
