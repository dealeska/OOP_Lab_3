using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace OOP_Lab_2
{
    abstract class Information
    {
        protected static BinaryFormatter binFormatter = new BinaryFormatter();
        protected static XmlSerializer xmlFormatter = new XmlSerializer(typeof(List<OOP_Lab_1.MenuItem>));
    } 
}
