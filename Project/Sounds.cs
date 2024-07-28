using System.Media;


namespace Project
{
    internal class Sounds
    {
        SoundPlayer hit= new SoundPlayer(Properties.Resources.Laser_attack);
        SoundPlayer miss = new SoundPlayer(Properties.Resources.Block);
        SoundPlayer Boom = new SoundPlayer(Properties.Resources.Boom_1);
        SoundPlayer Skill;

        public Sounds(string class_name)
        {
            if (class_name == "Warrior")
            {
                hit = new SoundPlayer(Properties.Resources.sword_hit);
                miss = new SoundPlayer(Properties.Resources.sword_swooshaiff);
            }
            else if (class_name == "Archer")
            {
                hit = new SoundPlayer(Properties.Resources.arrow_impact);
                miss = new SoundPlayer(Properties.Resources.Arrow_miss);
            }
            else if(class_name == "Demon bat")
            {
                hit = new SoundPlayer(Properties.Resources.Bat_attack);
                Skill=new SoundPlayer(Properties.Resources.Demonic_bite);
            }
            else if(class_name == "Blub")
            {
                hit= new SoundPlayer(Properties.Resources.Blub_attack);
                Skill = new SoundPlayer(Properties.Resources.Water_shot);
            }
            else if( class_name == "Ogre")
            {
                hit = new SoundPlayer(Properties.Resources.Ogre_Basic);
                Skill = new SoundPlayer(Properties.Resources.Rage_attack);
            }
            else if (class_name == "Cerberus")
            {
                hit = new SoundPlayer(Properties.Resources.Wolf_Attack);
                Skill = new SoundPlayer(Properties.Resources.Flamethrower);
            }
            else if (class_name == "Shadow knight")
            {
                hit = new SoundPlayer(Properties.Resources.shadowKnight_attack);
                Skill = new SoundPlayer(Properties.Resources.Shadow_slash);
            }
            else if (class_name == "BOSS")
            {
                hit = new SoundPlayer(Properties.Resources.boss_attack);
                Skill = new SoundPlayer(Properties.Resources.Laser_attack);
            }
            else if (class_name == "Minion")
            {
                hit= new SoundPlayer(Properties.Resources.Mimic_attack);
            }
     
        }
        public void play_hit()
        {
            hit.Play();
        }
        public void play_miss()
        {
            miss.Play();
        }
        public void play_Boom()
        {
            Boom.Play();
        }
        public void play_Skill()
        {
        Skill.Play();
        }
}
}
