using System;
using OOP_Lab_1;


namespace OOP_Lab_2
{
    public sealed class FastFoodFactory : Factory
    {
        public FastFoodFactory()
        {
            this.Name = "FastFood";
            this.Image = "D:/С#/OOP_Lab_2/OOP_Lab_2/Resourses/FastFood.jpg";
        }

        public override MenuItem Create(params object[] args)
        {
            return new FastFood((Int32)args[0], (bool)args[1], (bool)args[2]);
        }

        public override string[] AskClient()
        {
            string[] question = new string[2];
            question[0] = AskAboutGloves();
            question[1] = AskAboutNapkin();
            return question;
        }

        public override string[] Answer1()
        {
            string[] s = { "Yes", "No" };
            return s;
        }

        public override string[] Answer2()
        {
            string[] s = { "Yes", "No" };
            return s;
        }       

        public static string AskAboutGloves()
        {
            return "Do you need gloves?";
        }

        public static string AskAboutNapkin()
        {
            return "Or maybe you need napkins?";
        }
    }
}
