using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h34101096_practice_5_2
{
    class Player2_b : Chess
    {
        public Player2_b()
        {
            hp = 70;
            mp = 25;
            atk = 20;
            atkRange = 2;
            moveRange = 2;
        }

        public override void Skill()
        {
            mp -= 10;
            atk *= 2;
        }
    }
}
