using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    class Task
    {
        private Group group;
        private TimeSpan cycle;
        private DateTime date;
        private DateTime enddate;
        private String name;
        private String description;
        private List<String> tags = new List<String>();
        private int priority;
        private List<Task> childr = new List<Task>();
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
            parent.AddKid(this);
        }
        public DateTime End
        {
            get { return enddate; }
            set { enddate = value; }
        }
        public Task Clone()
        {
            Task t = new Task();
            t.group = group;
            t.name = name;
            t.description = description;
            t.priority = priority;
            t.tags = tags;
            t.date = date;
            t.cycle = cycle;
            foreach (Task kid in childr)
            {
                t.childr.Add(kid.Clone());
            }
            return t;
        }
        public TimeSpan Cycle
        {
            get { return cycle; }
            set 
            {
                if (value.TotalMinutes < 0)
                {
                    throw new Exception("Значение цикла должно быть больше нуля");
                }
                else
                {
                    cycle = value;
                }
            }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public String Name
        {
            get { return name; }
            set 
            {
                if (value.Length == 0) {
                    throw new Exception("Имя не должно быть пустым");
                } 
            }
        }
        public String Description {
            get { return description; }
            set { description = value; }
        }
        public Boolean Completed
        {
            get { return complete; }
        }
        public void AddTag(String tag)
        {
            if (tags.Contains(tag))
            {
                tags.Add(tag);
            }
        }
        public void DelTag(String tag)
        {
            if (!(tags.Remove(tag)))
            {
                throw new Exception("Заданного тега не существует");
            }
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
        public void AddKid(Task t)
        {
            if (!childr.Contains(t))
            {
                childr.Add(t);
            }
        }
        public void RemKid(Task t)
        {
            childr.Remove(t);
        }
        
    }
}