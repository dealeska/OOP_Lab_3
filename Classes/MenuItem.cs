using System;
using System.Xml.Serialization;

namespace OOP_Lab_1
{
    [XmlInclude(typeof(MenuItem)), XmlInclude(typeof(Cake)), XmlInclude(typeof(ColdDrink)), XmlInclude(typeof(HotDrink)),
     XmlInclude(typeof(FastFood)), XmlInclude(typeof(IceCream))]
    [Serializable]
    public abstract class MenuItem
    {      
        public float Cost { get; set; }
        public bool ExtraFood { get; set; }
        public string Image { get; set; }

        static MenuItem()
        {
        }

        public MenuItem() { }

        public abstract string WriteDescription();
        //public abstract void AskClient();
        public virtual string GetHierarchy()
        {
            return "";            
        }
    }

}
