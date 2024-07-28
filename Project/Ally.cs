using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Ally : Entity
    {
        public int armor;
        public int xp;
        public int max_xp;
        public int level;
        public Ally()
        {
        xp = 0;
        max_xp = 100; 
        level = 1;
        dice = 20;
        }
        public void level_up()
        {
            max_hp += 10;
            hp = max_hp;
            attack += 2;
            level++;
            xp=xp-max_xp;
            max_xp += level * 10;

        }
        public void gain_xp(int xp_gain)
        {
            xp += xp + xp_gain;
            if (xp >= max_xp)
            {
                level_up();
            }

        }

    }
}
