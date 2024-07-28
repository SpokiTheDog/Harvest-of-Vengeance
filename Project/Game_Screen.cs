using static System.Windows.Forms.AxHost;
using System.Xml.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Data.Common;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;


namespace Project

{

    public partial class Game_Screen : Form
    {
        bool End = false;
        int Time_passed = 0;
        Player player;
        List<Enemy> EnemyList = new List<Enemy> { };
        List<String> MonsterNames = new List<String>(5) { "Demon bat", "Blub", "Ogre", "Cerberus", "Shadow knight" };

        public Game_Screen()
        {
            player = new Player();
            InitializeComponent();
            GameFlow_textbox.Text = "You are a simple farmer,Your father has been murderded and devoured by the monsters roaming your fields,\n" + " You are on a mission to avange your father and slay all the monsters.";
            EnemyTab_tabControl.Visible = false;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            Arena_bg.SendToBack();
        }

        void Create_player()
        {
            if (Warrior_rb.Checked == true)
            {
                player = new Player(120, 8, Nickname_textbox.Text, "Warrior");
            }
            else if (Archer_rb.Checked == true)
            {
                player = new Player(80, 12, Nickname_textbox.Text, "Archer");
            }
            else
            {
                player = new Player(500, 30, Nickname_textbox.Text, "Easter Egg");
                player.nick_name = "Easter Egg";
            }

        }

        private void Game_Screen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start_Screen start_Screen = new Start_Screen();
            start_Screen.Show();
        }

        private void Create_button_Click(object sender, EventArgs e)
        {
            Create_player();
            Ally_Tabs.TabPages.RemoveByKey("Class_chooser");
            Player_nickname.Text = player.nick_name;
            Player_Class.Text = "Class=" + player.class_name;
            Player_Exp.Text = "EXP=" + player.xp.ToString() + "/" + player.max_xp.ToString();
            Player_Hp.Text = "HP=" + player.hp.ToString() + "/" + player.max_hp.ToString();
            Player_Attack.Text = "Attack=" + player.attack.ToString();
            Player_Level.Text = "Level=" + player.level.ToString();
            EnemyTab_tabControl.Visible = true;
            Save_button.Enabled = true;
            Game_timer.Enabled = true;

        }
        void encounter(String Monster_name)
        {
            if (player.healcooldown == 0)
            {
                heal_button.Enabled = true;
            }
            if (Monster_name == "Necromancer")
            {
                Boss BB = new Boss(player.level, "Necromancer");
                Monster_picture1.Image = Properties.Resources.ResourceManager.GetObject(Monster_name) as Image;
                Monster_picture1.SizeMode = PictureBoxSizeMode.StretchImage;
                Monster_picture1.BackColor = Color.Transparent;
                Monster_picture1.Parent = Arena_bg;
                Monster_picture1.Location = new Point(240, 130);
                EnemyList.Add(BB);
                new_enemy_tab(BB);
                Monster_picture1.Visible = true;
                Monster_picture1.BringToFront();
            }
            else
            {
                Enemy monster1 = new Enemy(player.level, Monster_name);
                Monster_picture1.Image = Properties.Resources.ResourceManager.GetObject(Monster_name) as Image;
                Monster_picture1.SizeMode = PictureBoxSizeMode.StretchImage;
                Monster_picture1.BackColor = Color.Transparent;
                Monster_picture1.Parent = Arena_bg;
                Monster_picture1.Location = new Point(240, 130);
                EnemyList.Add(monster1);
                new_enemy_tab(monster1);
                Monster_picture1.Visible = true;
                Monster_picture1.BringToFront();
            }
            Save_button.Enabled = false;
        }

        private void Game_Screen_Load(object sender, EventArgs e)
        {

        }
        void new_enemy_tab(Enemy enemy)
        {
            TabPage tb = new TabPage();
            Label Enemy_name = new Label();
            Label Enemy_hp = new Label();
            Label Enemy_attack = new Label();
            tb.Text = enemy.nick_name;
            tb.Controls.Add(Enemy_name);
            tb.Controls.Add(Enemy_hp);
            tb.Controls.Add(Enemy_attack);
            Enemy_name.Text = enemy.nick_name;
            Enemy_name.Left += 10;
            Enemy_name.Top += 10;
            Enemy_name.Size = new Size(150, 20);
            Enemy_hp.Text = "hp=" + enemy.hp + "/" + enemy.max_hp;
            Enemy_hp.Left += 10;
            Enemy_hp.Top += 50;
            Enemy_hp.Size = new Size(100, 20);
            Enemy_attack.Text = "attack=" + enemy.attack;
            Enemy_attack.Left += 120;
            Enemy_attack.Top += 50;
            Enemy_attack.Size = new Size(90, 20);
            EnemyTab_tabControl.TabPages.Add(tb);
            Arena_bg.Visible = true;
            GameFlow_textbox.Visible = false;

        }

