using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    class Task:Event
    {
        private int priority;
        private List<Task> subtasks = new List<Task>();
        private Boolean complete;
        public Task()
        {
            date = new DateTime(0);
            cycle = new TimeSpan(0);
            name = "";
            description = "";
            complete = false;
        }
        public Task(Task parent)
        {
            date = new DateTime(0);
            cycle = TimeSpan.Zero;
            name = "";
            description = "";
            complete = false;
            parent.AddSub(this);
        }
        new public Task Clone()
        {
            Task t = new Task();
            t.group = group;
            t.name = name;
            t.description = description;
            t.priority = priority;
            t.tags = tags;
            t.date = date;
            t.cycle = cycle;
            foreach (Task kid in subtasks)
            {
                t.subtasks.Add(kid.Clone());
            }
            return t;
        }
        public Boolean Completed
        {
            get { return complete; }
        }
        public void Complete() {
            if(cycle != TimeSpan.Zero)
            {
                Task t = this.Clone();
                t.date += cycle;
                group.Add(t);
            }
            complete = true;
        }
        public void Uncomplete() { complete = false; }
        public static Boolean operator >(Task a, Task b) {return a.priority > b.priority;}
        public static Boolean operator <(Task a,Task b){ return a.priority < b.priority; }
        public void AddSub(Task t)
        {
            if (!subtasks.Contains(t))
            {
                subtasks.Add(t);
            }
        }
        public void RemSub(Task t)
        {
            subtasks.Remove(t);
        }
    }
}