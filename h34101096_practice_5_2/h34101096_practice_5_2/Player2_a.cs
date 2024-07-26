using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h34101096_practice_5_2
{
    class Player2_a : Chess
    {
        public Player2_a()
        {
            hp = 100;
            mp = 15;
            atk = 30;
            atkRange = 1;
            moveRange = 2;
        }

        public override void Skill()
        {
            hp += 10;
            mp -= 10;
        }
    }
}
