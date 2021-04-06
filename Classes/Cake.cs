using System;
using System.Xml.Serialization;

namespace OOP_Lab_1
{
    [XmlInclude(typeof(MenuItem))]
    [Serializable]
    public sealed class Cake : Dessert
    {
        public bool Raisins { get; set; }
        public Cake(Int32 delivery, bool extraFood, bool raisins) : base(delivery, extraFood)
        {
            Image = "D:/С#/OOP_Lab_2/OOP_Lab_2/Resourses/Cake.jpg";
            this.Raisins = raisins;
            if (Raisins)
                this.Cost += 20;
        }
        public Cake() { }

        public override string WriteDescription()
        {
            return GetHierarchy() + base.WriteDescription() + "Your dessert " + 
                   ((Raisins) ? "with raisins.\n" : "without raisins.\n") +
                   $"That'll be {Cost} money, please.";
        }

        public override string GetHierarchy()
        {
            return base.GetHierarchy() + "-> Cakes.\n";
        }
    }
}
