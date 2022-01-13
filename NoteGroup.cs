using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Organizer
{
    [Serializable]
    class NoteGroup : Group
    {
        private static List<NoteGroup> groups = new List<NoteGroup>();
        private List<Note> notes = new List<Note>();
        public NoteGroup()
        {
            groups.Add(this);
        }
        public NoteGroup(String name)
        {
            this.name = name;
            groups.Add(this);
        }
        public List<Note> Notes { get { return notes; } }
        public static List<NoteGroup> Groups { get { return groups; } }
        public void Add(Note n)
        {
            notes.Add(n);
            n.Group = this;
        }
        public void Remove(Note n)
        {
            notes.Remove(n);
        }
        public static void Save()
        {
            String dir = "Notes.bin";
            FileStream fs = new FileStream(dir, FileMode.OpenOrCreate);
            formatter.Serialize(fs, groups);
            fs.Close();
        }
        public static void Load()
        {
            String dir = "Notes.bin";
            FileStream fl = new FileStream(dir, FileMode.OpenOrCreate);
            groups = (List<NoteGroup>)formatter.Deserialize(fl);
            fl.Close();
        }
        public static void Show(System.Windows.Forms.DataGridView gridView)
        {
            Group grp;
            gridView.Rows.Clear();
            for (int i = 0; i < NoteGroup.Groups.Count; i++)
            {
                grp = NoteGroup.Groups[i];
                gridView.Rows.Add(grp.Name);
                gridView.Rows[i].Tag = grp;
            }
        }
        public void ShowNotes(System.Windows.Forms.DataGridView gridView)
        {
            Note nt;
            gridView.Rows.Clear();
            for (int i = 0; i < notes.Count; i++)
            { 
                nt = notes[i];
                String name;
                if (nt.Text.Length > 20)
                {
                    name = nt.Text.Substring(0, 20) + "...";
                }
                else
                {
                    name = nt.Text;
                }
                gridView.Rows.Add(name);
                gridView.Rows[i].Tag = nt;
            }
            gridView.Tag = this;
        }
    }
}