using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class hoToPlay : Form
    {
        public hoToPlay()
        {
            InitializeComponent();
        }

        private void backToMain(object sender, EventArgs e)
        {
          mainMenu mainmenu = new mainMenu();
            mainmenu.Show();
            this.Hide();
        }
    }
}
