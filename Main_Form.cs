using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer
{

    public partial class Main_Form : Form
    {
        Tasks_Form ft = new Tasks_Form();
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Activated(object sender, EventArgs e)
        {
            Hide();
            ft.Show();
        }

        private void Exit_MenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Tasks_MenuItem_Click(object sender, EventArgs e)
        {
            ft.Show();
        }
    }
}
