using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h34101096_practice_5_2
{
    class Player1_c : Chess
    {
        public Player1_c()
        {
            hp = 90;
            mp = 10;
            atk = 30;
            atkRange = 3;
            moveRange = 1;
        }

        public override void Skill()
        {
            mp -= 10;
            atkRange++;
        }
    }
}
