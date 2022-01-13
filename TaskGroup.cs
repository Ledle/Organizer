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
    class TaskGroup:Group
    {
        protected static List<Group> groups = new List<Group>();
        public TaskGroup():base() {
            groups.Add(this);
        }
        public TaskGroup(String name) : base(name) {
            groups.Add(this);
        }
        public static List<Group> Groups
        {
            get { return new List<Group>(groups); }
        }
        public static void Show(System.Windows.Forms.DataGridView gridView)
        {
            Group grp;
            gridView.Rows.Clear();
            for (int i = 0; i < TaskGroup.Groups.Count; i++)
            {
                grp = TaskGroup.Groups[i];
                gridView.Rows.Add(grp.Name);
                gridView.Rows[i].Tag = grp;
            }
        }
        public static void Save()
        {
            String dir = "Tasks.bin";
            FileStream fs = new FileStream(dir, FileMode.OpenOrCreate);
            formatter.Serialize(fs, groups);
            fs.Close();
        }
        public static void Load()
        {
            String dir = "Tasks.bin";
            FileStream fl = new FileStream(dir, FileMode.OpenOrCreate);
            groups = (List<Group>)formatter.Deserialize(fl);
            fl.Close();
        }
    }
}
