using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    [Serializable]
    class Note
    {
        private String text;
        private NoteGroup group;
        public Note() {}
        public Note(String text)
        {
            this.text = text;
        }
        public String Text
        {
            get { return text; }
            set { text = value; }
        }
        public NoteGroup Group { 
            get { return group; }
            set { group = value; }
        }
    }
}
