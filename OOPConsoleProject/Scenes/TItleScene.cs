using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class TItleScene : BaseScene
    {
        public override void Render()
        {
            Console.WriteLine("********************");
            Console.WriteLine("*    레전드 RPG    *");
            Console.WriteLine("********************");
            Console.WriteLine();
            Console.WriteLine("계속하려면 아무키나 누르세요...");
        }

        public override void Input()
        {
            Console.ReadKey(true);
        }

        public override void Update()
        {
            
        }

        public override void Result()
        {
            
        }
    }
}
