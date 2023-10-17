using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Enemy
{
    public interface IEnemy : IGameObject
    {
        public static Rectangle Position { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Generate();
        public void Spawn();
        public void ChangeDirection();
        public void ChangeAttackedStatus();
        public void Kill();
        public void Update();
        public void Draw(SpriteBatch spriteBatch);
    }
}
