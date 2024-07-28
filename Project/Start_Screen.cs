using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Start_Screen : Form
    {
        public Start_Screen()
        {
            InitializeComponent();
        }

        private void Load_Game_Click(object sender, EventArgs e)
        {
            Game_Screen Game_window = new Game_Screen();
            Game_window.Show();
            this.Visible = false;

        }

        private void Start_Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Load_game_Click_1(object sender, EventArgs e)
        {
            Game_Screen Game_window;
            string filename;
            string jsonString;
            //Game_window = JsonSerializer.Deserialize<Game_Screen>(jsonString);
        }
    }
}
