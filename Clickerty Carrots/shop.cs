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
    public partial class shop : Form
    {
        public shop()
        {
            InitializeComponent();
        }
        private void shop_Load(object sender, EventArgs e)
        {
            upgrade1_img.ImageLocation = Application.StartupPath + "\\watercan.png";
            upgrade2_img.ImageLocation = Application.StartupPath + "\\up2.png";
            upgrade3_img.ImageLocation = Application.StartupPath + "\\up3.png";
            upgrade4_img.ImageLocation = Application.StartupPath + "\\fertilizer.png";
            upgrade5_img.ImageLocation = Application.StartupPath + "\\shrooms.png";
            upgrade6_img.ImageLocation = Application.StartupPath + "\\up4.png";
            if (Menu_game.up1_bought == true)
            {
                buyup1_btn.Text = "Bought";
            }
            if (Menu_game.up2_bought == true)
            {
                buyup2_btn.Text = "Bought";
            }
            if (Menu_game.up3_bought == true)
            {
                buyup3_btn.Text = "Bought";
            }
            if (Menu_game.up4_bought == true)
            {
                buyup4_btn.Text = "Bought";
            }
            if (Menu_game.up5_bought == true)
            {
                buyup5_btn.Text = "Bought";
            }
            if (Menu_game.up6_bought == true)
            {
                buyup6_btn.Text = "Bought";
            }
        }

        private void buyup1_btn_Click(object sender, EventArgs e)
        {
            if (Menu_game.up1_bought == false)
            {
                if (Menu_game.money >= 120)
                {

                    Menu_game.money -= 120;
                    Menu_game.up1_bought = true;
                    buyup1_btn.Text = "Bought";
                }

                else
                {
                    MessageBox.Show("Not enough Carrots!", "Insufficient Carrots.");
                }
            }
        }

        private void buyup2_btn_Click(object sender, EventArgs e)
        {
            if (Menu_game.up2_bought == false)
            {
                if (Menu_game.money >= 600)
                {

                    Menu_game.money -= 600;
                    Menu_game.up2_bought = true;
                    buyup2_btn.Text = "Bought";
                }

                else
                {
                    MessageBox.Show("Not enough Carrots!", "Insufficient Carrots.");
                }
            }
        }

        private void buyup3_btn_Click(object sender, EventArgs e)
        {
            if (Menu_game.up3_bought == false)
            {
                if (Menu_game.money >= 1100)
                {

                    Menu_game.money -= 1100;
                    Menu_game.up3_bought = true;
                    buyup3_btn.Text = "Bought";
                }

                else
                {
                    MessageBox.Show("Not enough Carrots!", "Insufficient Carrots.");
                }
            }
        }

        private void byup4_btn_Click(object sender, EventArgs e)
        {
            if (Menu_game.up4_bought == false)
            {
                if (Menu_game.money >= 2500)
                {

                    Menu_game.money -= 2500;
                    Menu_game.up4_bought = true;
                    buyup4_btn.Text = "Bought";
                }

                else
                {
                    MessageBox.Show("Not enough Carrots!", "Insufficient Carrots.");
                }
            }
        }

        private void buyup5_lbl_Click(object sender, EventArgs e)
        {
            if (Menu_game.up5_bought == false)
            {
                if (Menu_game.money >= 4242)
                {

                    Menu_game.money -= 4242;
                    Menu_game.up5_bought = true;
                    buyup5_btn.Text = "Bought";
                }

                else
                {
                    MessageBox.Show("Not enough Carrots!", "Insufficient Carrots.");
                }
            }

        }

        private void buyup6_btn_Click(object sender, EventArgs e)
        {
            if (Menu_game.up6_bought == false)
            {
                if (Menu_game.money >= 10000000)
                {

                    Menu_game.money -= 10000000;
                    Menu_game.up6_bought = true;
                    buyup6_btn.Text = "Bought";
                }

                else
                {
                    MessageBox.Show("Not enough Carrots!", "Insufficient Carrots.");
                }
            }
        }
    }
}
