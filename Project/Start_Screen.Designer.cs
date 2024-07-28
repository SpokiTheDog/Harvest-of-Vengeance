namespace Project
{
    partial class Start_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            New_Game = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // New_Game
            // 
            New_Game.ImageKey = "(none)";
            New_Game.Location = new Point(107, 216);
            New_Game.Name = "New_Game";
            New_Game.Size = new Size(284, 121);
            New_Game.TabIndex = 0;
            New_Game.Text = "Start Game";
            New_Game.UseVisualStyleBackColor = true;
            New_Game.Click += Load_Game_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 20.0347824F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(85, 80);
            label1.Name = "label1";
            label1.Size = new Size(334, 52);
            label1.TabIndex = 1;
            label1.Text = "Harvest of Vengeance";
            // 
            // Start_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 478);
            Controls.Add(label1);
            Controls.Add(New_Game);
            Name = "Start_Screen";
            Text = "Start Screen";
            FormClosing += Start_Screen_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button New_Game;
        private Label label1;
    }
}