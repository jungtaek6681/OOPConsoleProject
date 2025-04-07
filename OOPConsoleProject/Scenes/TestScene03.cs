using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class TestScene03 : BaseScene
    {
        private ConsoleKey input;

        public override void Render()
        {
            Console.WriteLine("테스트 03 씬입니다.");
            Console.WriteLine();
            Console.WriteLine("1. 테스트 01 씬으로 이동");
            Console.WriteLine("2. 테스트 02 씬으로 이동");
            Console.Write("선택지를 입력하세요 : ");
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {

        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Util.PressAnyKey("테스트 01 씬으로 이동합니다.");
                    Game.ChangeScene("Test01");
                    break;
                case ConsoleKey.D2:
                    Util.PressAnyKey("테스트 02 씬으로 이동합니다.");
                    Game.ChangeScene("Test02");
                    break;
            }
        }
    }
}
