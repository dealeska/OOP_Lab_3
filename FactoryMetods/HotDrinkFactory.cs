using System;
using OOP_Lab_1;

namespace OOP_Lab_2
{
    public sealed class HotDrinkFactory : Factory
    {
        public HotDrinkFactory()
        {
            this.Name = "HotDrink";
            this.Image = "D:/С#/OOP_Lab_2/OOP_Lab_2/Resourses/HotDrink.jpg";
        }

        public override MenuItem Create(params object[] args)
        {
            return new HotDrink((Int32)args[0], (bool)args[1], (bool)args[2]);
        }

        public override string[] AskClient()
        {
            string[] question = new string[2];
            question[0] = AskAboutCapasity();
            question[1] = AskAboutSugar();          
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

        public static string AskAboutSugar()
        {
            return "Do you need sugar?";
        }

        public static string AskAboutCapasity()
        {
            return "Select capacity.";
        }
    }
}
