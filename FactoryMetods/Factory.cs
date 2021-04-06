using System;
using OOP_Lab_1;

namespace OOP_Lab_2
{
    public abstract class Factory
    {
        public string Name { get; protected set; }
        public string Image { get; protected set; }

        public abstract MenuItem Create(params Object[] args);

        public abstract string[] AskClient();
        public abstract string[] Answer1();
        public abstract string[] Answer2();
    }
}
