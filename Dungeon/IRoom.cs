using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Dungeon.Rooms;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Dungeon
{
    public interface IRoom
    {
        private static List<IGameObject> gameObjects;
        public void Update();
        public void Draw(SpriteBatch spriteBatch);
        public void SwitchToNextRoom();
        public void SwitchToPrevRoom();
        public void SwitchToNorthRoom();
        public void SwitchToSouthRoom();
        public void SwitchToEastRoom();
        public void SwitchToWestRoom();
        public void SwitchToLowerRoom();
        public void SwitchToUpperRoom();
        public DungeonRoom getDungeonRoom();
       
    }
}
