using System;
using OOP_Lab_1;

namespace OOP_Lab_2
{
    public sealed class IceCreamFactory : Factory
    {
        public IceCreamFactory()
        {
            this.Name = "IceCream";
            this.Image = "D:/С#/OOP_Lab_2/OOP_Lab_2/Resourses/IceCream.jpg";
        }

        public override MenuItem Create(params object[] args)
        {
            return new IceCream((Int32)args[0], (bool)args[1], (bool)args[2]);
        }

        public override string[] AskClient()
        {
            string[] question = new string[2];
            question[0] = AskAboutDelivery();
            question[1] = AskAboutTaste(); 
            return question;
        }

        public override string[] Answer1()
        {
            string[] s = { "At the beginning", "In the end" };
            return s;
        }

        public override string[] Answer2()
        {
            string[] s = { "Vanilla", "Chokolate" };
            return s;
        }

        public static string AskAboutDelivery()
        {
            return "When to serve dessert?";
        }

        public static string AskAboutTaste()
        {
            return "Select taste.";
        }

    }
}
