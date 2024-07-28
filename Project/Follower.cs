using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Follower : Ally
    {
        public int Buff_attack;
        public int Buff_hp;
        Follower()
        {
            
            armor = 5;
            Buff_attack = 1;
            Buff_hp = 10;
            hp = 30;
            attack = 5;
            set_nick_name("ally_1");
            class_name = "Follower";
        }

        public int buff_attack()
        {
            return Buff_attack;
        }
        public int heal()
        {
            return 5;
        }
        public int buff_hp()
        {
            return Buff_hp;
        }
        public int give_armor()
        {
            return armor;
        }
    }
}

