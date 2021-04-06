using System;
using OOP_Lab_1;

namespace OOP_Lab_2
{
    public sealed class ColdDrinkFactory : Factory
    {
        public ColdDrinkFactory()
        {
            this.Name = "ColdDrink";
            this.Image = "D:/С#/OOP_Lab_2/OOP_Lab_2/Resourses/ColdDrink.jpg";
        }

        public override MenuItem Create(params object[] args)
        {
            return new ColdDrink((Int32)args[0], (bool)args[1], (bool)args[2]);
        }

        public override string[] AskClient()
        {
            string[] question = new string[2];
            question[0] = AskAboutCapasity();
            question[1] = AskAboutIce();            
            return question;
        }

        public override string[] Answer1()
        {
            string[] s = { "Small", "Middle", "Large" };
            return s;
        }

        public override string[] Answer2()
        {
            string[] s = { "Yes", "No" };
            return s;
        }        

        public static string AskAboutIce()
        {
            return "Do you need ice?";
        }

        public static string AskAboutCapasity()
        {
            return "Select capacity.";
        }
    }
}
