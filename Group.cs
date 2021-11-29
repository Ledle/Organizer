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
        private List<Act> acts;
        private int priority;
        private String name;
        private Color color;
        private Image background;
        public void Add(Act t)
        {
            if (!acts.Contains(t))
            {
                acts.Add(t);
            }
        }
        public void Remove(Act t)
        {
            acts.Remove(t);
        }
        public int Priority
        {
            set { 
                if (value < 0) 
                {
                    throw new Exception("Приоритет должен быть больше нуля");
                }
                priority = value;
            }
            get { return priority; }
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
        public Act[] GetTasks(DateTime date)
        {
            List<Act> res = new List<Act>();
            foreach (Act t in acts)
            {
                if(t.End > date)
                {
                    res.Add(t);
                }
            }
            return res.ToArray();
        }

    }
}
