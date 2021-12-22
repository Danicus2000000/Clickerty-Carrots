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
    public partial class Ending : Form
    {
        public Ending()
        {
            InitializeComponent();
        }

        private void Ending_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
