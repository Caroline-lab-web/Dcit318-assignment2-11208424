using System;

namespace InterfaceExample
{
    interface IWorker
    {
        void Work();
    }

    class Engineer : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Engineer is designing systems.");
        }
    }

    class Teacher : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Teacher is teaching students.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IWorker eng = new Engineer();
            IWorker teach = new Teacher();

            eng.Work();
            teach.Work();
        }
    }
}