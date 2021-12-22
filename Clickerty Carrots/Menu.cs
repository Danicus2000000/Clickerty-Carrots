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
    public partial class Menu_game : Form
    {
        public Menu_game()
        {
            InitializeComponent();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = Application.StartupPath + "\\music.wav";
            player.PlayLooping();

        }
        public static string date_init;
        public static string last_played;
        public static int money;
        public static bool up1_bought;
        public static bool up2_bought;
        public static bool up3_bought;
        public static bool up4_bought;
        public static bool up5_bought;
        public static bool up6_bought;
        private void newgame_btn_Click(object sender, EventArgs e)
        {
            DialogResult overwrite = MessageBox.Show("Are you sure you want to create a new save?\nThis Will Overwrite any previous saves.","New Save",MessageBoxButtons.OKCancel);
            if (overwrite == DialogResult.OK)
            {
                string time = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
                //File Saved in format: (Date Created, Last Played, Money,up1bought,up2bought)
                System.IO.File.WriteAllText(Application.StartupPath+"\\save.txt", time + "," + time + ",0,false,false,false,false,false,false");
                date_init = time;
                last_played = time;
                money = 0;
                up1_bought = false;
                up2_bought = false;
                up3_bought = false;
                up4_bought = false;
                up5_bought = false;
                up6_bought = false;
                this.Hide();
                Form game = new Clickerty_Carrots();
                game.Show();
            }
        }

        private void loadgame_btn_Click(object sender, EventArgs e)
        {
            string data = System.IO.File.ReadAllText(Application.StartupPath+"\\save.txt");
            if (data != "")
            {
                try
                {
                    String[] data_split = data.Split(',');
                    //File Saved in format: (Date Created, Last Played, Money,up1bought,up2bought)
                    DialogResult load = MessageBox.Show("Load File:\nMoney: " + data_split[2] + "\nDate Created: " + data_split[0] + "\nLast Played: " + data_split[1], "Load Save?", MessageBoxButtons.OKCancel);
                    if (load == DialogResult.OK)
                    {
                        date_init = data_split[0];
                        last_played = data_split[1];
                        money = Convert.ToInt32(data_split[2]);
                        up1_bought = Convert.ToBoolean(data_split[3]);
                        up2_bought = Convert.ToBoolean(data_split[4]);
                        up3_bought = Convert.ToBoolean(data_split[5]);
                        up4_bought = Convert.ToBoolean(data_split[6]);
                        up5_bought = Convert.ToBoolean(data_split[7]);
                        up6_bought = Convert.ToBoolean(data_split[8]);
                        this.Hide();
                        Form game = new Clickerty_Carrots();
                        game.Show();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("The File is not in the correct format please create a new save to resolve this.", "File Format Error");
                }
            }
            else
            {
                MessageBox.Show("No save data was found please create a new save.", "No save data");
            }
        }

        private void options_btn_Click(object sender, EventArgs e)
        {
            DialogResult option1 = MessageBox.Show("Would you like music to be turned on?", "Music",MessageBoxButtons.YesNo);
            if (option1 == DialogResult.No)
            {
                System.Media.SoundPlayer media = new System.Media.SoundPlayer();
                media.Stop();
            }
            else if (option1 == DialogResult.Yes)
            {
                System.Media.SoundPlayer media = new System.Media.SoundPlayer();
                media.Stop();
                media.SoundLocation=Application.StartupPath + "\\music.wav";
                media.PlayLooping();
            }
        }

        private void Menu_game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
