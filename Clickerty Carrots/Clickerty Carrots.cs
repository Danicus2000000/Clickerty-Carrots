using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clickerty_Carrots
{
    public partial class Clickerty_Carrots : Form
    {
        public Clickerty_Carrots()
        {
            InitializeComponent();
        }
        public static int multiplier=1;
        public static bool used = false;
        public static bool used2 = false;
        public static bool used3 = false;
        public static bool used4 = false;
        public static bool used5 = false;
        public static bool used6 = false;
        private void plot_img_Click(object sender, EventArgs e)
        {
            Menu_game.money += 1*multiplier;//adds one to money
            currentmoney_lbl.Text = "Carrots Clicked Up: " + Menu_game.money;//updates the tital that shows the plaer their money
        }

        private void Clickerty_Carrots_Load(object sender, EventArgs e)
        {
            currentmoney_lbl.Text = "Carrots Clicked Up: " + Menu_game.money;//when the game loads the money earned is loaded too
            plot_img.ImageLocation = Application.StartupPath + "\\plotlvl1.png";
            heart_img.ImageLocation = Application.StartupPath + "\\heart.png";
            check.Enabled = true;
        }
        private void Clickerty_Carrots_Click(object sender, EventArgs e)
        {
            Menu_game.money += 1*multiplier;//adds one to money 
            currentmoney_lbl.Text = "Carrots Clicked Up: " + Menu_game.money;//updates display      
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("Are you sure you want to quit?","Close?",MessageBoxButtons.YesNo);//makes sure user wants to close and closes
            if (close == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void shop_btn_Click(object sender, EventArgs e)
        {
            Form shop = new shop();//opens shop upon users request
            Form shop2 = Application.OpenForms["shop"];
            if (shop2 == null)
            {
                shop.Show();
            }
        }

        private void ending_btn_Click(object sender, EventArgs e)
        {
            Form ending = new Ending();
            ending.Show();
            this.Close();
        }

        private void Clickerty_Carrots_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu_game.last_played = DateTime.Now.ToString("dd/MM/yyyy hh:mm");//gets current time
            //File Saved in format: (Date Created, Last Played, Money)
            System.IO.File.WriteAllText(Application.StartupPath + "\\save.txt", Menu_game.date_init + "," + Menu_game.last_played + "," + Menu_game.money + "," + Menu_game.up1_bought + "," + Menu_game.up2_bought + "," + Menu_game.up3_bought + "," + Menu_game.up4_bought + "," + Menu_game.up5_bought + "," + Menu_game.up6_bought);//updates file
        }

        private void check_Tick(object sender, EventArgs e)
        {
            if (Menu_game.up1_bought == true && used != true)
            {
                watercan_img.Visible = true;
                watercan_img.Enabled = true;
                multiplier = multiplier * 2;
                watercan_img.ImageLocation = Application.StartupPath + "\\watercan.png";
                used = true;
            }
            if (Menu_game.up2_bought == true && used2 != true)
            {
                plot_img.ImageLocation = Application.StartupPath + "\\plotlvl2.png";
                used2 = true;
                multiplier = multiplier * 3;
            }
            if (Menu_game.up3_bought == true && used3 != true)
            {
                plot_img.ImageLocation = Application.StartupPath + "\\plotlvl3.png";
                used3 = true;
                multiplier = multiplier * 7;
            }
            if (Menu_game.up4_bought == true && used4 != true)
            {
                fertilizer_img.Enabled = true;
                fertilizer_img.Visible = true;
                fertilizer_img.ImageLocation = Application.StartupPath + "\\fertilizer.png";
                used4 = true;
                multiplier = multiplier * 12;
            }
            if (Menu_game.up5_bought == true && used5 != true)
            {
                shrooms_img.Enabled = true;
                shrooms_img.Visible = true;
                shrooms_img.ImageLocation = Application.StartupPath + "\\shrooms.png";
                used5 = true;
                multiplier = multiplier * 42;
            }
            if (Menu_game.up6_bought == true && used6 != true)
            {
                plot_img.ImageLocation = Application.StartupPath + "\\plotlvl4.png";
                ending_btn.Visible = true;
                ending_btn.Enabled = true;
                used6 = true;
            }

        }

        private void men_btn_Click(object sender, EventArgs e)
        {
            Form menu = new Menu_game();
            menu.Show();
            this.Close();
        }
    }
}
