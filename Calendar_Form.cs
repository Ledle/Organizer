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
            EventGroup.Load();
            EventGroup.Show(Groups_GridView);
            MonthCalendar.Tag = EventGroup.Groups[0];
            MonthCalendar.Enabled = true;
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
            EventGroup grp = (EventGroup)Groups_GridView.Rows[e.RowIndex].Tag;
            MonthCalendar.Tag = grp;
            MonthCalendar.Enabled = true;
        }
        private void Calendar_Day_Selected(DateTime d)
        {
            Events_GridView.Show();
            EventGroup grp = (EventGroup)MonthCalendar.Tag;
            List<Event> events = grp.GetEvents(d);
            EventGroup.ShowEvents(Events_GridView, events);
            Add_Panel.Show();
            Task_Panel.Tag = null;

        }

        private void NameTask_TextBox_TextChanged(object sender, EventArgs e)
        {
            if((sender as TextBox).Text != "")
            {
                (sender as TextBox).Parent.Location = new Point(234, AddButtons_Panel.Location.Y - 28);
                AddButtons_Panel.Show();
            }
            else
            {
                Control p = (sender as TextBox).Parent;
                p.Location = new Point(234, AddButtons_Panel.Location.Y);
                AddButtons_Panel.Hide();
            }
        }

        private void AddTask_Button_Click(object sender, EventArgs e)
        {
            EventGroup grp = MonthCalendar.Tag as EventGroup;
            Event ev = new Event(NameTask_TextBox.Text);
            ev.Date = MonthCalendar.SelectedDate;
            //ev.CompleteDate = CompleteDate_Picker1.Value;
            grp.Add(ev);
            EventGroup.ShowEvents(Events_GridView,grp.GetEvents(MonthCalendar.SelectedDate));
            NameTask_TextBox.Text = "";
        }

        private void Events_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Event evnt = (Event)Events_GridView.Rows[e.RowIndex].Tag;
            Task_Panel.Show();
            Task_Panel.Tag = evnt;
            TaskName_Textbox.Text = evnt.Name;
            TaskNotes_Textbox.Text = evnt.Description;
        }

        private void Delete_Button1_Click(object sender, EventArgs e)
        {
            (sender as Button).Parent.Hide();
            if ((sender as Button).Parent.Tag != null)
            {
                Event t = (sender as Button).Parent.Tag as Event;
                Group grp = t.Group;
                grp.Remove(t);
                List<Event> events = ((EventGroup)grp).GetEvents(t.Date);
                EventGroup.ShowEvents(Events_GridView, events);
            }
        }

        private void TaskNotes_Textbox_TextChanged(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            Event t = (Event)(Task_Panel.Tag);
            t.Description = tbx.Text;
        }
    }
}