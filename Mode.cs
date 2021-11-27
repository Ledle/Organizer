using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Organizer
{
    class Mode
    {
        private static Boolean showing = false;
        private static List<Mode> screens = new List<Mode>();
        private List<Control> objects;
        public Mode(Control[] elements)
        {
            objects = new List<Control>(elements);
            screens.Add(this);
        }
        public List<Control> Elements {
            get { return new List<Control>(objects); }
        }
        public void Show()
        {
            if (!showing)
            {
                showing = true;
                foreach (Mode s in screens)
                {
                    s.Hide();
                }
            }
            foreach (Control c in objects)
            {
                c.Show();
            }
            showing = false;
        }
        public void Hide()
        {
            foreach (Control c in objects)
            {
                c.Hide();
            }
        }
        public void Delelem(Control elem)
        {
            if (!(objects.Remove(elem)))
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public void Addelem(Control elem)
        {
            if (!(objects.Contains(elem)))
            {
                objects.Add(elem);
            }
        }
    }
}