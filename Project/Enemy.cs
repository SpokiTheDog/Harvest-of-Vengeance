using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Enemy : Entity
    {
        public int xp_gain;
        public string loot="None";
        public int skill_1_dmg;
        public int Skill_cd1 = 0;
        public string skill;
        

        public Enemy(int player_level,string nick_name1)
        {
            dice = 20;
            hp = 60 + (5 * player_level);
            max_hp = hp;
            attack=5+(2*player_level);
            skill_1_dmg = 20;
            class_name = nick_name1;
            nick_name = nick_name1;
            xp_gain = 100;
            if (player_level > 1)
            {
                xp_gain = (100+(player_level*10))/player_level;
            }
            sound = new Sounds(class_name);
            if (nick_name == "Demon bat")
            {
                skill = "Demonic bite";
                
            }
            else if(nick_name == "Blub")
            {
                skill = "Water Shot";
            }
            else if (nick_name == "Ogre")
            {
                skill = "Rage Attack";

            }
            else if (nick_name == "Cerberus")
            {
                skill = "Flame breath";

            }
            else if (nick_name == "Shadow kight")
            {
                skill = "Shadow slash";
            }

        }
        public int get_xp_gain()
        {
            return xp_gain;
        }
        public string get_loot() {
            return loot; 
        }
        public int Choose_action()
        {
            if (this.class_name == "Minion")
            {
                return 0;
            }
            else if (latest_roll >=15)
            {
                if (Skill_cd1 == 0)
                {
                    return 1;
                    
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        public void Update_cd()
        {
            if (Skill_cd1 > 0)
            {
                Skill_cd1--;
            }
        }

        public bool using_Skill(Entity defender)
        {
            Skill_cd1 = 3;
            if (defender.latest_roll >= this.latest_roll)
            {

                return false;
            }
            else
            {
                defender.hp -= this.skill_1_dmg;
                return true;
            }
        }

    }
}
