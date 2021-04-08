using System;

namespace OOP_Lab_1
{
    [Serializable]
    public sealed class ColdDrink : Drink
    {
        public bool Ice { get; set; }

        public ColdDrink(Int32 capacity, bool extraFood, bool ice) : base(capacity, extraFood)
        {
            Image = "D:/С#/OOP_Lab_2/OOP_Lab_2/Resourses/ColdDrink.jpg";
            this.Ice = ice;
            if (Ice)
               this.Cost += 10;
        }
        public ColdDrink() { }

        public override string WriteDescription()
        {           
            return GetHierarchy() + base.WriteDescription() + "Your drink " + ((Ice) ? "with ice.\n" : "without ice.\n") +
                   $"That'll be {Cost} money, please.";
        }

        public override string GetHierarchy()
        {
            return base.GetHierarchy() + "-> ColdDrinks.\n";
        }
    }
}
