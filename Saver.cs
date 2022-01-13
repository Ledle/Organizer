using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Organizer
{
    static class Saver
    {
        private static String dir;
        private static BinaryFormatter formatter = new BinaryFormatter();
        public static void Save(List<Group> grp)
        {
            FileStream fs = new FileStream(dir, FileMode.OpenOrCreate);
            formatter.Serialize(fs, TaskGroup.Groups);
            fs.Close();
        }
        public static List<Group> Load()
        {
            FileStream fl = new FileStream(dir, FileMode.OpenOrCreate);
            List<Group> grps = (List<Group>)formatter.Deserialize(fl);
            fl.Close();
            return grps;
        }
        public static String Directory
        {
            set
            {
                FileStream fs = new FileStream(value, FileMode.OpenOrCreate);
                dir = value;
                fs.Close();
            }
            get
            {
                return dir;
            }
        }
    }
}
