﻿using System;
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
    public partial class Tasks_Form : Form
    {
        public Tasks_Form()
        {
            InitializeComponent();
            Task t;
            Tasks_GridView.Columns[0].Width = Tasks_GridView.Width;
            Group[] tasks = new Group[3];
            tasks[0] = new Group("Дом");
            tasks[1] = new Group("Матан");
            tasks[2] = new Group("Курсач");
            tasks[0].Add(new Task("Сделать курсач"));
            tasks[1].Add(new Task("Cancel"));
            tasks[2].Add(new Task("OK"));
            Group.Show(Groups_GridView);
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
            grp.Add(t);
            grp.ShowTasks(Tasks_GridView);
        }

        private void Groups_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Task_Panel.Hide();
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
            Task t = (sender as Button).Parent.Tag as Task;
            Group grp = t.Group;
            grp.Remove(t);
            grp.ShowTasks(Tasks_GridView);
        }
    }
}