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
        
    }
}
