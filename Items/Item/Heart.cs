using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Sprint2_Attempt3.Inventory;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class Heart : ItemSecondary 
    {
        public Heart(Vector2 position, bool exists)
        {
            this.sourceRectangle = Globals.heartSrc;
            this.Position = new Rectangle((int)position.X, (int)position.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            this.exists = exists;
            this.spawned = false;
            sprite = ItemSpriteFactory.Instance.CreateSpawnItemSprite();
        }

        public override void Update()
        {
            if (this.count == 0)
            {
                sprite = ItemSpriteFactory.Instance.CreateItemSprite();
                spawned = true;
            }
            if (spawned)
            {
                count++;
                if (count <= 10)
                {
                    if (count == 5)
                    {
                        sourceRectangle = Globals.heartSrc;
                        Position.Width = (int)(sourceRectangle.Width * Globals.scale);
                        Position.Height = (int)(sourceRectangle.Height * Globals.scale);
                    }
                    else if (count == 10)
                    {
                        sourceRectangle = Globals.blueheartSrc;
                        Position.Width = (int)(sourceRectangle.Width * Globals.scale);
                        Position.Height = (int)(sourceRectangle.Height * Globals.scale);
                    }
                }
                else
                {
                    count = 0;
                }
            }
        }

        public override void Collect()
        {
            base.Collect();
            if (InventoryController.GetCount("HeartContainer") - InventoryController.GetCount("Heart") < 0) {
                if (InventoryController.GetCount("HeartContainer") - InventoryController.GetCount("Heart") < -.5)
                {
                    InventoryController.DecrementCount("Heart");
                }
                else
                {
                    InventoryController.DecrementCount("Heart", .5f);
                }
            }
        }
    }
}
