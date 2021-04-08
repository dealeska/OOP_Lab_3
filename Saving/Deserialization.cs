using System.Collections.Generic;
using System.IO;

namespace OOP_Lab_2
{
    class Deserialization : Information
    {
        public static List<OOP_Lab_1.MenuItem> BinDeserialize(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                return (List<OOP_Lab_1.MenuItem>)binFormatter.Deserialize(fs);
            }
        }

        public static List<OOP_Lab_1.MenuItem> XmlDeserialize(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                return (List<OOP_Lab_1.MenuItem>)xmlFormatter.Deserialize(fs);
            }
        }
    }
}
