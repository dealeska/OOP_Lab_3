using System;

namespace OOP_Lab_1
{
    [Serializable]
    public class Drink : MenuItem
    {
        public TCapacity Capacity { get; set; }        

        public Drink(Int32 capacity, bool extraFood)
        {
            this.ExtraFood = extraFood;            
            switch (capacity)
            {
                case 0:
                    this.Cost = 200;
                    this.Capacity = TCapacity.small;
                    break;
                case 1:
                    this.Cost = 400;
                    this.Capacity = TCapacity.middle;
                    break;
                case 2:
                    this.Cost = 600;
                    this.Capacity = TCapacity.large;
                    break;
                default:
                    this.Cost = 200;
                    this.Capacity = TCapacity.small;
                    break;
            }
        }

        public override string WriteDescription()
        {
            return $"You choose a drink {Capacity} capacity " +
                  ((ExtraFood) ? "take it away.\n" : "take it here.\n");
        }

        public override string GetHierarchy()
        {
            return base.GetHierarchy() + "Menu -> Drinks ";
        }
    }
}

