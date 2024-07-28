namespace Project
{
    partial class Game_Screen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Screen));
            Arena_bg = new PictureBox();
            Monster_picture1 = new PictureBox();
            Ally_Tabs = new TabControl();
            Player_stats = new TabPage();
            Heal_CD_label = new Label();
            Elapsed_timer = new Label();
            Player_Level = new Label();
            Player_Hp = new Label();
            Player_Attack = new Label();
            Player_Class = new Label();
            Player_Exp = new Label();
            Player_nickname = new Label();
            Class_chooser = new TabPage();
            Load_Button = new Button();
            Create_button = new Button();
            Choose_Nickname_label = new Label();
            Nickname_textbox = new TextBox();
            Archer_rb = new RadioButton();
            Warrior_rb = new RadioButton();
            GameFlow_textbox = new TextBox();
            EnemyTab_tabControl = new TabControl();
            Bounty_tab = new TabPage();
            Boss_fight_botton = new Button();
            Shadow_knight_checkbox = new CheckBox();
            Cerberus_checkbox = new CheckBox();
            Ogre_checkbox = new CheckBox();
            Blub_checkbox = new CheckBox();
            Demon_Bat_checkbox = new CheckBox();
            Shadow_knight_fight_button = new Button();
            Cerberus_fight_button = new Button();
            Ogre_fight_button = new Button();
            Blub_fight_button = new Button();
            Demon_Bat_fight_button = new Button();
            Attack_button = new Button();
            Enemy_Chooser = new ComboBox();
            Player_dice = new PictureBox();
            PostTurn_interval = new System.Windows.Forms.Timer(components);
            Fight_Notes = new TextBox();
            Enemy_dice = new PictureBox();
            Player_dice_label = new Label();
            Enemy_dice_label = new Label();
            Minion_pictrueBox = new PictureBox();
            Save_button = new Button();
            heal_button = new Button();
            Game_timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Arena_bg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Monster_picture1).BeginInit();
            Ally_Tabs.SuspendLayout();
            Player_stats.SuspendLayout();
            Class_chooser.SuspendLayout();
            EnemyTab_tabControl.SuspendLayout();
            Bounty_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Player_dice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enemy_dice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minion_pictrueBox).BeginInit();
            SuspendLayout();
            // 
            // Arena_bg
            // 
            Arena_bg.Enabled = false;
            Arena_bg.ErrorImage = (Image)resources.GetObject("Arena_bg.ErrorImage");
            Arena_bg.Location = new Point(250, 7);
            Arena_bg.Name = "Arena_bg";
            Arena_bg.Size = new Size(700, 349);
            Arena_bg.TabIndex = 0;
            Arena_bg.TabStop = false;
            Arena_bg.Visible = false;
            // 
            // Monster_picture1
            // 
            Monster_picture1.BackColor = Color.Transparent;
            Monster_picture1.Enabled = false;
            Monster_picture1.Location = new Point(484, 87);
            Monster_picture1.Name = "Monster_picture1";
            Monster_picture1.Size = new Size(231, 198);
            Monster_picture1.TabIndex = 1;
            Monster_picture1.TabStop = false;
            Monster_picture1.Visible = false;
            // 
            // Ally_Tabs
            // 
            Ally_Tabs.Controls.Add(Player_stats);
            Ally_Tabs.Controls.Add(Class_chooser);
            Ally_Tabs.Location = new Point(8, 18);
            Ally_Tabs.Name = "Ally_Tabs";
            Ally_Tabs.SelectedIndex = 0;
            Ally_Tabs.Size = new Size(236, 338);
            Ally_Tabs.TabIndex = 2;
            // 
            // Player_stats
            // 
            Player_stats.Controls.Add(Heal_CD_label);
            Player_stats.Controls.Add(Elapsed_timer);
            Player_stats.Controls.Add(Player_Level);
            Player_stats.Controls.Add(Player_Hp);
            Player_stats.Controls.Add(Player_Attack);
            Player_stats.Controls.Add(Player_Class);
            Player_stats.Controls.Add(Player_Exp);
            Player_stats.Controls.Add(Player_nickname);
            Player_stats.Location = new Point(4, 28);
            Player_stats.Name = "Player_stats";
            Player_stats.Padding = new Padding(3);
            Player_stats.Size = new Size(228, 306);
            Player_stats.TabIndex = 0;
            Player_stats.Text = "Player stats";
            Player_stats.UseVisualStyleBackColor = true;
            // 
            // Heal_CD_label
            // 
            Heal_CD_label.AutoSize = true;
            Heal_CD_label.Location = new Point(120, 176);
            Heal_CD_label.Name = "Heal_CD_label";
            Heal_CD_label.Size = new Size(66, 20);
            Heal_CD_label.TabIndex = 14;
            Heal_CD_label.Text = "Heal_CD";
            // 
            // Elapsed_timer
            // 
            Elapsed_timer.AutoSize = true;
            Elapsed_timer.Location = new Point(0, 265);
            Elapsed_timer.Name = "Elapsed_timer";
            Elapsed_timer.Size = new Size(103, 20);
            Elapsed_timer.TabIndex = 1;
            Elapsed_timer.Text = "Time: 00:00:00";
            // 
            // Player_Level
            // 
            Player_Level.AutoSize = true;
            Player_Level.Location = new Point(3, 171);
            Player_Level.Name = "Player_Level";
            Player_Level.Size = new Size(89, 20);
            Player_Level.TabIndex = 0;
            Player_Level.Text = "Player_Level";
            // 
            // Player_Hp
            // 
            Player_Hp.AutoSize = true;
            Player_Hp.Location = new Point(3, 133);
            Player_Hp.Name = "Player_Hp";
            Player_Hp.Size = new Size(75, 20);
            Player_Hp.TabIndex = 0;
            Player_Hp.Text = "Player_Hp";
            // 
            // Player_Attack
            // 
            Player_Attack.AutoSize = true;
            Player_Attack.Location = new Point(120, 136);
            Player_Attack.Name = "Player_Attack";
            Player_Attack.Size = new Size(97, 20);
            Player_Attack.TabIndex = 0;
            Player_Attack.Text = "Player_Attack";
            // 
            // Player_Class
            // 
            Player_Class.AutoSize = true;
            Player_Class.Location = new Point(3, 90);
            Player_Class.Name = "Player_Class";
            Player_Class.Size = new Size(88, 20);
            Player_Class.TabIndex = 0;
            Player_Class.Text = "Player_Class";
            // 
            // Player_Exp
            // 
            Player_Exp.AutoSize = true;
            Player_Exp.Location = new Point(120, 90);
            Player_Exp.Name = "Player_Exp";
            Player_Exp.Size = new Size(79, 20);
            Player_Exp.TabIndex = 0;
            Player_Exp.Text = "Player_Exp";
            // 
            // Player_nickname
            // 
            Player_nickname.AutoSize = true;
            Player_nickname.Location = new Point(74, 15);
            Player_nickname.Name = "Player_nickname";
            Player_nickname.Size = new Size(75, 20);
            Player_nickname.TabIndex = 0;
            Player_nickname.Text = "Nickname";
            Player_nickname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Class_chooser
            // 
            Class_chooser.Controls.Add(Load_Button);
            Class_chooser.Controls.Add(Create_button);
            Class_chooser.Controls.Add(Choose_Nickname_label);
            Class_chooser.Controls.Add(Nickname_textbox);
            Class_chooser.Controls.Add(Archer_rb);
            Class_chooser.Controls.Add(Warrior_rb);
            Class_chooser.Location = new Point(4, 28);
            Class_chooser.Name = "Class_chooser";
            Class_chooser.Padding = new Padding(3);
            Class_chooser.Size = new Size(228, 306);
            Class_chooser.TabIndex = 1;
            Class_chooser.Text = "Class chooser";
            Class_chooser.UseVisualStyleBackColor = true;
            // 
            // Load_Button
            // 
            Load_Button.Location = new Point(30, 257);
            Load_Button.Name = "Load_Button";
            Load_Button.Size = new Size(178, 28);
            Load_Button.TabIndex = 5;
            Load_Button.Text = "Load_save";
            Load_Button.UseVisualStyleBackColor = true;
            Load_Button.Click += Load_Button_Click;
            // 
            // Create_button
            // 
            Create_button.Location = new Point(30, 194);
            Create_button.Name = "Create_button";
            Create_button.Size = new Size(178, 56);
            Create_button.TabIndex = 4;
            Create_button.Text = "Create";
            Create_button.UseVisualStyleBackColor = true;
            Create_button.Click += Create_button_Click;
            // 
            // Choose_Nickname_label
            // 
            Choose_Nickname_label.AutoSize = true;
            Choose_Nickname_label.Location = new Point(35, 111);
            Choose_Nickname_label.Name = "Choose_Nickname_label";
            Choose_Nickname_label.Size = new Size(81, 20);
            Choose_Nickname_label.TabIndex = 3;
            Choose_Nickname_label.Text = "NickName:";
            // 
            // Nickname_textbox
            // 
            Nickname_textbox.Location = new Point(35, 134);
            Nickname_textbox.Name = "Nickname_textbox";
            Nickname_textbox.Size = new Size(173, 26);
            Nickname_textbox.TabIndex = 2;
            // 
            // Archer_rb
            // 
            Archer_rb.AutoSize = true;
            Archer_rb.Location = new Point(35, 71);
            Archer_rb.Name = "Archer_rb";
            Archer_rb.Size = new Size(70, 24);
            Archer_rb.TabIndex = 1;
            Archer_rb.Text = "Archer";
            Archer_rb.UseVisualStyleBackColor = true;
            // 
            // Warrior_rb
            // 
            Warrior_rb.AutoSize = true;
            Warrior_rb.Location = new Point(35, 32);
            Warrior_rb.Name = "Warrior_rb";
            Warrior_rb.Size = new Size(76, 24);
            Warrior_rb.TabIndex = 0;
            Warrior_rb.Text = "Warrior";
            Warrior_rb.UseVisualStyleBackColor = true;
            // 
            // GameFlow_textbox
            // 
            GameFlow_textbox.Font = new Font("Segoe UI", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point);
            GameFlow_textbox.Location = new Point(247, 7);
            GameFlow_textbox.Multiline = true;
            GameFlow_textbox.Name = "GameFlow_textbox";
            GameFlow_textbox.ReadOnly = true;
            GameFlow_textbox.Size = new Size(702, 348);
            GameFlow_textbox.TabIndex = 3;
            // 
            // EnemyTab_tabControl
            // 
            EnemyTab_tabControl.Controls.Add(Bounty_tab);
            EnemyTab_tabControl.Location = new Point(959, 7);
            EnemyTab_tabControl.Name = "EnemyTab_tabControl";
            EnemyTab_tabControl.SelectedIndex = 0;
            EnemyTab_tabControl.Size = new Size(244, 349);
            EnemyTab_tabControl.TabIndex = 4;
            // 
            // Bounty_tab
            // 
            Bounty_tab.Controls.Add(Boss_fight_botton);
            Bounty_tab.Controls.Add(Shadow_knight_checkbox);
            Bounty_tab.Controls.Add(Cerberus_checkbox);
            Bounty_tab.Controls.Add(Ogre_checkbox);
            Bounty_tab.Controls.Add(Blub_checkbox);
            Bounty_tab.Controls.Add(Demon_Bat_checkbox);
            Bounty_tab.Controls.Add(Shadow_knight_fight_button);
            Bounty_tab.Controls.Add(Cerberus_fight_button);
            Bounty_tab.Controls.Add(Ogre_fight_button);
            Bounty_tab.Controls.Add(Blub_fight_button);
            Bounty_tab.Controls.Add(Demon_Bat_fight_button);
            Bounty_tab.Location = new Point(4, 28);
            Bounty_tab.Name = "Bounty_tab";
            Bounty_tab.Padding = new Padding(3);
            Bounty_tab.Size = new Size(236, 317);
            Bounty_tab.TabIndex = 0;
            Bounty_tab.Text = "Bounty tab";
            Bounty_tab.UseVisualStyleBackColor = true;
            // 
            // Boss_fight_botton
            // 
            Boss_fight_botton.Enabled = false;
            Boss_fight_botton.Location = new Point(46, 240);
            Boss_fight_botton.Name = "Boss_fight_botton";
            Boss_fight_botton.Size = new Size(155, 56);
            Boss_fight_botton.TabIndex = 2;
            Boss_fight_botton.Text = "BOSS";
            Boss_fight_botton.UseVisualStyleBackColor = true;
            Boss_fight_botton.Click += Boss_fight_botton_Click;
            // 
            // Shadow_knight_checkbox
            // 
            Shadow_knight_checkbox.AutoSize = true;
            Shadow_knight_checkbox.Enabled = false;
            Shadow_knight_checkbox.Location = new Point(25, 193);
            Shadow_knight_checkbox.Name = "Shadow_knight_checkbox";
            Shadow_knight_checkbox.Size = new Size(15, 14);
            Shadow_knight_checkbox.TabIndex = 1;
            Shadow_knight_checkbox.UseVisualStyleBackColor = true;
            Shadow_knight_checkbox.CheckedChanged += Shadow_knight_checkbox_CheckedChanged;
            // 
            // Cerberus_checkbox
            // 
            Cerberus_checkbox.AutoSize = true;
            Cerberus_checkbox.Enabled = false;
            Cerberus_checkbox.Location = new Point(25, 147);
            Cerberus_checkbox.Name = "Cerberus_checkbox";
            Cerberus_checkbox.Size = new Size(15, 14);
            Cerberus_checkbox.TabIndex = 1;
            Cerberus_checkbox.UseVisualStyleBackColor = true;
            Cerberus_checkbox.CheckedChanged += Cerberus_checkbox_CheckedChanged;
            // 
            // Ogre_checkbox
            // 
            Ogre_checkbox.AutoSize = true;
            Ogre_checkbox.Enabled = false;
            Ogre_checkbox.Location = new Point(25, 104);
            Ogre_checkbox.Name = "Ogre_checkbox";
            Ogre_checkbox.Size = new Size(15, 14);
            Ogre_checkbox.TabIndex = 1;
            Ogre_checkbox.UseVisualStyleBackColor = true;
            Ogre_checkbox.CheckedChanged += Ogre_checkbox_CheckedChanged;
            // 
            // Blub_checkbox
            // 
            Blub_checkbox.AutoSize = true;
            Blub_checkbox.Enabled = false;
            Blub_checkbox.Location = new Point(25, 63);
            Blub_checkbox.Name = "Blub_checkbox";
            Blub_checkbox.Size = new Size(15, 14);
            Blub_checkbox.TabIndex = 1;
            Blub_checkbox.UseVisualStyleBackColor = true;
            Blub_checkbox.CheckedChanged += Blub_checkbox_CheckedChanged;
            // 
            // Demon_Bat_checkbox
            // 
            Demon_Bat_checkbox.AutoSize = true;
            Demon_Bat_checkbox.Enabled = false;
            Demon_Bat_checkbox.Location = new Point(25, 22);
            Demon_Bat_checkbox.Name = "Demon_Bat_checkbox";
            Demon_Bat_checkbox.Size = new Size(15, 14);
            Demon_Bat_checkbox.TabIndex = 1;
            Demon_Bat_checkbox.UseVisualStyleBackColor = true;
            Demon_Bat_checkbox.CheckedChanged += Demon_Bat_checkbox_CheckedChanged;
            // 
            // Shadow_knight_fight_button
            // 
            Shadow_knight_fight_button.Location = new Point(64, 182);
            Shadow_knight_fight_button.Name = "Shadow_knight_fight_button";
            Shadow_knight_fight_button.Size = new Size(153, 35);
            Shadow_knight_fight_button.TabIndex = 0;
            Shadow_knight_fight_button.Text = "Shadow knight";
            Shadow_knight_fight_button.UseVisualStyleBackColor = true;
            Shadow_knight_fight_button.Click += Shadow_kight_fight_button_Click;
            // 
            // Cerberus_fight_button
            // 
            Cerberus_fight_button.Location = new Point(64, 136);
            Cerberus_fight_button.Name = "Cerberus_fight_button";
            Cerberus_fight_button.Size = new Size(153, 35);
            Cerberus_fight_button.TabIndex = 0;
            Cerberus_fight_button.Text = "Cerberus";
            Cerberus_fight_button.UseVisualStyleBackColor = true;
            Cerberus_fight_button.Click += Cerberus_fight_button_Click;
            // 
            // Ogre_fight_button
            // 
            Ogre_fight_button.Location = new Point(64, 93);
            Ogre_fight_button.Name = "Ogre_fight_button";
            Ogre_fight_button.Size = new Size(153, 35);
            Ogre_fight_button.TabIndex = 0;
            Ogre_fight_button.Text = "Ogre";
            Ogre_fight_button.UseVisualStyleBackColor = true;
            Ogre_fight_button.Click += Ogre_Click;
            // 
            // Blub_fight_button
            // 
            Blub_fight_button.Location = new Point(64, 52);
            Blub_fight_button.Name = "Blub_fight_button";
            Blub_fight_button.Size = new Size(153, 35);
            Blub_fight_button.TabIndex = 0;
            Blub_fight_button.Text = "Blub";
            Blub_fight_button.UseVisualStyleBackColor = true;
            Blub_fight_button.Click += Blub_fight_button_Click;
            // 
            // Demon_Bat_fight_button
            // 
            Demon_Bat_fight_button.Location = new Point(64, 11);
            Demon_Bat_fight_button.Name = "Demon_Bat_fight_button";
            Demon_Bat_fight_button.Size = new Size(153, 35);
            Demon_Bat_fight_button.TabIndex = 0;
            Demon_Bat_fight_button.Text = "Demon Bat";
            Demon_Bat_fight_button.UseVisualStyleBackColor = true;
            Demon_Bat_fight_button.Click += Demon_Bat_fight_button_Click;
            // 
            // Attack_button
            // 
            Attack_button.Enabled = false;
            Attack_button.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            Attack_button.ForeColor = Color.Red;
            Attack_button.Location = new Point(250, 396);
            Attack_button.Name = "Attack_button";
            Attack_button.Size = new Size(186, 68);
            Attack_button.TabIndex = 5;
            Attack_button.Text = "Attack";
            Attack_button.UseVisualStyleBackColor = true;
            Attack_button.Click += Attack_button_Click;
            // 
            // Enemy_Chooser
            // 
            Enemy_Chooser.FormattingEnabled = true;
            Enemy_Chooser.Location = new Point(250, 363);
            Enemy_Chooser.Name = "Enemy_Chooser";
            Enemy_Chooser.Size = new Size(186, 27);
            Enemy_Chooser.TabIndex = 6;
            Enemy_Chooser.SelectedIndexChanged += Enemy_Chooser_SelectedIndexChanged;
            // 
            // Player_dice
            // 
            Player_dice.Location = new Point(122, 363);
            Player_dice.Name = "Player_dice";
            Player_dice.Size = new Size(118, 101);
            Player_dice.TabIndex = 7;
            Player_dice.TabStop = false;
            // 
            // PostTurn_interval
            // 
            PostTurn_interval.Tick += PostTurn_interval_Tick;
            // 
            // Fight_Notes
            // 
            Fight_Notes.BackColor = SystemColors.Control;
            Fight_Notes.Enabled = false;
            Fight_Notes.Location = new Point(457, 363);
            Fight_Notes.Multiline = true;
            Fight_Notes.Name = "Fight_Notes";
            Fight_Notes.Size = new Size(232, 101);
            Fight_Notes.TabIndex = 8;
            // 
            // Enemy_dice
            // 
            Enemy_dice.Location = new Point(1081, 363);
            Enemy_dice.Name = "Enemy_dice";
            Enemy_dice.Size = new Size(118, 101);
            Enemy_dice.TabIndex = 7;
            Enemy_dice.TabStop = false;
            // 
            // Player_dice_label
            // 
            Player_dice_label.AutoSize = true;
            Player_dice_label.Location = new Point(12, 359);
            Player_dice_label.Name = "Player_dice_label";
            Player_dice_label.Size = new Size(83, 20);
            Player_dice_label.TabIndex = 9;
            Player_dice_label.Text = "Player_dice";
            // 
            // Enemy_dice_label
            // 
            Enemy_dice_label.AutoSize = true;
            Enemy_dice_label.Location = new Point(963, 363);
            Enemy_dice_label.Name = "Enemy_dice_label";
            Enemy_dice_label.Size = new Size(87, 20);
            Enemy_dice_label.TabIndex = 9;
            Enemy_dice_label.Text = "Enemy_dice";
            // 
            // Minion_pictrueBox
            // 
            Minion_pictrueBox.BackColor = Color.Transparent;
            Minion_pictrueBox.Location = new Point(747, 161);
            Minion_pictrueBox.Name = "Minion_pictrueBox";
            Minion_pictrueBox.Size = new Size(161, 124);
            Minion_pictrueBox.TabIndex = 10;
            Minion_pictrueBox.TabStop = false;
            Minion_pictrueBox.Visible = false;
            // 
            // Save_button
            // 
            Save_button.Enabled = false;
            Save_button.Location = new Point(15, 430);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(88, 28);
            Save_button.TabIndex = 12;
            Save_button.Text = "Save";
            Save_button.UseVisualStyleBackColor = true;
            Save_button.Click += Save_button_Click;
            // 
            // heal_button
            // 
            heal_button.Enabled = false;
            heal_button.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            heal_button.ForeColor = Color.FromArgb(0, 192, 0);
            heal_button.Location = new Point(250, 470);
            heal_button.Name = "heal_button";
            heal_button.Size = new Size(186, 47);
            heal_button.TabIndex = 13;
            heal_button.Text = "Heal";
            heal_button.UseVisualStyleBackColor = true;
            heal_button.Click += heal_button_Click;
            // 
            // Game_timer
            // 
            Game_timer.Interval = 1000;
            Game_timer.Tick += Game_timer_Tick;
            // 
            // Game_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 529);
            Controls.Add(heal_button);
            Controls.Add(Save_button);
            Controls.Add(Minion_pictrueBox);
            Controls.Add(Monster_picture1);
            Controls.Add(Enemy_dice_label);
            Controls.Add(Player_dice_label);
            Controls.Add(Fight_Notes);
            Controls.Add(Enemy_dice);
            Controls.Add(Player_dice);
            Controls.Add(Enemy_Chooser);
            Controls.Add(Attack_button);
            Controls.Add(EnemyTab_tabControl);
            Controls.Add(Ally_Tabs);
            Controls.Add(Arena_bg);
            Controls.Add(GameFlow_textbox);
            Name = "Game_Screen";
            Text = "Harvest of Vengeance";
            FormClosed += Game_Screen_FormClosed;
            ((System.ComponentModel.ISupportInitialize)Arena_bg).EndInit();
            ((System.ComponentModel.ISupportInitialize)Monster_picture1).EndInit();
            Ally_Tabs.ResumeLayout(false);
            Player_stats.ResumeLayout(false);
            Player_stats.PerformLayout();
            Class_chooser.ResumeLayout(false);
            Class_chooser.PerformLayout();
            EnemyTab_tabControl.ResumeLayout(false);
            Bounty_tab.ResumeLayout(false);
            Bounty_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Player_dice).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enemy_dice).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minion_pictrueBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Arena_bg;
        private PictureBox Monster_picture1;
        private TabControl Ally_Tabs;
        private TabPage Player_stats;
        private TabPage Class_chooser;
        private Label Player_nickname;
        private Label Player_Class;
        private Label Player_Exp;
        private Label Player_Level;
        private Label Player_Hp;
        private Label Player_Attack;
        private Label Choose_Nickname_label;
        private TextBox Nickname_textbox;
        private RadioButton Archer_rb;
        private RadioButton Warrior_rb;
        private Button Create_button;
        private TextBox GameFlow_textbox;
        private TabControl EnemyTab_tabControl;
        private TabPage Bounty_tab;
        private CheckBox Shadow_knight_checkbox;
        private CheckBox Cerberus_checkbox;
        private CheckBox Ogre_checkbox;
        private CheckBox Blub_checkbox;
        private CheckBox Demon_Bat_checkbox;
        private Button Shadow_knight_fight_button;
        private Button Cerberus_fight_button;
        private Button Ogre_fight_button;
        private Button Blub_fight_button;
        private Button Demon_Bat_fight_button;
        private Button Boss_fight_botton;
        private Button Attack_button;
        private ComboBox Enemy_Chooser;
        private PictureBox Player_dice;
        private System.Windows.Forms.Timer PostTurn_interval;
        private TextBox Fight_Notes;
        private PictureBox Enemy_dice;
        private Label Player_dice_label;
        private Label Enemy_dice_label;
        private PictureBox Minion_pictrueBox;
        private Button Save_button;
        private Button Load_Button;
        private Button heal_button;
        private System.Windows.Forms.Timer Game_timer;
        private Label Elapsed_timer;
        private Label Heal_CD_label;
    }
}