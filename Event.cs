using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    [Serializable]
    class Event
    {
        private protected Group group;
        private protected TimeSpan cycle;
        private protected DateTime date;
        private protected DateTime enddate;
        private protected String name;
        private protected String description;
        private protected List<String> tags = new List<String>();
        public Event()
        {
            date = new DateTime(0);
            cycle = new TimeSpan(0);
            name = "";
            description = "";
        }
        public Event(String name)
        {
            date = new DateTime(0);
            cycle = TimeSpan.Zero;
            this.name = name;
            description = "";
        }
        public Event(Event parent)
        {
            date = new DateTime(0);
            cycle = TimeSpan.Zero;
            name = "";
            description = "";
        }
        public DateTime End
        {
            get { return enddate; }
            set { enddate = value; }
        }
        public Event Clone()
        {
            Event t = new Event();
            t.group = group;
            t.name = name;
            t.description = description;
            t.tags = tags;
            t.date = date;
            t.cycle = cycle;
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
                name = value;
            }
        }
        public String Description
        {
            get { return description; }
            set { description = value; }
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
        public Group Group
        {
            get { return group; }
            set {
                if (group != value)
                {
                    if (group!=null&&group.Tasks.Contains(this)) { group.Remove(this); }
                    group = value;
                }
            }
        }
    }
}
