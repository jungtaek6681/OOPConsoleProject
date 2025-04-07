using OOPConsoleProject.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Items
{
    public class Potion : Item
    {
        public Potion(Vector2 position)
            : base('I', position)
        {
            name = "포션";
            description = "소량의 체력을 회복하는 아이템";
        }

        public override void Use()
        {
            Game.Player.Heal(30);
        }
    }
}