        private void Demon_Bat_fight_button_Click(object sender, EventArgs e)
        {
            Demon_Bat_fight_button.Enabled = false;
            EnemyTab_tabControl.TabPages.Remove(Bounty_tab);
            Enemy_Chooser.Items.Add("Demon bat");
            Enemy_Chooser.Enabled = true;
            Arena_bg.Image = (Image)Properties.Resources.ResourceManager.GetObject("bat bg");
            Arena_bg.SizeMode = PictureBoxSizeMode.StretchImage;
            Demon_Bat_checkbox.Checked = true;
            Fight_Notes.Enabled = true;
            encounter(MonsterNames[0]);



        }



        private void Blub_fight_button_Click(object sender, EventArgs e)
        {
            EnemyTab_tabControl.TabPages.Remove(Bounty_tab);
            Enemy_Chooser.Items.Add("Blub");
            Enemy_Chooser.Enabled = true;
            Arena_bg.Image = (Image)Properties.Resources.ResourceManager.GetObject("Blub bg");
            Arena_bg.SizeMode = PictureBoxSizeMode.StretchImage;
            Blub_fight_button.Enabled = false;
            Blub_checkbox.Checked = true;
            Fight_Notes.Enabled = true;
            encounter(MonsterNames[1]);

        }

        private void Ogre_Click(object sender, EventArgs e)
        {
            EnemyTab_tabControl.TabPages.Remove(Bounty_tab);
            Enemy_Chooser.Items.Add("Ogre");
            Enemy_Chooser.Enabled = true;
            Arena_bg.Image = (Image)Properties.Resources.ResourceManager.GetObject("Ogre background");
            Arena_bg.SizeMode = PictureBoxSizeMode.StretchImage;
            Ogre_fight_button.Enabled = false;
            Ogre_checkbox.Checked = true;
            Fight_Notes.Enabled = true;
            encounter(MonsterNames[2]);
        }
        private void Cerberus_fight_button_Click(object sender, EventArgs e)
        {
            EnemyTab_tabControl.TabPages.Remove(Bounty_tab);
            Enemy_Chooser.Items.Add("Cerberus");
            Enemy_Chooser.Enabled = true;
            Arena_bg.Image = (Image)Properties.Resources.ResourceManager.GetObject("cerberus bg");
            Arena_bg.SizeMode = PictureBoxSizeMode.StretchImage;
            Cerberus_fight_button.Enabled = false;
            Cerberus_checkbox.Checked = true;
            Fight_Notes.Enabled = true;
            encounter(MonsterNames[3]);
        }
        private void Shadow_kight_fight_button_Click(object sender, EventArgs e)
        {
            EnemyTab_tabControl.TabPages.Remove(Bounty_tab);
            Enemy_Chooser.Items.Add("Shadow knight");
            Enemy_Chooser.Enabled = true;
            Arena_bg.Image = (Image)Properties.Resources.ResourceManager.GetObject("shadow bg");
            Arena_bg.SizeMode = PictureBoxSizeMode.StretchImage;
            Shadow_knight_fight_button.Enabled = false;
            Shadow_knight_checkbox.Checked = true;
            Fight_Notes.Enabled = true;
            encounter(MonsterNames[4]);
        }
        async void Attack_button_Click(object sender, EventArgs e)
        {

            heal_button.Enabled = false;
            int Enemy_index = select_enemy();
            player.dice_roll();
            EnemyList[Enemy_index].dice_roll();
            if (player.Using_attack(EnemyList[Enemy_index]))
            {
                Fight_Notes.Text = "Youv'e hit " + EnemyList[Enemy_index].nick_name + " for:" + player.attack + " Dmg";
                player.sound.play_hit();
                if (EnemyList[Enemy_index].hp > 0)
                {
                    shake(Enemy_index, false);
                }
                update_monster_lbl(Enemy_index);
            }
            else
            {
                Fight_Notes.Text = "Try again loser,You missed!";
                player.sound.play_miss();

            }
            d_20_combat(player, EnemyList[Enemy_index]);
            //await Task.Delay(1000);

            if (is_dead(EnemyList[Enemy_index]))
            {
                if (EnemyList[Enemy_index].class_name != "BOSS")
                {
                    update_monster_death(Enemy_index);
                    check_boss();
                }
                else
                {

                    update_monster_death(Enemy_index);
                    Game_timer.Enabled = false;
                    End = true;
                }

            }
            if (End == true && EnemyList.Count == 0)
            {
                update_highscore();
                string messege = "You won! click ok to start a new game\n  " + Elapsed_timer.Text;
                DialogResult dialog_box = MessageBox.Show(messege, "ok", MessageBoxButtons.OK);
                if (dialog_box == DialogResult.OK)
                {
                    this.Close();
                }
            }
            if (EnemyList.Count > 0)
            {
                for (int i = 0; i < EnemyList.Count; i++)
                {
                    await Task.Delay(1000);
                    Monster_attack(i);
                    if (player.hp <= 0)
                    {
                        break;
                    }
                }
            }
            player.Update_cd();
            if (EnemyList.Count > 0)
            {
                if (player.healcooldown == 0)
                {
                    heal_button.Enabled = true;
                }
                Enemy_Chooser.Enabled = true;
                Enemy_Chooser.SelectedIndex = 0;
                Attack_button.Enabled = true;
            }

            update_player_lbl();

        }
        bool is_dead(Entity Dc_entity)//During combat entity
        {
            if (Dc_entity.hp > 0)
            {
                return false;
            }
            else
            {
                Attack_button.Enabled = false;
                return true;
            }
        }

