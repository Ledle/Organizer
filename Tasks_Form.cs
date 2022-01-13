using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Organizer
{
    public partial class Tasks_Form : Form
    {
        public Tasks_Form()
        {
            InitializeComponent();
            Tasks_GridView.Columns[0].Width = Tasks_GridView.Width;
            Saver.Directory = "test.bin";
            TaskGroup.Load();
            TaskGroup.Show(Groups_GridView);
            NameTask_TextBox_TextChanged(NameTask_TextBox, null);

        }
        private void Tasks_button_Click(object sender, EventArgs e)
        {
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Calendar_button_Click(object sender, EventArgs e)
        {
        }

        private void Notes_button_Click(object sender, EventArgs e)
        {
        }

        private void AddTask_Button_Click(object sender, EventArgs e)
        {
            Group grp = Tasks_GridView.Tag as Group;
            Task t = new Task(NameTask_TextBox.Text);//Дописать
            t.CompleteDate = CompleteDate_Picker1.Value;
            grp.Add(t);
            grp.ShowTasks(Tasks_GridView);
            NameTask_TextBox.Text = "";
        }

        private void Groups_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Task_Panel.Hide();
            RemindDate_Picker.Hide();
            CompleteDate_Picker.Hide();
            Tasks_GridView.Show();
            Add_Panel.Show();
            Group grp = (Group)Groups_GridView.Rows[e.RowIndex].Tag;
            grp.ShowTasks(Tasks_GridView);
        }
        private void Task_Show(Task tsk)
        {
            Task_Panel.Show();
            Task_Panel.Tag = tsk;
            TaskName_Textbox.Text = tsk.Name;
            TaskNotes_Textbox.Text = tsk.Description;
            Complete_Box.Checked = tsk.Completed;
        }

        private void Tasks_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Task t = (Task)Tasks_GridView.Rows[e.RowIndex].Tag;
            Task_Show(t);
        }

        private void TaskNotes_Textbox_TextChanged(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            Task t = (Task)(Task_Panel.Tag);
            t.Description = tbx.Text;
        }

        private void TaskName_Textbox_TextChanged(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            Task tsk = tbx.Parent.Tag as Task;
            tsk.Name = tbx.Text;
            Task t;
            for (int i = 0; i<Tasks_GridView.Rows.Count; i++)
            {
                t = Tasks_GridView.Rows[i].Tag as Task;
                if (t == tsk)
                {
                    Tasks_GridView.Rows[i].Cells[0].Value = tsk.Name;
                }
            }
        }

        private void Complete_Box_CheckedChanged(object sender, EventArgs e)
        {
            Boolean f = (sender as CheckBox).Checked;
            Task t = (sender as CheckBox).Parent.Tag as Task;
            if (f) { t.Complete(); }
            else { t.Uncomplete(); }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            (sender as Button).Parent.Hide();
            Task t = (sender as Button).Parent.Tag as Task;
            Group grp = t.Group;
            grp.Remove(t);
            grp.ShowTasks(Tasks_GridView);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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
        private void CompleteDate1_Button_Click(object sender, EventArgs e)
        {
            CompleteDate_Picker1.Visible = !CompleteDate_Picker1.Visible;
            RemindDate_Picker1.Hide();
        }
        private void Remind1_Button_Click(object sender, EventArgs e)
        {
            RemindDate_Picker1.Visible = !RemindDate_Picker1.Visible;
            CompleteDate_Picker1.Hide();
        }

        private void CompleteDate_Button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            Task t = b.Parent.Tag as Task;
            CompleteDate_Picker.Value = t.CompleteDate; 
            CompleteDate_Picker.Visible = !CompleteDate_Picker.Visible;
            RemindDate_Picker.Hide();
        }

        private void Remind_Button_Click(object sender, EventArgs e)
        {
            RemindDate_Picker.Visible = !RemindDate_Picker.Visible;
            CompleteDate_Picker.Hide();
        }

        private void CompleteDate_Picker_ValueChanged(object sender, EventArgs e)
        {
            (Task_Panel.Tag as Task).CompleteDate = CompleteDate_Picker.Value;
        }

        private void RemindDate_Picker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            TaskGroup.Save();
        }
    }
}