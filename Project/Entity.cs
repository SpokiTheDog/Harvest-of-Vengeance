using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Entity
    {
        public int hp;
        public int max_hp;
        public int attack;
        public string nick_name;
        public string class_name;
        public int latest_roll;
        public int dice;
        public Sounds sound;
        public Entity()
        {
            this.hp = 100;
            this.max_hp = 100;
            this.attack = 10;
            nick_name= string.Empty;
            class_name = string.Empty;
            latest_roll = 0;
        }
            int get_hp()
        {
            return hp;
        }
            int get_attack()
        {
            return attack;
        }
        int get_max_hp()
        {
            return max_hp;
        }
        string get_nickname()
        {
                return nick_name;
        }
         string get_class_name()
        {
            return class_name;
        }
        public bool Using_attack(Entity defender)
        {
            if (defender.latest_roll >= this.latest_roll)
            {

                return false;
            }
            else
            {
                defender.hp -= this.attack;
                return true;
            }
        }
        void set_hp(int hp)
        {
            this.hp = hp;
        }

       public void set_nick_name(string a)
        {
            this.nick_name = a;
        }

        public int dice_roll()
        {
            Random rnd = new Random();
            latest_roll = rnd.Next(1, dice);
            return latest_roll;
        }
    }
}


