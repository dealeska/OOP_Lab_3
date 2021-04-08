using System;

namespace OOP_Lab_1
{
    [Serializable]
    public sealed class HotDrink : Drink
    {
        public bool sugar { get; set; }        
        public HotDrink(Int32 capacity, bool extraFood, bool sugar) : base(capacity, extraFood)
        {
            Image = "D:/С#/OOP_Lab_2/OOP_Lab_2/Resourses/HotDrink.jpg";
            this.sugar = sugar;
            if (sugar)
                this.Cost += 10;
        }

        public HotDrink() { }
      
        public override string WriteDescription()
        {
            return GetHierarchy() + base.WriteDescription() + "Your drink " + ((sugar) ? "with sugar.\n" : "without sugar.\n") + 
                   $"That'll be {Cost} money, please.";
        }

        public override string GetHierarchy()
        {
            return base.GetHierarchy() + "-> HotDrinks.\n";
        }
    }
}
