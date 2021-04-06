using System;
using System.Xml.Serialization;

namespace OOP_Lab_1
{
    [XmlInclude(typeof(MenuItem))]
    [Serializable]
    public class Dessert : MenuItem
    {
        public TDelivery Delivery { get; set; }
        public Dessert(Int32 delivery, bool extraFood)
        {
            this.ExtraFood = extraFood;            
            switch (delivery)
            {
                case 0:
                    this.Cost = 300;
                    this.Delivery = TDelivery.beginning;
                    break;
                case 1:
                    this.Cost = 200;
                    this.Delivery = TDelivery.end;
                    break;
                default:
                    this.Cost = 200;
                    this.Delivery = TDelivery.end;
                    break;
            }
        }
        public Dessert() { }

        public override string WriteDescription()
        {
            return $"You choose a dessert with serving at the {Delivery} and " +
                   ((ExtraFood) ? "take it away.\n" : "take it here.\n");
        }


        public override string GetHierarchy()
        {
            return base.GetHierarchy() + "Menu -> Desserts ";
        }
    }
}
