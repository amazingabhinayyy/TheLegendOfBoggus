using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using System.IO;
using System.Reflection;
using Sprint2_Attempt3.Blocks.BlockSprites;

namespace Sprint2_Attempt3.Dungeon
{
    public class GenerateDungeonObjects : IGenerateDungeonObjects
    {
        private int cornerX = Globals.cornerX;
        private int width = Globals.width;
        private int cornerY = Globals.cornerY;
        private int height = Globals.height;
        public struct GameObjectPair
        {
            public IGameObject Object { get; }
            public Rectangle Rect { get; }
            public GameObjectPair(IGameObject obj, Rectangle rectangle)
            {
                Object = obj;
                Rect = rectangle;
            }
        }
        public void UpdateObjectsList(List<GameObjectPair> objects, int room)
        {
            StreamReader reader = new StreamReader("DungeonCSV.csv");
            
            for(int i = 1; i<1+7*(room-1); i++)
            {
                reader.ReadLine();
            }

            for(int i = 0; i<7; i++)
            {
                string line = reader.ReadLine();
                string[] contents = line.Split(',');
                
                for(int j=0; j<contents.Length; j++)
                {
                    string obj = contents[j];
                    if (obj.Length > 0)
                    {
                        switch (obj)
                        {
                            case "rightStatue":
                                Rectangle
                                GameObjectPair pair = new GameObjectPair(new SideChunk(),new Rectangle(cornerX+j*width,cornerY+i*height,width,height) );
                                break;
                        }
                    }
                }

            }
               
        }



    }
}
