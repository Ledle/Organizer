using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    [Serializable]
    class EventGroup:Group
    {
        protected static List<Group> groups = new List<Group>();
        public EventGroup() : base() {
            groups.Add(this);
        }
        public EventGroup(String name) : base(name) {
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
            for (int i = 0; i < EventGroup.Groups.Count; i++)
            {
                grp = EventGroup.Groups[i];
                gridView.Rows.Add(grp.Name);
                gridView.Rows[i].Tag = grp;
            }
        }
        public static void Save()
        {
            Saver.Save(groups);
        }
        public static void Load()
        {
            groups = Saver.Load();
        }
    }
}
