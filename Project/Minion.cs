using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Minion : Enemy
    {
        public Minion(int player_level, string nick_name1) : base(player_level, nick_name1)
        {
            class_name = "Minion";
            nick_name = nick_name1;
            hp /= 3;
            attack /= 3;
            max_hp = hp;
            xp_gain /= 3;
            sound = new Sounds(class_name);
        }
    }
}
