using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Player : Ally
    {

        public int healcooldown = 0;
        public Player() { }

        public Player(int _hp, int _maxhp, int _xp,int _maxxp, int _damage, int _level, string _nick_name, string _class_name)
        {
            hp = _hp;
            max_hp = _maxhp;
            xp = _xp;
            max_xp = _maxxp;
            attack = _damage;
            level = _level;
            nick_name=_nick_name;
            class_name = _class_name;
            sound = new Sounds(class_name);
        }
        public Player(int maxhp,int atk,string Nick_name,string Class_name)
        {
            set_nick_name(Nick_name);
            class_name = Class_name;
            hp=maxhp;
            max_hp = maxhp;
            attack = atk;
            armor = 0;
            sound = new Sounds(class_name);
        }
       
        public bool heal()
        {

            if (healcooldown == 0)
            {
                dice_roll();
                int heal_amount = latest_roll + (4 * (level));

                if (hp + heal_amount > max_hp)
                {
                    hp = max_hp;
                }
                else
                {
                    hp += heal_amount;
                }
                healcooldown = 3;
                return true;
            }
            return false;
        }
        public void Update_cd()
        {
            if (healcooldown > 0)
            {
                healcooldown--;
            }
        }

    }
}
