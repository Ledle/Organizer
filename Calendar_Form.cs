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
    public partial class Calendar_Form : Form
    {
        public Calendar_Form()
        {
            InitializeComponent();
            MonthCalendar.SelectDay += Calendar_Day_Selected;

        }

        private void AddGroup_Button_Click(object sender, EventArgs e)
        {
            new EventGroup(GroupName_Box.Text);
            EventGroup.Show(Groups_GridView);
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            EventGroup.Save();
        }

        private void Groups_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Group grp = (Group)Groups_GridView.Rows[e.RowIndex].Tag;
        }
        private void Calendar_Day_Selected(DateTime d)
        {
            
        }
    }
}