        private void update_player_lbl()
        {
            if (player.hp < 0)
            {
                player.hp = 0;
            }
            Player_Exp.Text = "EXP=" + player.xp.ToString() + "/" + player.max_xp.ToString();
            Player_Hp.Text = "HP=" + player.hp.ToString() + "/" + player.max_hp.ToString();
            Player_Attack.Text = "Attack=" + player.attack.ToString();
            Player_Level.Text = "Level=" + player.level.ToString();
            Heal_CD_label.Text = "Heal CD: " + player.healcooldown.ToString();
        }
        private void update_monster_lbl(int Enemy_index)
        {
            TabPage tb = EnemyTab_tabControl.TabPages[Enemy_index];
            if (EnemyList[Enemy_index].hp < 0)
            {
                EnemyList[Enemy_index].hp = 0;
            }
            tb.Controls[1].Text = "hp=" + EnemyList[Enemy_index].hp + "/" + EnemyList[Enemy_index].max_hp;
        }
        void label(Label new_label, string text)
        {
            new_label.Text = text;
        }

        private void PostTurn_interval_Tick(object sender, EventArgs e)
        {
            PostTurn_interval.Enabled = false;
            update_player_lbl();

        }

        private void Enemy_Chooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            Attack_button.Enabled = true;
        }

        private void Boss_fight_botton_Click(object sender, EventArgs e)
        {
            //BB stands for BigBoss
            Boss BB;
            EnemyTab_tabControl.TabPages.Remove(Bounty_tab);
            Enemy_Chooser.Items.Add("Necromancer");
            Enemy_Chooser.Enabled = true;
            Arena_bg.Image = (Image)Properties.Resources.ResourceManager.GetObject("boss_background");
            Arena_bg.SizeMode = PictureBoxSizeMode.StretchImage;
            encounter("Necromancer");
            Demon_Bat_checkbox.Checked = false;
        }

        private int select_enemy()
        {
            Enemy_Chooser.Enabled = false;
            Attack_button.Enabled = false;
            int Enemy_index;
            string name = Enemy_Chooser.SelectedItem.ToString();
            Enemy_index = EnemyList.FindIndex(a => a.nick_name == name);
            return Enemy_index;
        }

        private void d_20_combat(Entity ally, Entity enemy)
        {
            string D20number = "d" + ally.latest_roll;
            Player_dice.Image = (Image)Properties.Resources.ResourceManager.GetObject(D20number);
            Player_dice.SizeMode = PictureBoxSizeMode.StretchImage;
            Player_dice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            D20number = "d" + enemy.latest_roll;
            Enemy_dice.Image = (Image)Properties.Resources.ResourceManager.GetObject(D20number);
            Enemy_dice.SizeMode = PictureBoxSizeMode.StretchImage;
            Enemy_dice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        }
        async private void update_monster_death(int Enemy_index)
        {
            string Enemy_class = EnemyList[Enemy_index].class_name;
            Fight_Notes.Text = "";
            EnemyTab_tabControl.TabPages.RemoveAt(Enemy_index);
            player.gain_xp(EnemyList[Enemy_index].get_xp_gain());
            update_player_lbl();
            player.sound.play_Boom();
            Enemy_Chooser.Items.Remove(EnemyList[Enemy_index].nick_name);
            EnemyList.RemoveAt(Enemy_index);
            Enemy_Chooser.Text = "";
            check_boss();
            if (Enemy_class == "Minion")
            {
                Minion_pictrueBox.Image = Properties.Resources.Boom;
                await Task.Delay(1000);
                Minion_pictrueBox.Visible = false;
            }
            else
            {
                Monster_picture1.Image = Properties.Resources.Boom;
                await Task.Delay(1000);
                Monster_picture1.Visible = false;
            }

            await Task.Delay(1000);

            if (EnemyTab_tabControl.TabCount == 0)
            {
                EnemyTab_tabControl.TabPages.Add(Bounty_tab);
                Arena_bg.Image = (Image)Properties.Resources.ResourceManager.GetObject("mainBackground");
                Arena_bg.SizeMode = PictureBoxSizeMode.StretchImage;
                Save_button.Enabled = true;
                heal_button.Enabled = false;

            }
            if (EnemyList.Count > 0)
            {
                Enemy_Chooser.Enabled = true;
            }


        }
        private void check_boss()
        {
            if (Demon_Bat_checkbox.Checked == true && Blub_checkbox.Checked == true && Ogre_checkbox.Checked == true && Cerberus_checkbox.Checked == true && Shadow_knight_checkbox.Checked == true)
            {
                Boss_fight_botton.Enabled = true;

            }
        }
        private void Monster_attack(int Enemy_index)
        {
            player.dice_roll();
            EnemyList[Enemy_index].dice_roll();
            d_20_combat(player, EnemyList[Enemy_index]);
            PostTurn_interval.Enabled = true;
            if (EnemyList[Enemy_index].class_name == "BOSS")
            {
                if (((Boss)EnemyList[Enemy_index]).Choose_action() == 2)
                {
                    ((Boss)EnemyList[Enemy_index]).Update_cd();
                    if (EnemyList.Count < 2)
                    {
                        Minion Mini = ((Boss)EnemyList[Enemy_index]).Summon_minion(player.level);
                        Fight_Notes.Text = "Necromancer Is summoning a Mimic! be careful!";
                        EnemyList.Add(Mini);
                        update_minion_picture();
                        new_enemy_tab(EnemyList[1]);
                        Enemy_Chooser.Items.Add(EnemyList[1].nick_name);
                        return;
                    }
                }
            }
            if (EnemyList[Enemy_index].Choose_action() == 1)
            {
                if (EnemyList[Enemy_index].using_Skill(player))
                {

                    Fight_Notes.Text = EnemyList[Enemy_index].nick_name + ": hit you with " + EnemyList[Enemy_index].skill + " for:" + EnemyList[Enemy_index].skill_1_dmg + " Dmg";
                    EnemyList[Enemy_index].sound.play_Skill();
                    shake(Enemy_index, true);
                }
                else
                {
                    Fight_Notes.Text = EnemyList[Enemy_index].nick_name + " is a weakling Foe,he missed";
                    EnemyList[Enemy_index].sound.play_miss();

                }

            }

            else if (EnemyList[Enemy_index].Choose_action() == 0)
            {
                if (EnemyList[Enemy_index].Using_attack(player))
                {

                    Fight_Notes.Text = EnemyList[Enemy_index].nick_name + " hit you for:" + EnemyList[Enemy_index].attack + " Dmg";
                    EnemyList[Enemy_index].sound.play_hit();
                    shake(Enemy_index, true);
                }
                else
                {
                    Fight_Notes.Text = EnemyList[Enemy_index].nick_name + " is a weakling Foe,he missed";
                    EnemyList[Enemy_index].sound.play_miss();

                }

            }
            update_player_lbl();
            EnemyList[Enemy_index].Update_cd();
            if (is_dead(player))
            {
                Game_timer.Enabled = false;
                DialogResult dialog_box = MessageBox.Show("You Died! click ok to go to the load screen", "ok", MessageBoxButtons.OK);
                if (dialog_box == DialogResult.OK)
                {
                    this.Close();
                }
            }


        }
        void update_minion_picture()
        {
            Minion_pictrueBox.Image = Properties.Resources.ResourceManager.GetObject("Mimic") as Image;
            Minion_pictrueBox.Location = new Point(471, 200);
            Minion_pictrueBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Minion_pictrueBox.BackColor = Color.Transparent;
            Minion_pictrueBox.Parent = Arena_bg;
            Minion_pictrueBox.Visible = true;
            Minion_pictrueBox.BringToFront();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            string[] PlayerStats = new string[14];
            string path = "C:\\Users\\naorp\\Desktop\\Project\\" + player.nick_name + ".json";
            PlayerStats[0] = player.hp.ToString();
            PlayerStats[1] = player.max_hp.ToString();
            PlayerStats[2] = player.xp.ToString();
            PlayerStats[3] = player.max_xp.ToString();
            PlayerStats[4] = player.level.ToString();
            PlayerStats[5] = player.attack.ToString();
            PlayerStats[6] = player.class_name;
            PlayerStats[7] = player.nick_name;
            PlayerStats[8] = Demon_Bat_checkbox.Checked.ToString();
            PlayerStats[9] = Blub_checkbox.Checked.ToString();
            PlayerStats[10] = Ogre_checkbox.Checked.ToString();
            PlayerStats[11] = Cerberus_checkbox.Checked.ToString();
            PlayerStats[12] = Shadow_knight_checkbox.Checked.ToString();
            PlayerStats[13] = Time_passed.ToString();
            string json = JsonSerializer.Serialize(PlayerStats);
            SaveFileDialog dlg = new SaveFileDialog()
            {
                InitialDirectory = "C:\\Users\\naorp\\Desktop\\Project",
                RestoreDirectory = true
            };
            dlg.FileName = player.nick_name + ".json";
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(dlg.FileName, json);

            }
        }


        private void Load_Button_Click(object sender, EventArgs e)
        {
            string file = SelectFile();
            if (file == null)
            {
                return;
            }
            string[] PlayerStats = new string[14];
            string json = File.ReadAllText(file);
            PlayerStats = JsonSerializer.Deserialize<string[]>(json);
            player = new Player(Int32.Parse(PlayerStats[0]), Int32.Parse(PlayerStats[1]), Int32.Parse(PlayerStats[2]), Int32.Parse(PlayerStats[3]), Int32.Parse(PlayerStats[5]), Int32.Parse(PlayerStats[4]), PlayerStats[7], PlayerStats[6]);
            Demon_Bat_checkbox.Checked = bool.Parse(PlayerStats[8]);
            Blub_checkbox.Checked = bool.Parse(PlayerStats[9]);
            Ogre_checkbox.Checked = bool.Parse(PlayerStats[10]);
            Cerberus_checkbox.Checked = bool.Parse(PlayerStats[11]);
            Shadow_knight_checkbox.Checked = bool.Parse(PlayerStats[12]);
            Time_passed = Int32.Parse(PlayerStats[13]);
            Update_elapsedTime();
            Ally_Tabs.TabPages.RemoveByKey("Class_chooser");
            Player_nickname.Text = player.nick_name;
            Player_Class.Text = "Class=" + player.class_name;
            Player_Exp.Text = "EXP=" + player.xp.ToString() + "/" + player.max_xp.ToString();
            Player_Hp.Text = "HP=" + player.hp.ToString() + "/" + player.max_hp.ToString();
            Player_Attack.Text = "Attack=" + player.attack.ToString();
            Player_Level.Text = "Level=" + player.level.ToString();
            EnemyTab_tabControl.Visible = true;
            Save_button.Enabled = true;
            Game_timer.Enabled = true;
            check_boss();

        }

        public string SelectFile()
        {
            OpenFileDialog dlg = new OpenFileDialog()
            {
                InitialDirectory = "C:\\Users\\naorp\\Desktop\\Project",
                RestoreDirectory = true
            };

            //User didn't select a file so return a default value  
            if (dlg.ShowDialog() != DialogResult.OK)
                return null;

            //Return the file the user selected  
            return dlg.FileName;
        }

        private void Demon_Bat_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Demon_Bat_checkbox.Checked)
            {
                Demon_Bat_fight_button.Enabled = false;
            }
        }

        private void Blub_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Blub_checkbox.Checked)
            {
                Blub_fight_button.Enabled = false;
            }
        }

        private void Ogre_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Ogre_checkbox.Checked)
            {
                Ogre_fight_button.Enabled = false;
            }
        }

        private void Cerberus_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Cerberus_checkbox.Checked)
            {
                Cerberus_fight_button.Enabled = false;
            }
        }

        private void Shadow_knight_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Shadow_knight_checkbox.Checked)
            {
                Shadow_knight_fight_button.Enabled = false;
            }
        }

        private void heal_button_Click(object sender, EventArgs e)
        {
            if (player.heal())
            {
                update_player_lbl();
                string D20number = "d" + player.latest_roll;
                Player_dice.Image = (Image)Properties.Resources.ResourceManager.GetObject(D20number);
                Player_dice.SizeMode = PictureBoxSizeMode.StretchImage;
                Player_dice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                heal_button.Enabled = false;
            }
        }
        async private void shake(int index, bool enemy_attack)
        {
            bool mini = false;
            if (EnemyList[index].class_name == "Minion")
            {
                mini = true;
            }
            if (enemy_attack == false)
            {

                if (mini == true)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Minion_pictrueBox.Width += 15;
                        Minion_pictrueBox.Top += 15;
                        await Task.Delay(100);
                        Minion_pictrueBox.Width -= 15;
                        Minion_pictrueBox.Top -= 15;
                        await Task.Delay(100);
                        Minion_pictrueBox.Width -= 15;
                        Minion_pictrueBox.Top += 15;
                        await Task.Delay(100);
                        Minion_pictrueBox.Width += 15;
                        Minion_pictrueBox.Top -= 15;
                        await Task.Delay(100);
                        Minion_pictrueBox.Location = new Point(471, 200);
                    }
                }
                else
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Monster_picture1.Width += 15;
                        Monster_picture1.Top += 15;
                        await Task.Delay(100);
                        Monster_picture1.Width -= 15;
                        Monster_picture1.Top -= 15;
                        await Task.Delay(100);
                        Monster_picture1.Width -= 15;
                        Monster_picture1.Top += 15;
                        await Task.Delay(100);
                        Monster_picture1.Width += 15;
                        Monster_picture1.Top -= 15;
                        await Task.Delay(100);
                    }
                    Monster_picture1.Location = new Point(240, 130);
                }
            }
            else
            {
                if (mini == true)
                {
                    Minion_pictrueBox.Top -= 30;
                    await Task.Delay(100);
                    Minion_pictrueBox.Top += 30;
                    await Task.Delay(100);
                    Minion_pictrueBox.Location = new Point(471, 200);
                }
                else
                {
                    Monster_picture1.Top -= 30;
                    await Task.Delay(100);
                    Monster_picture1.Top += 30;
                    await Task.Delay(100);
                    Monster_picture1.Location = new Point(240, 130);

                }
            }
        }

        private void Game_timer_Tick(object sender, EventArgs e)
        {
            Time_passed++;
            Update_elapsedTime();

        }
        private void Update_elapsedTime()
        {
            int hours = Time_passed / 3600;
            int minutes = (Time_passed % 3600) / 60;
            int seconds = (Time_passed % 3600) % 60;
            Elapsed_timer.Text = "Timer: ";
            if (hours < 10)
            {
                Elapsed_timer.Text += "0" + hours + ":";
            }
            else
            {
                Elapsed_timer.Text += hours + ":";

            }
            Elapsed_timer.Text += "0" + minutes + ":" + seconds;


        }
        private void update_highscore()
        {
            string fileName = "High score.txt";
            string folderPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(folderPath, fileName);
            string content = player.nick_name + "    " + Elapsed_timer.Text + "\n";

            File.AppendAllText(filePath, content);
        }

    }
}