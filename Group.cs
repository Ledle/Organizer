using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Organizer
{
    [Serializable]
    abstract class Group
    {
        protected List<Event> tasks = new List<Event>();
        protected int priority;
        protected String name;
        protected Color color;
        protected Image background;
        protected static BinaryFormatter formatter = new BinaryFormatter();
        public Group()
        {
            priority = 0;
            name = "";
        }
        public Group(String name)
        {
            priority = 0;
            this.name = name;
        }
        public void Add(Event t)
        {
            if (!tasks.Contains(t))
            {
                tasks.Add(t);
                t.Group = this;
            }
        }
        public void Remove(Event t)
        {
            tasks.Remove(t);
            t.Group = null;
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