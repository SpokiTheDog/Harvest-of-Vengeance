using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Project
{
    internal class Boss : Enemy
    {
        
        public int Summon_cd = 0;
       
        public Boss(int player_level, string nick_name1) : base(player_level, nick_name1)
        {
            hp = 500;
            attack = 30;
            max_hp = hp;
            class_name = "BOSS";
            nick_name = nick_name1;
            Skill_cd1 = 0;
            Summon_cd = 0;
            dice = 20;
            skill = "Death ray";
            skill_1_dmg = 50;
            sound = new Sounds(class_name);
        }
        public Minion Summon_minion(int level)
         {
                Summon_cd = 5;
                Minion Mini = new Minion(level, "Mimic");
                return Mini;
         }
         public new int Choose_action()
         {
            if (latest_roll >= 15)
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
            else if (latest_roll <= 5)
            {
                if (Summon_cd == 0)
                {
                    
                    return 2;
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
        public new void  Update_cd()
        {
            
            if(Summon_cd >0)
            {
                Summon_cd--;
            }
        }
    }

    
}
