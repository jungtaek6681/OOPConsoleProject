using OOPConsoleProject.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class ForestFieldScene : FieldScene
    {
        public ForestFieldScene()
        {
            name = "ForestField";

            mapData = new string[]
            {
                "########",
                "#      #",
                "#      #",
                "#   ## #",
                "#   #  #",
                "########"
            };

            map = new bool[6, 8];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }
            }

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("NormalField", 'N', new Vector2(1, 1)));
        }

        public override void Enter()
        {
            if (Game.prevSceneName == "NormalField")
            {
                Game.Player.position = new Vector2(1, 1);
            }
            Game.Player.map = map;
        }
    }
}
