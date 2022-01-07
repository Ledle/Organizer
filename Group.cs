using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Organizer
{
    class Group
    {
        private static List<Group> groups = new List<Group>();
        private List<Event> tasks = new List<Event>();
        private int priority;
        private String name;
        private Color color;
        private Image background;
        public Group()
        {
            groups.Add(this);
            priority = 0;
            name = "";
        }
        public Group(String name)
        {
            groups.Add(this);
            priority = 0;
            this.name = name;
        }
        public static List<Group> Groups
        {
            get { return new List<Group>(groups); }
        }
        public void Add(Task t)
        {
            if (!tasks.Contains(t))
            {
                tasks.Add(t);
            }
        }
        public void Remove(Event t)
        {
            tasks.Remove(t);
        }
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
        public String Name
        {
            get { return name; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Имя не должно быть пустым");
                }
                name = value;
            }
        }
        public Image Background
        {
            get { return background; }
            set { background = value; }
        }
        public Task[] GetTasks(DateTime date)
        {
            List<Task> res = new List<Task>();
            foreach (Task t in tasks)
            {
                if (t.End > date)
                {
                    res.Add(t);
                }
            }
            return res.ToArray();
        }
        public List<Event> Tasks
        {
            get { return tasks; }
        }
        public static void Show(System.Windows.Forms.DataGridView gridView)
        {
            Group grp;
            gridView.Rows.Clear();
            for (int i = 0; i < Group.Groups.Count; i++)
            {
                grp = Group.Groups[i];
                gridView.Rows.Add(grp.Name);
                gridView.Rows[i].Tag = grp;
            }
        }
        public void ShowTasks(System.Windows.Forms.DataGridView gridView)
        {
            Event tsk;
            gridView.Rows.Clear();
            for (int i = 0; i < tasks.Count; i++)
            {
                tsk = tasks[i];
                gridView.Rows.Add(tsk.Name);
                gridView.Rows[i].Tag = tsk;
            }
            gridView.Tag = this;
        }
    }
}
