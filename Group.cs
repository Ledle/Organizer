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
        private List<Task> tasks;
        private int priority;
        private String name;
        private Color color;
        private Image background;
        public void Add(Task t)
        {
            if (!tasks.Contains(t))
            {
                tasks.Add(t);
            }
        }
        public void Remove(Task t)
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
    }
}
