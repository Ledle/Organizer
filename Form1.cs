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
    public partial class Form1 : Form
    {
        private Mode Tasks,Notes,Calendar;
        public Form1()
        {
            InitializeComponent();
            Tasks = new Mode(new Button[] { Notes_button, Calendar_button });
            Notes = new Mode(new Button[] { Tasks_button, Calendar_button });
            Calendar = new Mode(new Button[] { Tasks_button, Notes_button });
            List<String> t = new List<String>();
        }
        private void Tasks_button_Click(object sender, EventArgs e)
        {
            Tasks.Show();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calendar_button_Click(object sender, EventArgs e)
        {
            Calendar.Show();
        }

        private void Notes_button_Click(object sender, EventArgs e)
        {
            Notes.Show();
        }
    }
}