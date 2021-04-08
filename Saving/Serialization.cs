using System.Collections.Generic;
using System.IO;

namespace OOP_Lab_2
{
    class Serialization : Information
    {
        public static void BinSerialize(string fileName, List<OOP_Lab_1.MenuItem> list)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                binFormatter.Serialize(fs, list);
            }
        }

        public static void XMLSerialize(string fileName, List<OOP_Lab_1.MenuItem> list)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xmlFormatter.Serialize(fs, list);
            }
        }
    }
}
