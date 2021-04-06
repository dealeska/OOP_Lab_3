using System;
using OOP_Lab_1;

namespace OOP_Lab_2
{
    public sealed class CakeFactory : Factory
    {
        public CakeFactory()
        {
            this.Name = "Cake";
            this.Image = "D:/С#/OOP_Lab_2/OOP_Lab_2/Resourses/Cake.jpg";
        }

        public override MenuItem Create(params object[] args)
        {
            return new Cake((Int32)args[0], (bool)args[1], (bool)args[2]);
        }


        public override string[] AskClient()
        {
            string[] question = new string[2];
            question[0] = AskAboutDelivery();
            question[1] = AskAboutRaisins();
            return question;
        }

        public override string[] Answer1()
        {
            string[] s = { "At the beginning", "In the end" };
            return s;
        }

        public override string[] Answer2()
        {
            string[] s = { "Yes", "No" };
            return s;
        }

        
        public static string AskAboutDelivery()
        {
            return "When to serve dessert?";
        }

        public static string AskAboutRaisins()
        {
            return "Need a raisins?";
        }
    }
}
