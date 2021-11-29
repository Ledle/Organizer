using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    abstract class Act
    {
        private Group group;
        private TimeSpan cycle;
        private DateTime date;
        private DateTime enddate;
        private String name;
        private String description;
        private List<String> tags = new List<String>();
        private Boolean complete;
        public Act()
        {
            date = new DateTime(0);
            cycle = new TimeSpan(0);
            enddate = new DateTime(0);
            name = "";
            description = "";
            complete = false;
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
                if (value.Length == 0)
                {
                    throw new Exception("Имя не должно быть пустым");
                }
            }
        }
        public String Description
        {
            get { return description; }
            set { description = value; }
        }
        public Boolean Completed
        {
            get { return complete; }
        }
        public DateTime End
        {
            get { return enddate; }
            set { enddate = value; }
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
        public void Uncomplete() { complete = false; }
    }
}
