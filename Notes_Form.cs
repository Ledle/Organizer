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
    public partial class Notes_Form : Form
    {
        public Notes_Form()
        {
            InitializeComponent();
            NoteGroup.Load();
            NoteGroup.Show(Groups_GridView);
            NoteGroup grp = (NoteGroup)Groups_GridView.Rows[0].Tag;
            grp.ShowNotes(Notes_GridView);

        }
        private void AddGroup_Button_Click(object sender, EventArgs e)
        {
            new NoteGroup(GroupName_Box.Text);
            NoteGroup.Show(Groups_GridView);
        }

        private void Groups_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NoteGroup grp = (NoteGroup)Groups_GridView.Rows[e.RowIndex].Tag;
            grp.ShowNotes(Notes_GridView);
        }

        private void AddNote_Button_Click(object sender, EventArgs e)
        {
            NoteGroup grp = Notes_GridView.Tag as NoteGroup;
            Note n = new Note(Note_TextBox.Text);//Дописать
            grp.Add(n);
            grp.ShowNotes(Notes_GridView);
            Note_TextBox.Tag = n;
            Delete_Button.Show();

        }

        private void Notes_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Note nt = (Note)Notes_GridView.Rows[e.RowIndex].Tag;
            Note_TextBox.Tag = nt;
            Note_TextBox.Text = nt.Text;
            Delete_Button.Show();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            NoteGroup.Save();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            (sender as Button).Hide();
            Note nt = Note_TextBox.Tag as Note;
            NoteGroup grp = nt.Group;
            grp.Remove(nt);
            grp.ShowNotes(Notes_GridView);
            Note_TextBox.Text = "";
        }

        private void Note_TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            if (tbx.Tag != null)
            {
                Note nt = tbx.Tag as Note;
                nt.Text = tbx.Text;
                nt.Group.ShowNotes(Notes_GridView);
            }
        }
    }
}