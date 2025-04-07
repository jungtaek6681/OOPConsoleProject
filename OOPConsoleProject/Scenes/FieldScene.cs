using OOPConsoleProject.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public abstract class FieldScene : BaseScene
    {
        private ConsoleKey input;

        protected string[] mapData;
        protected bool[,] map;

        protected List<GameObject> gameObjects;

        public override void Render()
        {
            PrintMap();
            foreach (GameObject go in gameObjects)
            {
                go.Print();
            }

            Game.Player.Print();

            Console.SetCursorPosition(0, map.GetLength(0) + 2);
            Game.Player.inventory.PrintALL();
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            Game.Player.Move(input);
        }

        public override void Result()
        {
            foreach(GameObject go in gameObjects)
            {
                if (Game.Player.position == go.position)
                {
                    go.Interact(Game.Player);
                    if (go.isOnce == true)
                    {
                        gameObjects.Remove(go);
                    }
                    break;
                }
            }
        }

        private void PrintMap()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y,x] == true)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('#');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
