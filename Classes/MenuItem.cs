using System;

namespace OOP_Lab_1
{
    [Serializable]
    public abstract class MenuItem
    {      
        public float Cost { get; protected set; }
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
