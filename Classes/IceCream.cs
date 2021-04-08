using System;

namespace OOP_Lab_1
{
    [Serializable]
    public sealed class IceCream : Dessert
    {
        public TTaste Taste { get; set; }

        public IceCream(Int32 delivery, bool extraFood, bool taste) : base(delivery, extraFood)
        {
            Name = "IceCream";
            Image = "D:/С#/OOP_Lab_2/OOP_Lab_2/Resourses/IceCream.jpg";
            switch (taste)
            {
                case true:
                    this.Cost += 10;
                    this.Taste = TTaste.vanilla;
                    break;
                case false:
                    this.Cost += 20;
                    this.Taste = TTaste.chokolate;
                    break;
                default:
                    this.Cost += 10;
                    this.Taste = TTaste.vanilla;
                    break;
            }
        }

        public IceCream() { }

        public override string WriteDescription()
        {
            return GetHierarchy() + base.WriteDescription() + $"Your ice-cream with {Taste} taste.\n" +
                   $"That'll be {Cost} money, please.";
        }

        public override string GetHierarchy()
        {
            return base.GetHierarchy() + "-> IceCream.\n";
        }
    }
}

