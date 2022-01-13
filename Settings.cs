using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    struct Settings
    {
        private String notepath;
        private String taskpath;
        private String eventpath;
        private int defaultform;
        public Settings(String NotePath, String TaskPath, String EventPath, int defaultFrom)
        {
            this.notepath = NotePath;
            this.taskpath = TaskPath;
            this.eventpath = EventPath;
            this.defaultform = defaultFrom;
        }
        public String NotePath { get { return notepath; } }
        public String TaskPath { get { return taskpath; } }
        public String EventPath { get { return eventpath; } }
        public int DefaultForm { get { return defaultform; } }

    }
}
