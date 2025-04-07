using OOPConsoleProject.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public static class Game
    {
        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;

        private static bool gameOver;

        public static void Run()
        {
            Start();

            while (gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }

            End();
        }

        /// <summary>
        /// 게임의 시작 작업 진행
        /// </summary>
        private static void Start()
        {
            // 게임 설정
            gameOver = false;

            // 씬 설정
            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("Title", new TItleScene());

            curScene = sceneDic["Title"];
        }

        /// <summary>
        /// 게임의 마무리 작업 진행
        /// </summary>
        private static void End()
        {

        }
    }
}
